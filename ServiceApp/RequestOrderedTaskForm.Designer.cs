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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            reqText = new NumericUpDown();
            otaskText = new NumericUpDown();
            proceedButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reqText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otaskText).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(reqText, 1, 0);
            tableLayoutPanel1.Controls.Add(otaskText, 1, 1);
            tableLayoutPanel1.Controls.Add(proceedButton, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 50, 30, 30);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33443F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33445F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(381, 307);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(33, 50);
            label2.Name = "label2";
            label2.Size = new Size(151, 75);
            label2.TabIndex = 4;
            label2.Text = "Заказ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(33, 125);
            label1.Name = "label1";
            label1.Size = new Size(151, 75);
            label1.TabIndex = 10;
            label1.Text = "Задача";
            // 
            // reqText
            // 
            reqText.Dock = DockStyle.Fill;
            reqText.Location = new Point(190, 53);
            reqText.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            reqText.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            reqText.Name = "reqText";
            reqText.Size = new Size(158, 23);
            reqText.TabIndex = 16;
            reqText.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // otaskText
            // 
            otaskText.Dock = DockStyle.Fill;
            otaskText.Location = new Point(190, 128);
            otaskText.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            otaskText.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            otaskText.Name = "otaskText";
            otaskText.Size = new Size(158, 23);
            otaskText.TabIndex = 17;
            otaskText.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(190, 203);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(75, 23);
            proceedButton.TabIndex = 18;
            proceedButton.Text = "Далее";
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // RequestOrderedTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 307);
            Controls.Add(tableLayoutPanel1);
            Name = "RequestOrderedTaskForm";
            Text = "RequestOrderedTaskForm";
            Load += RequestOrderedTaskForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reqText).EndInit();
            ((System.ComponentModel.ISupportInitialize)otaskText).EndInit();
            ResumeLayout(false);
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