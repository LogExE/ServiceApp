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
        string lastQuery = null;

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
            FillTheGrid(cmd);

            lastQuery = query;
        }

        private void FillTheGrid(SqlCommand cmd)
        {
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
            string cursel = getTableComboTextSelection();
            if (!nameToTable.ContainsKey(cursel) || !admin && !freeToWrite.Contains(cursel))
            {
                addButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                allowed = false;
                if (!nameToTable.ContainsKey(cursel))
                    return;
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
            AllRowsFromTableIntoGrid(nameToTable[cursel]);
        }

        private Form GimmeTableForm(string name, Dictionary<string, object> fields)
        {
            var typ = Type.GetType(nameof(ServiceApp) + "." + name + "Form");
            return Activator.CreateInstance(typ, new object[] { fields }) as Form;
        }

        private void RefreshGrid()
        {
            AllRowsFromQueryIntoGrid(lastQuery);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string table = nameToTable[getTableComboTextSelection()];
            var form = GimmeTableForm(table, null);
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
                RefreshGrid();
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
                RefreshGrid();
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
            RefreshGrid();
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
            if (!nameToTable.ContainsKey(getTableComboTextSelection()) || nameToTable[getTableComboTextSelection()] != "Request")
                return;

            int reqId = (int)mainDataGrid.Rows[e.RowIndex].Cells["ID"].Value;
            string query = $"SELECT OrderedTask.* FROM OrderedTask JOIN RequestOrderedTask RO ON RO.OrderedTask = OrderedTask.ID WHERE RO.Request = {reqId}";

            AllRowsFromQueryIntoGrid(query);
            tableComboBox.Text = "Задачи по заказу";
        }

        private int? getIntFromMessageBox(string prompt)
        {
            string resp = Interaction.InputBox(prompt);
            if (resp == "")
                return null;
            int ret;
            try
            {
                ret = int.Parse(resp);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return ret;
        }

        private void reqGenButton_Click(object sender, EventArgs e)
        {
            int? id = getIntFromMessageBox("Введите номер заявки!");
            if (id == null)
                return;
            AllRowsFromQueryIntoGrid($"SELECT * FROM RequestForm WHERE RequestID = {id}");
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
            AllRowsFromTableIntoGrid("EditableView");
            tableComboBox.Text = "Заявки с запчастями";
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            int? req1 = getIntFromMessageBox("Введите номер основного заказа");
            if (req1 == null)
                return;
            int? req2 = getIntFromMessageBox("Введите номер заказа, который нужно объединить с основным");
            if (req2 == null)
                return;
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "merge_requests";
            cmd.Parameters.Add(new SqlParameter("@req1", req1));
            cmd.Parameters.Add(new SqlParameter("@req2", req2));
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            if (nameToTable[getTableComboTextSelection()] == "RequestOrderedTask")
                RefreshGrid();
        }

        private void reqTasksButton_Click(object sender, EventArgs e)
        {
            using var con = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
            con.Open();

            int? req = getIntFromMessageBox("Введите номер заказа");
            if (req == null)
                return;
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_request_progress";
            cmd.Parameters.Add(new SqlParameter("@req_id", req));
            Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            FillTheGrid(cmd);
        }

        private void taskDatesButton_Click(object sender, EventArgs e)
        {
            var procForm = new TaskAppliedOnForm();
            if (procForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show(procForm.result.ToString(), "Результат процедуры");
        }
    }
}
