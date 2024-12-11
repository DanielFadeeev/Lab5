namespace Lab5
{
    partial class Lab5
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
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.BackColor = System.Drawing.Color.White;
            this.txtX1.ForeColor = System.Drawing.Color.Black;
            this.txtX1.Location = new System.Drawing.Point(122, 90);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(127, 22);
            this.txtX1.TabIndex = 0;
            // 
            // txtX2
            // 
            this.txtX2.BackColor = System.Drawing.Color.White;
            this.txtX2.ForeColor = System.Drawing.Color.Black;
            this.txtX2.Location = new System.Drawing.Point(122, 187);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(127, 22);
            this.txtX2.TabIndex = 1;
            // 
            // txtY1
            // 
            this.txtY1.BackColor = System.Drawing.Color.White;
            this.txtY1.ForeColor = System.Drawing.Color.Black;
            this.txtY1.Location = new System.Drawing.Point(378, 90);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(127, 22);
            this.txtY1.TabIndex = 2;
            // 
            // txtY2
            // 
            this.txtY2.BackColor = System.Drawing.Color.White;
            this.txtY2.ForeColor = System.Drawing.Color.Black;
            this.txtY2.Location = new System.Drawing.Point(378, 187);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(127, 22);
            this.txtY2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "x range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(334, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "y range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "from:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(334, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "to:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(334, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Result:";
            // 
            // lstResult
            // 
            this.lstResult.BackColor = System.Drawing.Color.White;
            this.lstResult.ForeColor = System.Drawing.Color.Black;
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(399, 249);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(134, 148);
            this.lstResult.TabIndex = 11;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(190, 360);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(139, 37);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Вычислить z(x,y)";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Lab5";
            this.Text = "цикл for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnCalc;
    }
}

