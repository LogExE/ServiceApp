namespace ServiceApp
{
    partial class TaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kindText = new System.Windows.Forms.TextBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kindText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.proceedButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.priceText, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 100, 30, 70);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 372);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(33, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вид обслуживаемого устройства";
            // 
            // nameText
            // 
            this.nameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameText.Location = new System.Drawing.Point(210, 103);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(167, 23);
            this.nameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // kindText
            // 
            this.kindText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kindText.Location = new System.Drawing.Point(210, 153);
            this.kindText.Name = "kindText";
            this.kindText.Size = new System.Drawing.Size(167, 23);
            this.kindText.TabIndex = 8;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(210, 253);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 6;
            this.proceedButton.Text = "Далее";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(33, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена";
            // 
            // priceText
            // 
            this.priceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceText.Location = new System.Drawing.Point(210, 203);
            this.priceText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(167, 23);
            this.priceText.TabIndex = 11;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox nameText;
        private Label label2;
        private Button proceedButton;
        private TextBox kindText;
        private Label label3;
        private NumericUpDown priceText;
    }
}