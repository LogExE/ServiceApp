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
            ((System.ComponentModel.ISupportInitialize)mainDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainDataGrid
            // 
            mainDataGrid.AllowUserToAddRows = false;
            mainDataGrid.AllowUserToDeleteRows = false;
            mainDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataGrid.Location = new Point(10, 24);
            mainDataGrid.Margin = new Padding(10, 1, 10, 1);
            mainDataGrid.MultiSelect = false;
            mainDataGrid.Name = "mainDataGrid";
            mainDataGrid.ReadOnly = true;
            mainDataGrid.RowHeadersWidth = 82;
            mainDataGrid.RowTemplate.Height = 41;
            mainDataGrid.Size = new Size(642, 225);
            mainDataGrid.TabIndex = 1;
            mainDataGrid.RowHeaderMouseDoubleClick += mainDataGrid_RowHeaderMouseDoubleClick;
            mainDataGrid.RowStateChanged += mainDataGrid_RowStateChanged;
            // 
            // roleLabel
            // 
            roleLabel.Dock = DockStyle.Fill;
            roleLabel.Location = new Point(3, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(656, 23);
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.97849F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.51075F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.51075F));
            tableLayoutPanel1.Size = new Size(662, 478);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.25719F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.74281F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 253);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(656, 222);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableComboBox, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 22.92994F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77.07006F));
            tableLayoutPanel3.Size = new Size(179, 216);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableComboBox
            // 
            tableComboBox.Dock = DockStyle.Fill;
            tableComboBox.FormattingEnabled = true;
            tableComboBox.Location = new Point(3, 3);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new Size(173, 23);
            tableComboBox.TabIndex = 0;
            tableComboBox.SelectedIndexChanged += tableComboBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 161);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия";
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(6, 94);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(161, 25);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateButton.Enabled = false;
            updateButton.Location = new Point(6, 63);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(161, 25);
            updateButton.TabIndex = 1;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Location = new Point(6, 32);
            addButton.Name = "addButton";
            addButton.Size = new Size(161, 25);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // InterfaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 478);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "InterfaceForm";
            Text = "Интерфейс";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)mainDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
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
    }
}