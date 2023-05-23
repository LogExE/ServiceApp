namespace ServiceApp
{
    partial class OrderedTaskForm
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
            this.priceText = new System.Windows.Forms.NumericUpDown();
            this.clientText = new System.Windows.Forms.NumericUpDown();
            this.taskText = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskText)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.priceText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.clientText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.proceedButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 100, 30, 70);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 354);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(33, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Устройство клиента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Вид обслуживания";
            // 
            // priceText
            // 
            this.priceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceText.Location = new System.Drawing.Point(238, 195);
            this.priceText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(203, 23);
            this.priceText.TabIndex = 13;
            // 
            // clientText
            // 
            this.clientText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientText.Location = new System.Drawing.Point(238, 103);
            this.clientText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.clientText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clientText.Name = "clientText";
            this.clientText.Size = new System.Drawing.Size(203, 23);
            this.clientText.TabIndex = 16;
            this.clientText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // taskText
            // 
            this.taskText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskText.Location = new System.Drawing.Point(238, 149);
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
            this.taskText.Size = new System.Drawing.Size(203, 23);
            this.taskText.TabIndex = 17;
            this.taskText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(238, 241);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 18;
            this.proceedButton.Text = "Далее";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // OrderedTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderedTaskForm";
            this.Text = "OrderedTaskForm";
            this.Load += new System.EventHandler(this.OrderedTaskForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private NumericUpDown clientText;
        private Label label4;
        private NumericUpDown priceText;
        private NumericUpDown taskText;
        private Button proceedButton;
    }
}