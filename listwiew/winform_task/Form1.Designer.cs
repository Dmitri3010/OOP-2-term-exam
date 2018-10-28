namespace winform_task
{
    partial class Form1
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
            this.index_listView = new System.Windows.Forms.ListView();
            this.elements_listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.max_element_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.max_element = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // index_listView
            // 
            this.index_listView.Location = new System.Drawing.Point(12, 12);
            this.index_listView.Name = "index_listView";
            this.index_listView.Size = new System.Drawing.Size(58, 313);
            this.index_listView.TabIndex = 0;
            this.index_listView.UseCompatibleStateImageBehavior = false;
            // 
            // elements_listView
            // 
            this.elements_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elements_listView.Location = new System.Drawing.Point(76, 12);
            this.elements_listView.Name = "elements_listView";
            this.elements_listView.Size = new System.Drawing.Size(89, 313);
            this.elements_listView.TabIndex = 1;
            this.elements_listView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "index of element";
            // 
            // max_element_txb
            // 
            this.max_element_txb.Location = new System.Drawing.Point(261, 72);
            this.max_element_txb.Name = "max_element_txb";
            this.max_element_txb.ReadOnly = true;
            this.max_element_txb.Size = new System.Drawing.Size(100, 20);
            this.max_element_txb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "max element";
            // 
            // max_element
            // 
            this.max_element.Location = new System.Drawing.Point(261, 142);
            this.max_element.Name = "max_element";
            this.max_element.ReadOnly = true;
            this.max_element.Size = new System.Drawing.Size(100, 20);
            this.max_element.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "generate and find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.max_element);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.max_element_txb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elements_listView);
            this.Controls.Add(this.index_listView);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView index_listView;
        private System.Windows.Forms.ListView elements_listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox max_element_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox max_element;
        private System.Windows.Forms.Button button1;
    }
}

