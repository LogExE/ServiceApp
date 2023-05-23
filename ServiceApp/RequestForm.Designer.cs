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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.NumericUpDown();
            this.clientText = new System.Windows.Forms.NumericUpDown();
            this.applyPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEst = new System.Windows.Forms.CheckBox();
            this.estFinPicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientText)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.proceedButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.clientText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.applyPicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 100, 30, 70);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 427);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(33, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 51);
            this.label4.TabIndex = 12;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "Примерная дата завершения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Клиент";
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(253, 307);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 6;
            this.proceedButton.Text = "Далее";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата приема";
            // 
            // priceText
            // 
            this.priceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceText.Location = new System.Drawing.Point(253, 256);
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
            this.clientText.Location = new System.Drawing.Point(253, 103);
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
            // applyPicker
            // 
            this.applyPicker.CustomFormat = "";
            this.applyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.applyPicker.Location = new System.Drawing.Point(253, 154);
            this.applyPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.applyPicker.Name = "applyPicker";
            this.applyPicker.Size = new System.Drawing.Size(200, 23);
            this.applyPicker.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEst);
            this.groupBox1.Controls.Add(this.estFinPicker);
            this.groupBox1.Location = new System.Drawing.Point(253, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkEst
            // 
            this.checkEst.AutoSize = true;
            this.checkEst.Location = new System.Drawing.Point(149, 4);
            this.checkEst.Name = "checkEst";
            this.checkEst.Size = new System.Drawing.Size(54, 19);
            this.checkEst.TabIndex = 0;
            this.checkEst.Text = "Есть?";
            this.checkEst.UseVisualStyleBackColor = true;
            this.checkEst.CheckedChanged += new System.EventHandler(this.checkEst_CheckedChanged);
            // 
            // estFinPicker
            // 
            this.estFinPicker.CustomFormat = "";
            this.estFinPicker.Enabled = false;
            this.estFinPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.estFinPicker.Location = new System.Drawing.Point(0, 0);
            this.estFinPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.estFinPicker.Name = "estFinPicker";
            this.estFinPicker.Size = new System.Drawing.Size(143, 23);
            this.estFinPicker.TabIndex = 15;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientText)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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