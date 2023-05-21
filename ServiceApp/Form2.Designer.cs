namespace ServiceApp
{
    partial class Form2
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
            mainDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)mainDataGrid).BeginInit();
            SuspendLayout();
            // 
            // mainDataGrid
            // 
            mainDataGrid.AllowUserToAddRows = false;
            mainDataGrid.AllowUserToDeleteRows = false;
            mainDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataGrid.Location = new Point(12, 23);
            mainDataGrid.Name = "mainDataGrid";
            mainDataGrid.ReadOnly = true;
            mainDataGrid.RowHeadersWidth = 82;
            mainDataGrid.RowTemplate.Height = 41;
            mainDataGrid.Size = new Size(1213, 439);
            mainDataGrid.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 804);
            Controls.Add(mainDataGrid);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)mainDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView mainDataGrid;
    }
}