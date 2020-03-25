namespace Task_001
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
            this.SumButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.DiriveButton = new System.Windows.Forms.Button();
            this.FirstNumText = new System.Windows.Forms.TextBox();
            this.SecondNumText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(48, 68);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(49, 41);
            this.SumButton.TabIndex = 0;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButtonClick);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(48, 115);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(49, 41);
            this.MultiplyButton.TabIndex = 1;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButtonClick);
            // 
            // SubButton
            // 
            this.SubButton.Location = new System.Drawing.Point(103, 68);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(49, 41);
            this.SubButton.TabIndex = 2;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButtonClick);
            // 
            // DiriveButton
            // 
            this.DiriveButton.Location = new System.Drawing.Point(103, 115);
            this.DiriveButton.Name = "DiriveButton";
            this.DiriveButton.Size = new System.Drawing.Size(49, 41);
            this.DiriveButton.TabIndex = 3;
            this.DiriveButton.Text = "/";
            this.DiriveButton.UseVisualStyleBackColor = true;
            this.DiriveButton.Click += new System.EventHandler(this.DiriveButtonClick);
            // 
            // FirstNumText
            // 
            this.FirstNumText.Location = new System.Drawing.Point(182, 68);
            this.FirstNumText.Name = "FirstNumText";
            this.FirstNumText.Size = new System.Drawing.Size(100, 20);
            this.FirstNumText.TabIndex = 4;
            // 
            // SecondNumText
            // 
            this.SecondNumText.Location = new System.Drawing.Point(182, 94);
            this.SecondNumText.Name = "SecondNumText";
            this.SecondNumText.Size = new System.Drawing.Size(100, 20);
            this.SecondNumText.TabIndex = 5;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(182, 136);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(100, 20);
            this.ResultText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 194);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.SecondNumText);
            this.Controls.Add(this.FirstNumText);
            this.Controls.Add(this.DiriveButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SumButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button DiriveButton;
        private System.Windows.Forms.TextBox FirstNumText;
        private System.Windows.Forms.TextBox SecondNumText;
        private System.Windows.Forms.TextBox ResultText;
    }
}

