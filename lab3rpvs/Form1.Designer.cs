
namespace lab3rpvs
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
            this.x = new System.Windows.Forms.TextBox();
            this.xk = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(142, 46);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 22);
            this.x.TabIndex = 0;
            this.x.Text = "0,1";
            this.x.TextChanged += new System.EventHandler(this.x_TextChanged);
            // 
            // xk
            // 
            this.xk.Location = new System.Drawing.Point(142, 91);
            this.xk.Name = "xk";
            this.xk.Size = new System.Drawing.Size(100, 22);
            this.xk.TabIndex = 1;
            this.xk.Text = "1";
            this.xk.TextChanged += new System.EventHandler(this.xk_TextChanged);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(558, 45);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 22);
            this.n.TabIndex = 2;
            this.n.Text = "16";
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(558, 94);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(100, 22);
            this.H.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "H:";
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(33, 181);
            this.ans.Multiline = true;
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(735, 208);
            this.ans.TabIndex = 8;
            this.ans.TextChanged += new System.EventHandler(this.ans_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.H);
            this.Controls.Add(this.n);
            this.Controls.Add(this.xk);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox xk;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Button button1;
    }
}

