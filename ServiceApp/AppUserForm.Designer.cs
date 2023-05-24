namespace ServiceApp
{
    partial class AppUserForm
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
            pwdText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginText = new TextBox();
            proceedButton = new Button();
            admCheck = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            tableLayoutPanel1.Controls.Add(pwdText, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(loginText, 1, 0);
            tableLayoutPanel1.Controls.Add(proceedButton, 1, 3);
            tableLayoutPanel1.Controls.Add(admCheck, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 50, 30, 30);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.99896F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.99813F));
            tableLayoutPanel1.Size = new Size(369, 333);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // pwdText
            // 
            pwdText.Dock = DockStyle.Fill;
            pwdText.Location = new Point(178, 116);
            pwdText.Name = "pwdText";
            pwdText.Size = new Size(158, 23);
            pwdText.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(33, 50);
            label1.Name = "label1";
            label1.Size = new Size(139, 63);
            label1.TabIndex = 19;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(33, 113);
            label2.Name = "label2";
            label2.Size = new Size(139, 63);
            label2.TabIndex = 20;
            label2.Text = "Пароль";
            // 
            // loginText
            // 
            loginText.Dock = DockStyle.Fill;
            loginText.Location = new Point(178, 53);
            loginText.Name = "loginText";
            loginText.Size = new Size(158, 23);
            loginText.TabIndex = 21;
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(178, 242);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(75, 23);
            proceedButton.TabIndex = 18;
            proceedButton.Text = "Далее";
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // admCheck
            // 
            admCheck.AutoSize = true;
            admCheck.Location = new Point(178, 179);
            admCheck.Name = "admCheck";
            admCheck.Size = new Size(118, 19);
            admCheck.TabIndex = 24;
            admCheck.Text = "Администратор?";
            admCheck.UseVisualStyleBackColor = true;
            // 
            // AppUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 333);
            Controls.Add(tableLayoutPanel1);
            Name = "AppUserForm";
            Text = "AppUserForm";
            Load += AppUserForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button proceedButton;
        private TextBox pwdText;
        private Label label1;
        private Label label2;
        private TextBox loginText;
        private CheckBox admCheck;
    }
}