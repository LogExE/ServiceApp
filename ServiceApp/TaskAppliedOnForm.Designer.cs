namespace ServiceApp
{
    partial class TaskAppliedOnForm
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
            label3 = new Label();
            proceedButton = new Button();
            label1 = new Label();
            startPick = new DateTimePicker();
            endPick = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(proceedButton, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(startPick, 1, 0);
            tableLayoutPanel1.Controls.Add(endPick, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 50, 30, 50);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33278F));
            tableLayoutPanel1.Size = new Size(367, 325);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(92, 75);
            label3.TabIndex = 11;
            label3.Text = "До";
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(131, 203);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(75, 23);
            proceedButton.TabIndex = 6;
            proceedButton.Text = "Далее";
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(33, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 75);
            label1.TabIndex = 10;
            label1.Text = "От";
            // 
            // startPick
            // 
            startPick.CustomFormat = "";
            startPick.Format = DateTimePickerFormat.Short;
            startPick.Location = new Point(131, 53);
            startPick.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            startPick.Name = "startPick";
            startPick.Size = new Size(200, 23);
            startPick.TabIndex = 14;
            // 
            // endPick
            // 
            endPick.CustomFormat = "";
            endPick.Format = DateTimePickerFormat.Short;
            endPick.Location = new Point(131, 128);
            endPick.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            endPick.Name = "endPick";
            endPick.Size = new Size(200, 23);
            endPick.TabIndex = 15;
            // 
            // TaskAppliedOnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 325);
            Controls.Add(tableLayoutPanel1);
            Name = "TaskAppliedOnForm";
            Text = "TaskAppliedOnForm";
            Load += TaskAppliedOnForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Button proceedButton;
        private Label label1;
        private DateTimePicker startPick;
        private DateTimePicker endPick;
    }
}