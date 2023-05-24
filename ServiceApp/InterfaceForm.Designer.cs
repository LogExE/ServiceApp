namespace ServiceApp
{
    partial class InterfaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainDataGrid = new DataGridView();
            roleLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            groupBox2 = new GroupBox();
            edViewButton = new Button();
            taskPartsButton = new Button();
            reqByClButton = new Button();
            reqGenButton = new Button();
            groupBox3 = new GroupBox();
            taskDatesButton = new Button();
            reqTasksButton = new Button();
            mergeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mainDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // mainDataGrid
            // 
            mainDataGrid.AllowUserToAddRows = false;
            mainDataGrid.AllowUserToDeleteRows = false;
            mainDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataGrid.Location = new Point(19, 52);
            mainDataGrid.Margin = new Padding(19, 2, 19, 2);
            mainDataGrid.MultiSelect = false;
            mainDataGrid.Name = "mainDataGrid";
            mainDataGrid.ReadOnly = true;
            mainDataGrid.RowHeadersWidth = 82;
            mainDataGrid.RowTemplate.Height = 41;
            mainDataGrid.Size = new Size(1191, 480);
            mainDataGrid.TabIndex = 1;
            mainDataGrid.RowHeaderMouseDoubleClick += mainDataGrid_RowHeaderMouseDoubleClick;
            mainDataGrid.RowStateChanged += mainDataGrid_RowStateChanged;
            // 
            // roleLabel
            // 
            roleLabel.Dock = DockStyle.Fill;
            roleLabel.Location = new Point(6, 0);
            roleLabel.Margin = new Padding(6, 0, 6, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(1217, 50);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "<роль>";
            roleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(mainDataGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(roleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.97849F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.51075F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.51075F));
            tableLayoutPanel1.Size = new Size(1229, 1020);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 540);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1217, 474);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableComboBox, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Margin = new Padding(6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 22.92994F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77.07006F));
            tableLayoutPanel3.Size = new Size(393, 462);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableComboBox
            // 
            tableComboBox.Dock = DockStyle.Fill;
            tableComboBox.FormattingEnabled = true;
            tableComboBox.Location = new Point(6, 6);
            tableComboBox.Margin = new Padding(6);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new Size(381, 40);
            tableComboBox.TabIndex = 0;
            tableComboBox.TextChanged += tableComboBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(6, 111);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(381, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия";
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(11, 201);
            deleteButton.Margin = new Padding(6);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(347, 53);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateButton.Enabled = false;
            updateButton.Location = new Point(11, 134);
            updateButton.Margin = new Padding(6);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(347, 53);
            updateButton.TabIndex = 1;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Location = new Point(11, 68);
            addButton.Margin = new Padding(6);
            addButton.Name = "addButton";
            addButton.Size = new Size(347, 53);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(edViewButton);
            groupBox2.Controls.Add(taskPartsButton);
            groupBox2.Controls.Add(reqByClButton);
            groupBox2.Controls.Add(reqGenButton);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(411, 6);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(393, 462);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Отчеты";
            // 
            // edViewButton
            // 
            edViewButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edViewButton.Location = new Point(0, 294);
            edViewButton.Margin = new Padding(6);
            edViewButton.Name = "edViewButton";
            edViewButton.Size = new Size(387, 92);
            edViewButton.TabIndex = 3;
            edViewButton.Text = "Выполненные/невыполненные заявки по дате";
            edViewButton.UseVisualStyleBackColor = true;
            edViewButton.Click += edViewButton_Click;
            // 
            // taskPartsButton
            // 
            taskPartsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskPartsButton.Location = new Point(0, 211);
            taskPartsButton.Margin = new Padding(6);
            taskPartsButton.Name = "taskPartsButton";
            taskPartsButton.Size = new Size(387, 70);
            taskPartsButton.TabIndex = 2;
            taskPartsButton.Text = "Задачи, требуются запчасти";
            taskPartsButton.UseVisualStyleBackColor = true;
            taskPartsButton.Click += taskPartsButton_Click;
            // 
            // reqByClButton
            // 
            reqByClButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reqByClButton.Location = new Point(0, 126);
            reqByClButton.Margin = new Padding(6);
            reqByClButton.Name = "reqByClButton";
            reqByClButton.Size = new Size(387, 73);
            reqByClButton.TabIndex = 1;
            reqByClButton.Text = "Заявки по клиентам";
            reqByClButton.UseVisualStyleBackColor = true;
            reqByClButton.Click += reqByClButton_Click;
            // 
            // reqGenButton
            // 
            reqGenButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reqGenButton.Location = new Point(0, 47);
            reqGenButton.Margin = new Padding(6);
            reqGenButton.Name = "reqGenButton";
            reqGenButton.Size = new Size(382, 66);
            reqGenButton.TabIndex = 0;
            reqGenButton.Text = "Форма заявки";
            reqGenButton.UseVisualStyleBackColor = true;
            reqGenButton.Click += reqGenButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(taskDatesButton);
            groupBox3.Controls.Add(reqTasksButton);
            groupBox3.Controls.Add(mergeButton);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(816, 6);
            groupBox3.Margin = new Padding(6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6);
            groupBox3.Size = new Size(395, 462);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Процедуры";
            // 
            // taskDatesButton
            // 
            taskDatesButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskDatesButton.Location = new Point(11, 222);
            taskDatesButton.Margin = new Padding(6);
            taskDatesButton.Name = "taskDatesButton";
            taskDatesButton.Size = new Size(375, 105);
            taskDatesButton.TabIndex = 2;
            taskDatesButton.Text = "Количество задач за период";
            taskDatesButton.UseVisualStyleBackColor = true;
            taskDatesButton.Click += taskDatesButton_Click;
            // 
            // reqTasksButton
            // 
            reqTasksButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reqTasksButton.Location = new Point(11, 126);
            reqTasksButton.Margin = new Padding(6);
            reqTasksButton.Name = "reqTasksButton";
            reqTasksButton.Size = new Size(373, 83);
            reqTasksButton.TabIndex = 1;
            reqTasksButton.Text = "Статус заказа";
            reqTasksButton.UseVisualStyleBackColor = true;
            reqTasksButton.Click += reqTasksButton_Click;
            // 
            // mergeButton
            // 
            mergeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mergeButton.Location = new Point(11, 47);
            mergeButton.Margin = new Padding(6);
            mergeButton.Name = "mergeButton";
            mergeButton.Size = new Size(377, 66);
            mergeButton.TabIndex = 0;
            mergeButton.Text = "Объединить заказы";
            mergeButton.UseVisualStyleBackColor = true;
            mergeButton.Click += mergeButton_Click;
            // 
            // InterfaceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 1020);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "InterfaceForm";
            Text = "Интерфейс";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)mainDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView mainDataGrid;
        private Label roleLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox tableComboBox;
        private GroupBox groupBox1;
        private Button deleteButton;
        private Button updateButton;
        private Button addButton;
        private GroupBox groupBox2;
        private Button reqGenButton;
        private Button reqByClButton;
        private Button taskPartsButton;
        private Button edViewButton;
        private GroupBox groupBox3;
        private Button mergeButton;
        private Button reqTasksButton;
        private Button taskDatesButton;
    }
}