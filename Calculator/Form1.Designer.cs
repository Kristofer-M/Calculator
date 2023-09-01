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
            buttonDIv = new Button();
            buttonDel = new Button();
            buttonClear = new Button();
            buttonDot = new Button();
            buttonPower = new Button();
            buttonOpenBracket = new Button();
            buttonCloseBracket = new Button();
            buttonSqrt = new Button();
            buttonMemoryPlus = new Button();
            buttonMemoryMinus = new Button();
            buttonMemoryClear = new Button();
            buttonPercent = new Button();
            lbMemory = new Label();
            tbMemory = new TextBox();
            SuspendLayout();
            // 
            // number7
            // 
            number7.Location = new Point(39, 187);
            number7.Name = "number7";
            number7.Size = new Size(52, 45);
            number7.TabIndex = 0;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = true;
            number7.Click += number7_Click;
            // 
            // number8
            // 
            number8.Location = new Point(97, 187);
            number8.Name = "number8";
            number8.Size = new Size(52, 45);
            number8.TabIndex = 1;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = true;
            number8.Click += number8_Click;
            // 
            // number9
            // 
            number9.Location = new Point(155, 187);
            number9.Name = "number9";
            number9.Size = new Size(52, 45);
            number9.TabIndex = 2;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = true;
            number9.Click += number9_Click;
            // 
            // number6
            // 
            number6.Location = new Point(155, 238);
            number6.Name = "number6";
            number6.Size = new Size(52, 45);
            number6.TabIndex = 5;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = true;
            number6.Click += number6_Click;
            // 
            // number5
            // 
            number5.Location = new Point(97, 238);
            number5.Name = "number5";
            number5.Size = new Size(52, 45);
            number5.TabIndex = 4;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = true;
            number5.Click += number5_Click;
            // 
            // number4
            // 
            number4.Location = new Point(39, 238);
            number4.Name = "number4";
            number4.Size = new Size(52, 45);
            number4.TabIndex = 3;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = true;
            number4.Click += number4_Click;
            // 
            // number3
            // 
            number3.Location = new Point(155, 289);
            number3.Name = "number3";
            number3.Size = new Size(52, 45);
            number3.TabIndex = 8;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = true;
            number3.Click += number3_Click;
            // 
            // number2
            // 
            number2.Location = new Point(97, 289);
            number2.Name = "number2";
            number2.Size = new Size(52, 45);
            number2.TabIndex = 7;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = true;
            number2.Click += number2_Click;
            // 
            // number1
            // 
            number1.Location = new Point(39, 289);
            number1.Name = "number1";
            number1.Size = new Size(52, 45);
            number1.TabIndex = 6;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = true;
            number1.Click += number1_Click;
            // 
            // button0
            // 
            button0.Location = new Point(39, 340);
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
            tbInput.Size = new Size(283, 66);
            tbInput.TabIndex = 10;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // buttonMult
            // 
            buttonMult.ForeColor = Color.Black;
            buttonMult.Location = new Point(213, 187);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(52, 45);
            buttonMult.TabIndex = 11;
            buttonMult.Text = "×";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(213, 238);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(52, 45);
            buttonSub.TabIndex = 12;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(213, 289);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(52, 45);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(155, 340);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(52, 45);
            buttonEquals.TabIndex = 14;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonDIv
            // 
            buttonDIv.ForeColor = Color.Black;
            buttonDIv.Location = new Point(213, 136);
            buttonDIv.Name = "buttonDIv";
            buttonDIv.Size = new Size(52, 45);
            buttonDIv.TabIndex = 15;
            buttonDIv.Text = "÷";
            buttonDIv.UseVisualStyleBackColor = true;
            buttonDIv.Click += buttonDIv_Click;
            // 
            // buttonDel
            // 
            buttonDel.ForeColor = Color.Black;
            buttonDel.Location = new Point(97, 136);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(52, 45);
            buttonDel.TabIndex = 16;
            buttonDel.Text = "DEL";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonClear
            // 
            buttonClear.ForeColor = Color.Black;
            buttonClear.Location = new Point(39, 136);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(52, 45);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDot
            // 
            buttonDot.ForeColor = Color.Black;
            buttonDot.Location = new Point(97, 340);
            buttonDot.Name = "buttonDot";
            buttonDot.RightToLeft = RightToLeft.No;
            buttonDot.Size = new Size(52, 45);
            buttonDot.TabIndex = 18;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonPower
            // 
            buttonPower.ForeColor = Color.Black;
            buttonPower.Location = new Point(155, 136);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(52, 45);
            buttonPower.TabIndex = 19;
            buttonPower.Text = "^";
            buttonPower.UseVisualStyleBackColor = true;
            buttonPower.Click += buttonPower_Click;
            // 
            // buttonOpenBracket
            // 
            buttonOpenBracket.Location = new Point(213, 340);
            buttonOpenBracket.Name = "buttonOpenBracket";
            buttonOpenBracket.Size = new Size(52, 45);
            buttonOpenBracket.TabIndex = 20;
            buttonOpenBracket.Text = "(";
            buttonOpenBracket.UseVisualStyleBackColor = true;
            buttonOpenBracket.Click += buttonOpenBracket_Click;
            // 
            // buttonCloseBracket
            // 
            buttonCloseBracket.Location = new Point(271, 340);
            buttonCloseBracket.Name = "buttonCloseBracket";
            buttonCloseBracket.Size = new Size(52, 45);
            buttonCloseBracket.TabIndex = 21;
            buttonCloseBracket.Text = ")";
            buttonCloseBracket.UseVisualStyleBackColor = true;
            buttonCloseBracket.Click += buttonCloseBracket_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.ForeColor = Color.Black;
            buttonSqrt.Location = new Point(271, 136);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(52, 45);
            buttonSqrt.TabIndex = 22;
            buttonSqrt.Text = "√";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += buttonSqrt_Click;
            // 
            // buttonMemoryPlus
            // 
            buttonMemoryPlus.ForeColor = Color.Black;
            buttonMemoryPlus.Location = new Point(271, 289);
            buttonMemoryPlus.Name = "buttonMemoryPlus";
            buttonMemoryPlus.Size = new Size(52, 45);
            buttonMemoryPlus.TabIndex = 23;
            buttonMemoryPlus.Text = "M+";
            buttonMemoryPlus.UseVisualStyleBackColor = true;
            buttonMemoryPlus.Click += buttonMemoryPlus_Click;
            // 
            // buttonMemoryMinus
            // 
            buttonMemoryMinus.ForeColor = Color.Black;
            buttonMemoryMinus.Location = new Point(271, 238);
            buttonMemoryMinus.Name = "buttonMemoryMinus";
            buttonMemoryMinus.Size = new Size(52, 45);
            buttonMemoryMinus.TabIndex = 24;
            buttonMemoryMinus.Text = "M-";
            buttonMemoryMinus.UseVisualStyleBackColor = true;
            buttonMemoryMinus.Click += buttonMemoryMinus_Click;
            // 
            // buttonMemoryClear
            // 
            buttonMemoryClear.ForeColor = Color.Black;
            buttonMemoryClear.Location = new Point(271, 187);
            buttonMemoryClear.Name = "buttonMemoryClear";
            buttonMemoryClear.Size = new Size(52, 45);
            buttonMemoryClear.TabIndex = 25;
            buttonMemoryClear.Text = "MC";
            buttonMemoryClear.UseVisualStyleBackColor = true;
            buttonMemoryClear.Click += buttonMemoryClear_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.Location = new Point(39, 391);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(52, 45);
            buttonPercent.TabIndex = 26;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // lbMemory
            // 
            lbMemory.AutoSize = true;
            lbMemory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMemory.Location = new Point(114, 401);
            lbMemory.Name = "lbMemory";
            lbMemory.Size = new Size(76, 21);
            lbMemory.TabIndex = 27;
            lbMemory.Text = "Memory: ";
            // 
            // tbMemory
            // 
            tbMemory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMemory.Location = new Point(196, 398);
            tbMemory.Name = "tbMemory";
            tbMemory.ReadOnly = true;
            tbMemory.Size = new Size(127, 29);
            tbMemory.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 442);
            Controls.Add(tbMemory);
            Controls.Add(lbMemory);
            Controls.Add(buttonPercent);
            Controls.Add(buttonMemoryClear);
            Controls.Add(buttonMemoryMinus);
            Controls.Add(buttonMemoryPlus);
            Controls.Add(buttonSqrt);
            Controls.Add(buttonCloseBracket);
            Controls.Add(buttonOpenBracket);
            Controls.Add(buttonPower);
            Controls.Add(buttonDot);
            Controls.Add(buttonClear);
            Controls.Add(buttonDel);
            Controls.Add(buttonDIv);
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
            Text = "Calculator";
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
        private Button buttonDIv;
        private Button buttonDel;
        private Button buttonClear;
        private Button buttonDot;
        private Button buttonPower;
        private Button buttonOpenBracket;
        private Button buttonCloseBracket;
        private Button buttonSqrt;
        private Button buttonMemoryPlus;
        private Button buttonMemoryMinus;
        private Button buttonMemoryClear;
        private Button buttonPercent;
        private Label lbMemory;
        private TextBox tbMemory;
    }
}