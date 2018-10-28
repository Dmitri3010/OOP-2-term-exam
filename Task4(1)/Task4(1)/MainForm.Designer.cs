namespace Task4_1_
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
            this.ConnectServerFirstButton = new System.Windows.Forms.Button();
            this.ConnectServerSecondButton = new System.Windows.Forms.Button();
            this.IPRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ConnectServerFirstButton
            // 
            this.ConnectServerFirstButton.Location = new System.Drawing.Point(12, 158);
            this.ConnectServerFirstButton.Name = "ConnectServerFirstButton";
            this.ConnectServerFirstButton.Size = new System.Drawing.Size(118, 23);
            this.ConnectServerFirstButton.TabIndex = 0;
            this.ConnectServerFirstButton.Text = "Connect Server 1";
            this.ConnectServerFirstButton.UseVisualStyleBackColor = true;
            this.ConnectServerFirstButton.Click += new System.EventHandler(this.ConnectServerFirstButton_Click);
            // 
            // ConnectServerSecondButton
            // 
            this.ConnectServerSecondButton.Location = new System.Drawing.Point(136, 158);
            this.ConnectServerSecondButton.Name = "ConnectServerSecondButton";
            this.ConnectServerSecondButton.Size = new System.Drawing.Size(118, 23);
            this.ConnectServerSecondButton.TabIndex = 1;
            this.ConnectServerSecondButton.Text = "Connect Server 2";
            this.ConnectServerSecondButton.UseVisualStyleBackColor = true;
            this.ConnectServerSecondButton.Click += new System.EventHandler(this.ConnectServerSecondButton_Click);
            // 
            // IPRichTextBox
            // 
            this.IPRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.IPRichTextBox.Name = "IPRichTextBox";
            this.IPRichTextBox.Size = new System.Drawing.Size(242, 140);
            this.IPRichTextBox.TabIndex = 2;
            this.IPRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 192);
            this.Controls.Add(this.IPRichTextBox);
            this.Controls.Add(this.ConnectServerSecondButton);
            this.Controls.Add(this.ConnectServerFirstButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectServerFirstButton;
        private System.Windows.Forms.Button ConnectServerSecondButton;
        private System.Windows.Forms.RichTextBox IPRichTextBox;
    }
}

