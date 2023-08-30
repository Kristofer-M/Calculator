namespace Calculator
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
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            number6 = new Button();
            number5 = new Button();
            number4 = new Button();
            number3 = new Button();
            number2 = new Button();
            number1 = new Button();
            button0 = new Button();
            tbInput = new TextBox();
            buttonMult = new Button();
            buttonSub = new Button();
            buttonAdd = new Button();
            buttonEquals = new Button();
            SuspendLayout();
            // 
            // number7
            // 
            number7.Location = new Point(60, 214);
            number7.Name = "number7";
            number7.Size = new Size(52, 45);
            number7.TabIndex = 0;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = true;
            number7.Click += number7_Click;
            // 
            // number8
            // 
            number8.Location = new Point(118, 214);
            number8.Name = "number8";
            number8.Size = new Size(52, 45);
            number8.TabIndex = 1;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = true;
            number8.Click += number8_Click;
            // 
            // number9
            // 
            number9.Location = new Point(176, 214);
            number9.Name = "number9";
            number9.Size = new Size(52, 45);
            number9.TabIndex = 2;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = true;
            number9.Click += number9_Click;
            // 
            // number6
            // 
            number6.Location = new Point(176, 265);
            number6.Name = "number6";
            number6.Size = new Size(52, 45);
            number6.TabIndex = 5;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = true;
            number6.Click += number6_Click;
            // 
            // number5
            // 
            number5.Location = new Point(118, 265);
            number5.Name = "number5";
            number5.Size = new Size(52, 45);
            number5.TabIndex = 4;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = true;
            number5.Click += number5_Click;
            // 
            // number4
            // 
            number4.Location = new Point(60, 265);
            number4.Name = "number4";
            number4.Size = new Size(52, 45);
            number4.TabIndex = 3;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = true;
            number4.Click += number4_Click;
            // 
            // number3
            // 
            number3.Location = new Point(176, 316);
            number3.Name = "number3";
            number3.Size = new Size(52, 45);
            number3.TabIndex = 8;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = true;
            number3.Click += number3_Click;
            // 
            // number2
            // 
            number2.Location = new Point(118, 316);
            number2.Name = "number2";
            number2.Size = new Size(52, 45);
            number2.TabIndex = 7;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = true;
            number2.Click += number2_Click;
            // 
            // number1
            // 
            number1.Location = new Point(60, 316);
            number1.Name = "number1";
            number1.Size = new Size(52, 45);
            number1.TabIndex = 6;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = true;
            number1.Click += number1_Click;
            // 
            // button0
            // 
            button0.Location = new Point(118, 367);
            button0.Name = "button0";
            button0.Size = new Size(52, 45);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // tbInput
            // 
            tbInput.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            tbInput.Location = new Point(40, 44);
            tbInput.Multiline = true;
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(326, 66);
            tbInput.TabIndex = 10;
            // 
            // buttonMult
            // 
            buttonMult.Location = new Point(234, 214);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(52, 45);
            buttonMult.TabIndex = 11;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(234, 265);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(52, 45);
            buttonSub.TabIndex = 12;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(234, 316);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(52, 45);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(234, 367);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(52, 45);
            buttonEquals.TabIndex = 14;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 486);
            Controls.Add(buttonEquals);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSub);
            Controls.Add(buttonMult);
            Controls.Add(tbInput);
            Controls.Add(button0);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(number6);
            Controls.Add(number5);
            Controls.Add(number4);
            Controls.Add(number9);
            Controls.Add(number8);
            Controls.Add(number7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button number7;
        private Button number8;
        private Button number9;
        private Button number6;
        private Button number5;
        private Button number4;
        private Button number3;
        private Button number2;
        private Button number1;
        private Button button0;
        private TextBox tbInput;
        private Button buttonMult;
        private Button buttonSub;
        private Button buttonAdd;
        private Button buttonEquals;
    }
}