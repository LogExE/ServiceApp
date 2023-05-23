using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace ServiceApp
{
    public partial class InterfaceForm : Form
    {
        bool admin;
        bool allowed = false;

        Dictionary<string, string> nameToTable = new Dictionary<string, string>()
        {
            {"Клиенты", "Client"},
            {"Устройства", "Device"},
            {"Виды обслуживания", "Task"},
            {"Работники", "Employee"},
            {"Подразделения", "Division"},
            {"Заказы", "Request"},
            {"Задачи", "OrderedTask"},
            {"Задачи в работе", "TaskInProgress"},
            {"Выполненные заказы", "FinishedRequest"},
            {"Клиенты : Устройства", "ClientDevice"},
            {"Работник : Подразделение", "EmployeeDivision"},
            {"Работник : Виды обслуживания", "EmployeeTask"},
            {"Заказы : Задачи", "RequestOrderedTask"},
            {"Пользователи", "AppUser"}
        };

        HashSet<string> freeToWrite = new HashSet<string>()
        {
            "Клиенты", "Клиенты : Устройства",
            "Задачи", "Задачи в работе",
            "Заказы", "Выполненные заказы", "Заказы : Задачи"
        };

        public InterfaceForm(bool admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            roleLabel.Text = "Вы зашли за " + (admin ? "администратора" : "приемщика заказов");

            tableComboBox.DataSource = nameToTable.Keys.ToList();
            tableComboBox.SelectedIndex = 0;
        }

        private void AllRowsFromTableIntoGrid(string table)
        {
            AllRowsFromQueryIntoGrid($"SELECT * FROM {table}");
        }

        private void AllRowsFromQueryIntoGrid(string query)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = query;
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();

            var dt = new DataTable();
            var adapter = new SqlDataAdapter(cmd);
            mainDataGrid.DataSource = dt;
            adapter.Fill(dt);

            mainDataGrid.EndEdit();
        }

        private string getTableComboTextSelection()
        {
            return tableComboBox.Text;
        }

        private void tableComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!nameToTable.Keys.Contains(getTableComboTextSelection()))
            {
                addButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                allowed = false;
                return;
            }

            string text = getTableComboTextSelection();
            AllRowsFromTableIntoGrid(nameToTable[text]);

            if (!admin && !freeToWrite.Contains(text))
            {
                addButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                allowed = false;
            }
            else
            {
                addButton.Enabled = true;
                allowed = true;
                if (mainDataGrid.SelectedRows.Count != 0)
                {
                    updateButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
            }
        }

        private Form GimmeTableForm(string name, Dictionary<string, object> fields)
        {
            var typ = Type.GetType(nameof(ServiceApp) + "." + name + "Form");
            return Activator.CreateInstance(typ, new object[] { fields }) as Form;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string table = nameToTable[getTableComboTextSelection()];
            var form = GimmeTableForm(table, null);
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
                AllRowsFromTableIntoGrid(table);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string table = nameToTable[getTableComboTextSelection()];

            Dictionary<string, object> fields = new Dictionary<string, object>();
            foreach (DataGridViewCell cell in mainDataGrid.SelectedRows[0].Cells)
                fields[mainDataGrid.Columns[cell.ColumnIndex].Name] = cell.Value;

            var form = GimmeTableForm(table, fields);
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
                AllRowsFromTableIntoGrid(table);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string table = nameToTable[getTableComboTextSelection()];

            if (MessageBox.Show("Действительно удалить строку?", "Подтвердите действие",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            string idCol = (table == "FinishedRequest") ? "Request" : "ID";
            int idToDelete = (int)mainDataGrid.SelectedRows[0].Cells[idCol].Value;
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = $"DELETE FROM {table} WHERE {idCol} = {idToDelete}";
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            AllRowsFromTableIntoGrid(table);
        }

        private void mainDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (!nameToTable.Keys.Contains(getTableComboTextSelection()) || mainDataGrid.SelectedRows.Count == 0)
            {
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            else if (allowed)
            {
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void mainDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (nameToTable[getTableComboTextSelection()] != "Request")
                return;

            int reqId = (int)mainDataGrid.Rows[e.RowIndex].Cells["ID"].Value;
            string query = $"SELECT OrderedTask.* FROM OrderedTask JOIN RequestOrderedTask RO ON RO.OrderedTask = OrderedTask.ID WHERE RO.Request = {reqId}";

            AllRowsFromQueryIntoGrid(query);
            tableComboBox.Text = "Задачи по заказу";
        }

        private void reqGenButton_Click(object sender, EventArgs e)
        {
            string resp = Interaction.InputBox("Введите номер заявки!");
            if (resp == "")
                return;
            int id;
            try
            {
                id = int.Parse(resp);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AllRowsFromQueryIntoGrid($"SELECT * FROM RequestForm WHERE ID = {id}");
            tableComboBox.Text = "Форма заявки";
        }

        private void reqByClButton_Click(object sender, EventArgs e)
        {
            AllRowsFromTableIntoGrid("RequestsByClients");
            tableComboBox.Text = "Заявки по клиентам";
        }

        private void taskPartsButton_Click(object sender, EventArgs e)
        {
            AllRowsFromTableIntoGrid("ClusteredView");
            tableComboBox.Text = "Заявки с запчастями";
        }

        private void edViewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
