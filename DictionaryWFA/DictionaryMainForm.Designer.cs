namespace DictionaryWFA
{
    partial class DictionaryMainForm
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
            this.AddLbl = new System.Windows.Forms.Label();
            this.RemoveLbl = new System.Windows.Forms.Label();
            this.KeyValuePairLbl = new System.Windows.Forms.Label();
            this.AddTxtBox = new System.Windows.Forms.TextBox();
            this.RemoveTxtBox = new System.Windows.Forms.TextBox();
            this.DisplayKvpLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddLbl
            // 
            this.AddLbl.AutoSize = true;
            this.AddLbl.Location = new System.Drawing.Point(9, 9);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(154, 13);
            this.AddLbl.TabIndex = 0;
            this.AddLbl.Text = "Добавить элемент по ключу:";
            // 
            // RemoveLbl
            // 
            this.RemoveLbl.AutoSize = true;
            this.RemoveLbl.Location = new System.Drawing.Point(9, 58);
            this.RemoveLbl.Name = "RemoveLbl";
            this.RemoveLbl.Size = new System.Drawing.Size(147, 13);
            this.RemoveLbl.TabIndex = 1;
            this.RemoveLbl.Text = "Удалить элемент по ключу:";
            // 
            // KeyValuePairLbl
            // 
            this.KeyValuePairLbl.AutoSize = true;
            this.KeyValuePairLbl.Location = new System.Drawing.Point(9, 91);
            this.KeyValuePairLbl.Name = "KeyValuePairLbl";
            this.KeyValuePairLbl.Size = new System.Drawing.Size(89, 13);
            this.KeyValuePairLbl.TabIndex = 2;
            this.KeyValuePairLbl.Text = "Ключ/Значение:";
            // 
            // AddTxtBox
            // 
            this.AddTxtBox.Location = new System.Drawing.Point(162, 6);
            this.AddTxtBox.Name = "AddTxtBox";
            this.AddTxtBox.Size = new System.Drawing.Size(178, 20);
            this.AddTxtBox.TabIndex = 4;
            // 
            // RemoveTxtBox
            // 
            this.RemoveTxtBox.Location = new System.Drawing.Point(162, 55);
            this.RemoveTxtBox.Name = "RemoveTxtBox";
            this.RemoveTxtBox.Size = new System.Drawing.Size(178, 20);
            this.RemoveTxtBox.TabIndex = 5;
            // 
            // DisplayKvpLbl
            // 
            this.DisplayKvpLbl.AutoSize = true;
            this.DisplayKvpLbl.Location = new System.Drawing.Point(121, 91);
            this.DisplayKvpLbl.Name = "DisplayKvpLbl";
            this.DisplayKvpLbl.Size = new System.Drawing.Size(0, 13);
            this.DisplayKvpLbl.TabIndex = 6;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(346, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(346, 53);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 8;
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(12, 107);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayBtn.TabIndex = 9;
            this.DisplayBtn.Text = "Печать";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // DictionaryMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 439);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DisplayKvpLbl);
            this.Controls.Add(this.RemoveTxtBox);
            this.Controls.Add(this.AddTxtBox);
            this.Controls.Add(this.KeyValuePairLbl);
            this.Controls.Add(this.RemoveLbl);
            this.Controls.Add(this.AddLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DictionaryMainForm";
            this.Text = "Dictionary Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddLbl;
        private System.Windows.Forms.Label RemoveLbl;
        private System.Windows.Forms.Label KeyValuePairLbl;
        private System.Windows.Forms.TextBox AddTxtBox;
        private System.Windows.Forms.TextBox RemoveTxtBox;
        private System.Windows.Forms.Label DisplayKvpLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button DisplayBtn;
    }
}

