namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(125, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "+/-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(69, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Location = new System.Drawing.Point(12, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "С";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Location = new System.Drawing.Point(181, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MistyRose;
            this.button8.Location = new System.Drawing.Point(181, 85);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 34);
            this.button8.TabIndex = 8;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.MistyRose;
            this.button12.Location = new System.Drawing.Point(181, 115);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(59, 34);
            this.button12.TabIndex = 12;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.MistyRose;
            this.button16.Location = new System.Drawing.Point(181, 145);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(59, 34);
            this.button16.TabIndex = 16;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.MistyRose;
            this.button19.Location = new System.Drawing.Point(125, 176);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(115, 34);
            this.button19.TabIndex = 19;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "        ";
            
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(243, 55);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(46, 69);
            this.button20.TabIndex = 21;
            this.button20.Text = "log";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click_1);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(243, 130);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(46, 80);
            this.button21.TabIndex = 22;
            this.button21.Text = "tan";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click_1);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(69, 176);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(59, 34);
            this.button18.TabIndex = 18;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(69, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(69, 115);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 34);
            this.button10.TabIndex = 10;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 115);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 34);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(13, 145);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 34);
            this.button13.TabIndex = 13;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(13, 176);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(59, 34);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(69, 145);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(59, 34);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(125, 145);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 34);
            this.button15.TabIndex = 15;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(125, 115);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 34);
            this.button11.TabIndex = 11;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(125, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 34);
            this.button7.TabIndex = 7;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(330, 223);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
    }
}

