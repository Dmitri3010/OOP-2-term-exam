namespace Task3_2_6_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserDataGrid = new System.Windows.Forms.DataGridView();
            this.CountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(46, 8);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cost";
            // 
            // UserDataGrid
            // 
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid.Location = new System.Drawing.Point(15, 34);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.Size = new System.Drawing.Size(472, 150);
            this.UserDataGrid.TabIndex = 2;
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(152, 6);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 23);
            this.CountButton.TabIndex = 3;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 228);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.UserDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UserDataGrid;
        private System.Windows.Forms.Button CountButton;
    }
}

