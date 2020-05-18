namespace PP_Z8_WinForms_
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
            this.Zadanie = new System.Windows.Forms.GroupBox();
            this.str = new System.Windows.Forms.Label();
            this.enter_str = new System.Windows.Forms.RichTextBox();
            this.max = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.out_max = new System.Windows.Forms.Label();
            this.Zadanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie
            // 
            this.Zadanie.Controls.Add(this.out_max);
            this.Zadanie.Controls.Add(this.Result);
            this.Zadanie.Controls.Add(this.max);
            this.Zadanie.Controls.Add(this.enter_str);
            this.Zadanie.Controls.Add(this.str);
            this.Zadanie.Location = new System.Drawing.Point(12, 4);
            this.Zadanie.Name = "Zadanie";
            this.Zadanie.Size = new System.Drawing.Size(365, 210);
            this.Zadanie.TabIndex = 0;
            this.Zadanie.TabStop = false;
            this.Zadanie.Text = "Задание";
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.Location = new System.Drawing.Point(6, 29);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(119, 17);
            this.str.TabIndex = 0;
            this.str.Text = "Введите строку: ";
            // 
            // enter_str
            // 
            this.enter_str.Location = new System.Drawing.Point(9, 49);
            this.enter_str.Name = "enter_str";
            this.enter_str.Size = new System.Drawing.Size(350, 43);
            this.enter_str.TabIndex = 1;
            this.enter_str.Text = "";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(6, 104);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(322, 17);
            this.max.TabIndex = 2;
            this.max.Text = "Max число, которое встречается в сообщении: ";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(100, 145);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(160, 49);
            this.Result.TabIndex = 3;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click_1);
            // 
            // out_max
            // 
            this.out_max.AutoSize = true;
            this.out_max.Location = new System.Drawing.Point(334, 104);
            this.out_max.Name = "out_max";
            this.out_max.Size = new System.Drawing.Size(0, 17);
            this.out_max.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 226);
            this.Controls.Add(this.Zadanie);
            this.Name = "Form1";
            this.Text = "Практика 8";
            this.Zadanie.ResumeLayout(false);
            this.Zadanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie;
        private System.Windows.Forms.Label out_max;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.RichTextBox enter_str;
        private System.Windows.Forms.Label str;
    }
}

