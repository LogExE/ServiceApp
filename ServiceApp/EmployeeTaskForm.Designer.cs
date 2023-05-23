namespace ServiceApp
{
    partial class EmployeeTaskForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empText = new System.Windows.Forms.NumericUpDown();
            this.taskText = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.empText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.proceedButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 50, 30, 30);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33443F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 301);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 73);
            this.label2.TabIndex = 4;
            this.label2.Text = "Работник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 73);
            this.label1.TabIndex = 10;
            this.label1.Text = "Вид обслуживания";
            // 
            // empText
            // 
            this.empText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empText.Location = new System.Drawing.Point(225, 53);
            this.empText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.empText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empText.Name = "empText";
            this.empText.Size = new System.Drawing.Size(158, 23);
            this.empText.TabIndex = 16;
            this.empText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // taskText
            // 
            this.taskText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskText.Location = new System.Drawing.Point(225, 126);
            this.taskText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.taskText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.taskText.Name = "taskText";
            this.taskText.Size = new System.Drawing.Size(158, 23);
            this.taskText.TabIndex = 17;
            this.taskText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(225, 199);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 18;
            this.proceedButton.Text = "Далее";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // EmployeeTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeTaskForm";
            this.Text = "EmployeeTaskForm";
            this.Load += new System.EventHandler(this.EmployeeTaskForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private NumericUpDown empText;
        private NumericUpDown taskText;
        private Button proceedButton;
    }
}