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
            TxtExibition = new TextBox();
            SumButton = new Button();
            LessButton = new Button();
            ButtonOne = new Button();
            ButtonTwo = new Button();
            buttonThree = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonZero = new Button();
            buttonEqual = new Button();
            TxtResult = new TextBox();
            SuspendLayout();
            // 
            // TxtExibition
            // 
            TxtExibition.Location = new Point(12, 12);
            TxtExibition.Name = "TxtExibition";
            TxtExibition.Size = new Size(409, 27);
            TxtExibition.TabIndex = 0;
            // 
            // SumButton
            // 
            SumButton.Location = new Point(12, 51);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(95, 58);
            SumButton.TabIndex = 1;
            SumButton.Text = "+";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // LessButton
            // 
            LessButton.Location = new Point(113, 51);
            LessButton.Name = "LessButton";
            LessButton.Size = new Size(95, 58);
            LessButton.TabIndex = 2;
            LessButton.Text = "-";
            LessButton.UseVisualStyleBackColor = true;
            // 
            // ButtonOne
            // 
            ButtonOne.Location = new Point(12, 115);
            ButtonOne.Name = "ButtonOne";
            ButtonOne.Size = new Size(187, 65);
            ButtonOne.TabIndex = 3;
            ButtonOne.Text = "1";
            ButtonOne.UseVisualStyleBackColor = true;
            ButtonOne.Click += button1_Click_1;
            // 
            // ButtonTwo
            // 
            ButtonTwo.Location = new Point(234, 115);
            ButtonTwo.Name = "ButtonTwo";
            ButtonTwo.Size = new Size(187, 65);
            ButtonTwo.TabIndex = 4;
            ButtonTwo.Text = "2";
            ButtonTwo.UseVisualStyleBackColor = true;
            ButtonTwo.Click += button2_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(455, 115);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(187, 65);
            buttonThree.TabIndex = 5;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(12, 186);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(187, 65);
            buttonFour.TabIndex = 6;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonFive
            // 
            buttonFive.Location = new Point(234, 186);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(187, 65);
            buttonFive.TabIndex = 7;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(455, 186);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(187, 65);
            buttonSix.TabIndex = 8;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += button6_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Location = new Point(12, 257);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(187, 65);
            buttonSeven.TabIndex = 9;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonEight
            // 
            buttonEight.Location = new Point(234, 257);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(187, 65);
            buttonEight.TabIndex = 10;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonNine
            // 
            buttonNine.Location = new Point(455, 257);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(187, 65);
            buttonNine.TabIndex = 11;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(234, 328);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(187, 65);
            buttonZero.TabIndex = 12;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(427, 12);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(35, 27);
            buttonEqual.TabIndex = 13;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(468, 12);
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(174, 27);
            TxtResult.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(TxtResult);
            Controls.Add(buttonEqual);
            Controls.Add(buttonZero);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonThree);
            Controls.Add(ButtonTwo);
            Controls.Add(ButtonOne);
            Controls.Add(LessButton);
            Controls.Add(SumButton);
            Controls.Add(TxtExibition);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtExibition;
        private Button SumButton;
        private Button LessButton;
        private Button ButtonOne;
        private Button ButtonTwo;
        private Button buttonThree;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonZero;
        private Button buttonEqual;
        private TextBox TxtResult;
    }
}
