namespace WinFormsApp_01_Calculator
    {
    partial class Form1
        {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            BTNDivide = new Button();
            BTNMultiply = new Button();
            BTNsubtract = new Button();
            BTNplus = new Button();
            btnEqaual = new Button();
            BTNClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 27);
            label1.TabIndex = 0;
            label1.Text = "Result:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 6);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 34);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(110, 37);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button10_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Location = new Point(128, 97);
            button2.Name = "button2";
            button2.Size = new Size(110, 37);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button10_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.Location = new Point(244, 97);
            button3.Name = "button3";
            button3.Size = new Size(110, 37);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button10_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.Location = new Point(12, 140);
            button4.Name = "button4";
            button4.Size = new Size(110, 37);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button10_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 224, 192);
            button5.Location = new Point(128, 140);
            button5.Name = "button5";
            button5.Size = new Size(110, 37);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button10_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 224, 192);
            button6.Location = new Point(244, 140);
            button6.Name = "button6";
            button6.Size = new Size(110, 37);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button10_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 224, 192);
            button7.Location = new Point(12, 183);
            button7.Name = "button7";
            button7.Size = new Size(110, 37);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button10_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 224, 192);
            button8.Location = new Point(128, 183);
            button8.Name = "button8";
            button8.Size = new Size(110, 37);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 224, 192);
            button9.Location = new Point(244, 183);
            button9.Name = "button9";
            button9.Size = new Size(110, 37);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button10_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(255, 224, 192);
            button0.Location = new Point(12, 226);
            button0.Name = "button0";
            button0.Size = new Size(110, 37);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button10_Click;
            // 
            // BTNDivide
            // 
            BTNDivide.BackColor = Color.FromArgb(255, 224, 192);
            BTNDivide.Location = new Point(360, 97);
            BTNDivide.Name = "BTNDivide";
            BTNDivide.Size = new Size(110, 37);
            BTNDivide.TabIndex = 12;
            BTNDivide.Text = "/";
            BTNDivide.UseVisualStyleBackColor = false;
            BTNDivide.Click += BTNDivide_Click;
            // 
            // BTNMultiply
            // 
            BTNMultiply.BackColor = Color.FromArgb(255, 224, 192);
            BTNMultiply.Location = new Point(360, 140);
            BTNMultiply.Name = "BTNMultiply";
            BTNMultiply.Size = new Size(110, 37);
            BTNMultiply.TabIndex = 13;
            BTNMultiply.Text = "X";
            BTNMultiply.UseVisualStyleBackColor = false;
            BTNMultiply.Click += BTNMultiply_Click;
            // 
            // BTNsubtract
            // 
            BTNsubtract.BackColor = Color.FromArgb(255, 224, 192);
            BTNsubtract.Location = new Point(360, 183);
            BTNsubtract.Name = "BTNsubtract";
            BTNsubtract.Size = new Size(110, 37);
            BTNsubtract.TabIndex = 14;
            BTNsubtract.Text = "-";
            BTNsubtract.UseVisualStyleBackColor = false;
            BTNsubtract.Click += BTNsubtract_Click;
            // 
            // BTNplus
            // 
            BTNplus.BackColor = Color.FromArgb(255, 224, 192);
            BTNplus.Location = new Point(360, 226);
            BTNplus.Name = "BTNplus";
            BTNplus.Size = new Size(110, 37);
            BTNplus.TabIndex = 15;
            BTNplus.Text = "+";
            BTNplus.UseVisualStyleBackColor = false;
            BTNplus.Click += BTNplus_Click;
            // 
            // btnEqaual
            // 
            btnEqaual.BackColor = Color.FromArgb(255, 224, 192);
            btnEqaual.Location = new Point(128, 226);
            btnEqaual.Name = "btnEqaual";
            btnEqaual.Size = new Size(226, 37);
            btnEqaual.TabIndex = 16;
            btnEqaual.Text = "=";
            btnEqaual.UseVisualStyleBackColor = false;
            btnEqaual.Click += btnEEqaual_Click;
            // 
            // BTNClear
            // 
            BTNClear.BackColor = Color.FromArgb(192, 255, 192);
            BTNClear.Location = new Point(128, 48);
            BTNClear.Name = "BTNClear";
            BTNClear.Size = new Size(185, 43);
            BTNClear.TabIndex = 17;
            BTNClear.Text = "Clear";
            BTNClear.UseVisualStyleBackColor = false;
            BTNClear.Click += BTNClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(477, 274);
            Controls.Add(BTNClear);
            Controls.Add(btnEqaual);
            Controls.Add(BTNplus);
            Controls.Add(BTNsubtract);
            Controls.Add(BTNMultiply);
            Controls.Add(BTNDivide);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator | IPBSES";
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button BTNDivide;
        private Button BTNMultiply;
        private Button BTNsubtract;
        private Button BTNplus;
        private Button btnEqaual;
        private Button BTNClear;
        }
    }