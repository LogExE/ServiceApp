namespace ServiceApp
{
    partial class RequestForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            proceedButton = new Button();
            label1 = new Label();
            priceText = new NumericUpDown();
            clientText = new NumericUpDown();
            applyPicker = new DateTimePicker();
            groupBox1 = new GroupBox();
            checkEst = new CheckBox();
            estFinPicker = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientText).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(proceedButton, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(priceText, 1, 3);
            tableLayoutPanel1.Controls.Add(clientText, 1, 0);
            tableLayoutPanel1.Controls.Add(applyPicker, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 100, 30, 70);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.00049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0005F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0005F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9985F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(489, 427);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(33, 253);
            label4.Name = "label4";
            label4.Size = new Size(214, 51);
            label4.TabIndex = 12;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(33, 202);
            label3.Name = "label3";
            label3.Size = new Size(214, 51);
            label3.TabIndex = 11;
            label3.Text = "Примерная дата завершения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(33, 100);
            label2.Name = "label2";
            label2.Size = new Size(214, 51);
            label2.TabIndex = 4;
            label2.Text = "Клиент";
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(253, 307);
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
            label1.Location = new Point(33, 151);
            label1.Name = "label1";
            label1.Size = new Size(214, 51);
            label1.TabIndex = 10;
            label1.Text = "Дата приема";
            // 
            // priceText
            // 
            priceText.Dock = DockStyle.Fill;
            priceText.Location = new Point(253, 256);
            priceText.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            priceText.Name = "priceText";
            priceText.Size = new Size(203, 23);
            priceText.TabIndex = 13;
            // 
            // clientText
            // 
            clientText.Dock = DockStyle.Fill;
            clientText.Location = new Point(253, 103);
            clientText.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            clientText.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            clientText.Name = "clientText";
            clientText.Size = new Size(203, 23);
            clientText.TabIndex = 16;
            clientText.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // applyPicker
            // 
            applyPicker.CustomFormat = "";
            applyPicker.Format = DateTimePickerFormat.Short;
            applyPicker.Location = new Point(253, 154);
            applyPicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            applyPicker.Name = "applyPicker";
            applyPicker.Size = new Size(200, 23);
            applyPicker.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkEst);
            groupBox1.Controls.Add(estFinPicker);
            groupBox1.Location = new Point(253, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 45);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // checkEst
            // 
            checkEst.AutoSize = true;
            checkEst.Location = new Point(149, 4);
            checkEst.Name = "checkEst";
            checkEst.Size = new Size(54, 19);
            checkEst.TabIndex = 0;
            checkEst.Text = "Есть?";
            checkEst.UseVisualStyleBackColor = true;
            checkEst.CheckedChanged += checkEst_CheckedChanged;
            // 
            // estFinPicker
            // 
            estFinPicker.CustomFormat = "";
            estFinPicker.Enabled = false;
            estFinPicker.Format = DateTimePickerFormat.Short;
            estFinPicker.Location = new Point(0, 0);
            estFinPicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            estFinPicker.Name = "estFinPicker";
            estFinPicker.Size = new Size(143, 23);
            estFinPicker.TabIndex = 15;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 427);
            Controls.Add(tableLayoutPanel1);
            Name = "RequestForm";
            Text = "RequestForm";
            Load += RequestForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceText).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientText).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button proceedButton;
        private Label label1;
        private NumericUpDown priceText;
        private DateTimePicker estFinPicker;
        private NumericUpDown clientText;
        private DateTimePicker applyPicker;
        private GroupBox groupBox1;
        private CheckBox checkEst;
    }
}