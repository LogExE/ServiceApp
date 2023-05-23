namespace ServiceApp
{
    partial class RequestOrderedTaskForm
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
            this.reqText = new System.Windows.Forms.NumericUpDown();
            this.otaskText = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otaskText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reqText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.otaskText, 1, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 307);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 75);
            this.label2.TabIndex = 4;
            this.label2.Text = "Заказ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 75);
            this.label1.TabIndex = 10;
            this.label1.Text = "Задача";
            // 
            // reqText
            // 
            this.reqText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reqText.Location = new System.Drawing.Point(190, 53);
            this.reqText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.reqText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reqText.Name = "reqText";
            this.reqText.Size = new System.Drawing.Size(158, 23);
            this.reqText.TabIndex = 16;
            this.reqText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // otaskText
            // 
            this.otaskText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otaskText.Location = new System.Drawing.Point(190, 128);
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
            this.otaskText.Size = new System.Drawing.Size(158, 23);
            this.otaskText.TabIndex = 17;
            this.otaskText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(190, 203);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 18;
            this.proceedButton.Text = "Далее";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // RequestOrderedTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RequestOrderedTaskForm";
            this.Text = "RequestOrderedTaskForm";
            this.Load += new System.EventHandler(this.RequestOrderedTaskForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otaskText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private NumericUpDown reqText;
        private NumericUpDown otaskText;
        private Button proceedButton;
    }
}