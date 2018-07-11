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
            this.max = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
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
            // max
            // 
            this.max.Location = new System.Drawing.Point(12, 215);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 7;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(93, 99);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 8;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.Single_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(93, 128);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 9;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.Single_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(93, 157);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 10;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.Single_Click);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(93, 186);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 11;
            this.root.Text = "Sqrt";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.Single_Click);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(93, 215);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 12;
            this.arcsin.Text = "Arcsin";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.Single_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.root);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.max);
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
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button arcsin;
    }
}

