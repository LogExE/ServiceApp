namespace ServiceApp
{
    partial class ClientDeviceForm
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
            this.clientText = new System.Windows.Forms.NumericUpDown();
            this.deviceText = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deviceText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.proceedButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stateText, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 50, 30, 30);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 250);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Устройство";
            // 
            // clientText
            // 
            this.clientText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientText.Location = new System.Drawing.Point(147, 53);
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
            this.clientText.Size = new System.Drawing.Size(158, 23);
            this.clientText.TabIndex = 16;
            this.clientText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deviceText
            // 
            this.deviceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceText.Location = new System.Drawing.Point(147, 95);
            this.deviceText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.deviceText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deviceText.Name = "deviceText";
            this.deviceText.Size = new System.Drawing.Size(158, 23);
            this.deviceText.TabIndex = 17;
            this.deviceText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(147, 179);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 18;
            this.proceedButton.Text = "Далее";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "Состояние";
            // 
            // stateText
            // 
            this.stateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateText.Location = new System.Drawing.Point(147, 137);
            this.stateText.Multiline = true;
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(158, 36);
            this.stateText.TabIndex = 20;
            // 
            // ClientDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientDeviceForm";
            this.Text = "ClientDeviceForm";
            this.Load += new System.EventHandler(this.ClientDeviceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private NumericUpDown clientText;
        private NumericUpDown deviceText;
        private Button proceedButton;
        private Label label3;
        private TextBox stateText;
    }
}