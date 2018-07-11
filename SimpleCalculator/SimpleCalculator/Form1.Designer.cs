namespace SimpleCalculator
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
            this.textBoxFirstIn = new System.Windows.Forms.TextBox();
            this.textBoxSecondIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstIn
            // 
            this.textBoxFirstIn.Location = new System.Drawing.Point(12, 12);
            this.textBoxFirstIn.Name = "textBoxFirstIn";
            this.textBoxFirstIn.Size = new System.Drawing.Size(146, 20);
            this.textBoxFirstIn.TabIndex = 0;
            // 
            // textBoxSecondIn
            // 
            this.textBoxSecondIn.Location = new System.Drawing.Point(12, 38);
            this.textBoxSecondIn.Name = "textBoxSecondIn";
            this.textBoxSecondIn.Size = new System.Drawing.Size(146, 20);
            this.textBoxSecondIn.TabIndex = 1;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(12, 64);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(146, 20);
            this.textBoxOut.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(12, 99);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 3;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(12, 128);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(12, 157);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(12, 186);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxSecondIn);
            this.Controls.Add(this.textBoxFirstIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstIn;
        private System.Windows.Forms.TextBox textBoxSecondIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
    }
}

