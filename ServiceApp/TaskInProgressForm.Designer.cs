namespace ServiceApp
{
    partial class TaskInProgressForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otaskText = new System.Windows.Forms.NumericUpDown();
            this.employeeText = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otaskText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.otaskText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.employeeText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.proceedButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.startDatePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.statusText, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 50, 30, 30);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.85542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 433);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(33, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата начала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 71);
            this.label2.TabIndex = 4;
            this.label2.Text = "Задача";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 71);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сотрудник";
            // 
            // otaskText
            // 
            this.otaskText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otaskText.Location = new System.Drawing.Point(226, 53);
            this.otaskText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.otaskText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.otaskText.Name = "otaskText";
            this.otaskText.Size = new System.Drawing.Size(203, 23);
            this.otaskText.TabIndex = 16;
            this.otaskText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // employeeText
            // 
            this.employeeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeText.Location = new System.Drawing.Point(226, 124);
            this.employeeText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.employeeText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.employeeText.Name = "employeeText";
            this.employeeText.Size = new System.Drawing.Size(203, 23);
            this.employeeText.TabIndex = 17;
            this.employeeText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(226, 337);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 18;
            this.proceedButton.Text = "Далее";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(226, 195);
            this.startDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 23);
            this.startDatePicker.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(33, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 111);
            this.label3.TabIndex = 20;
            this.label3.Text = "Статус";
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(226, 226);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(203, 105);
            this.statusText.TabIndex = 21;
            // 
            // TaskInProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TaskInProgressForm";
            this.Text = "TaskInProgressForm";
            this.Load += new System.EventHandler(this.TaskInProgressForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otaskText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private NumericUpDown otaskText;
        private NumericUpDown employeeText;
        private Button proceedButton;
        private DateTimePicker startDatePicker;
        private Label label3;
        private TextBox statusText;
    }
}