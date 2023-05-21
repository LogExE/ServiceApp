namespace ServiceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enterButton = new Button();
            loginText = new TextBox();
            pwdText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // enterButton
            // 
            enterButton.Location = new Point(562, 263);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(150, 46);
            enterButton.TabIndex = 0;
            enterButton.Text = "Зайти";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // loginText
            // 
            loginText.Location = new Point(317, 160);
            loginText.Name = "loginText";
            loginText.Size = new Size(200, 39);
            loginText.TabIndex = 1;
            // 
            // pwdText
            // 
            pwdText.Location = new Point(317, 263);
            pwdText.Name = "pwdText";
            pwdText.Size = new Size(200, 39);
            pwdText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 162);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 263);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 59);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 5;
            label3.Text = "Учет заказов";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pwdText);
            Controls.Add(loginText);
            Controls.Add(enterButton);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterButton;
        private TextBox loginText;
        private TextBox pwdText;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}