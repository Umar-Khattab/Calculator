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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnZero = new Button();
            Btn1 = new Button();
            Btn7 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            Btn3 = new Button();
            Btn6 = new Button();
            BtnEqual = new Button();
            BtnRemove = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn2 = new Button();
            BtnPoint = new Button();
            BtnPlus = new Button();
            BtnMinus = new Button();
            BtnTimes = new Button();
            btnOver = new Button();
            BtnMod = new Button();
            Output = new TextBox();
            OutputTracker = new TextBox();
            Delete_Character = new Button();
            SuspendLayout();
            // 
            // BtnZero
            // 
            BtnZero.BackColor = Color.FromArgb(64, 64, 64);
            BtnZero.FlatStyle = FlatStyle.Popup;
            BtnZero.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnZero.ForeColor = SystemColors.ControlLightLight;
            BtnZero.Location = new Point(11, 282);
            BtnZero.Margin = new Padding(2);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(68, 37);
            BtnZero.TabIndex = 5;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = false;
            BtnZero.Click += EnterNumbers;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.FromArgb(64, 64, 64);
            Btn1.FlatStyle = FlatStyle.Popup;
            Btn1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1.ForeColor = SystemColors.ControlLightLight;
            Btn1.Location = new Point(11, 241);
            Btn1.Margin = new Padding(2);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(68, 37);
            Btn1.TabIndex = 11;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += EnterNumbers;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.FromArgb(64, 64, 64);
            Btn7.FlatStyle = FlatStyle.Popup;
            Btn7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn7.ForeColor = SystemColors.ButtonHighlight;
            Btn7.Location = new Point(11, 159);
            Btn7.Margin = new Padding(2);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(68, 37);
            Btn7.TabIndex = 12;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += EnterNumbers;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.FromArgb(64, 64, 64);
            Btn5.FlatStyle = FlatStyle.Popup;
            Btn5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn5.ForeColor = SystemColors.ControlLightLight;
            Btn5.Location = new Point(83, 200);
            Btn5.Margin = new Padding(2);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(73, 37);
            Btn5.TabIndex = 13;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += EnterNumbers;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.FromArgb(64, 64, 64);
            Btn4.FlatStyle = FlatStyle.Popup;
            Btn4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn4.ForeColor = SystemColors.ControlLightLight;
            Btn4.Location = new Point(11, 200);
            Btn4.Margin = new Padding(2);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(68, 37);
            Btn4.TabIndex = 14;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += EnterNumbers;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.FromArgb(64, 64, 64);
            Btn3.FlatStyle = FlatStyle.Popup;
            Btn3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn3.ForeColor = SystemColors.ControlLightLight;
            Btn3.Location = new Point(160, 241);
            Btn3.Margin = new Padding(2);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(64, 37);
            Btn3.TabIndex = 15;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += EnterNumbers;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.FromArgb(64, 64, 64);
            Btn6.FlatStyle = FlatStyle.Popup;
            Btn6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn6.ForeColor = SystemColors.ControlLightLight;
            Btn6.Location = new Point(160, 200);
            Btn6.Margin = new Padding(2);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(64, 37);
            Btn6.TabIndex = 16;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += EnterNumbers;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = Color.Orange;
            BtnEqual.FlatStyle = FlatStyle.Popup;
            BtnEqual.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEqual.ForeColor = SystemColors.ButtonFace;
            BtnEqual.Location = new Point(160, 282);
            BtnEqual.Margin = new Padding(2);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(64, 37);
            BtnEqual.TabIndex = 17;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = Color.Gray;
            BtnRemove.FlatStyle = FlatStyle.Popup;
            BtnRemove.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRemove.Location = new Point(160, 118);
            BtnRemove.Margin = new Padding(2);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(132, 37);
            BtnRemove.TabIndex = 19;
            BtnRemove.Text = "AC";
            BtnRemove.UseVisualStyleBackColor = false;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.FromArgb(64, 64, 64);
            Btn9.FlatStyle = FlatStyle.Popup;
            Btn9.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn9.ForeColor = SystemColors.ControlLightLight;
            Btn9.Location = new Point(160, 159);
            Btn9.Margin = new Padding(2);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(64, 37);
            Btn9.TabIndex = 20;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += EnterNumbers;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.FromArgb(64, 64, 64);
            Btn8.FlatStyle = FlatStyle.Popup;
            Btn8.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn8.ForeColor = SystemColors.ControlLightLight;
            Btn8.Location = new Point(83, 159);
            Btn8.Margin = new Padding(2);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(73, 37);
            Btn8.TabIndex = 21;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += EnterNumbers;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.FromArgb(64, 64, 64);
            Btn2.FlatStyle = FlatStyle.Popup;
            Btn2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn2.ForeColor = SystemColors.ControlLightLight;
            Btn2.Location = new Point(83, 241);
            Btn2.Margin = new Padding(2);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(73, 37);
            Btn2.TabIndex = 22;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += EnterNumbers;
            // 
            // BtnPoint
            // 
            BtnPoint.BackColor = Color.FromArgb(64, 64, 64);
            BtnPoint.FlatStyle = FlatStyle.Popup;
            BtnPoint.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPoint.ForeColor = SystemColors.ControlLightLight;
            BtnPoint.Location = new Point(83, 282);
            BtnPoint.Margin = new Padding(2);
            BtnPoint.Name = "BtnPoint";
            BtnPoint.Size = new Size(73, 37);
            BtnPoint.TabIndex = 23;
            BtnPoint.Text = ".";
            BtnPoint.UseVisualStyleBackColor = false;
            BtnPoint.Click += EnterNumbers;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.Orange;
            BtnPlus.FlatStyle = FlatStyle.Popup;
            BtnPlus.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPlus.ForeColor = SystemColors.ControlLightLight;
            BtnPlus.Location = new Point(228, 159);
            BtnPlus.Margin = new Padding(2);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(64, 37);
            BtnPlus.TabIndex = 24;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += operations;
            // 
            // BtnMinus
            // 
            BtnMinus.BackColor = Color.Orange;
            BtnMinus.FlatStyle = FlatStyle.Popup;
            BtnMinus.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMinus.ForeColor = SystemColors.ControlLightLight;
            BtnMinus.Location = new Point(228, 200);
            BtnMinus.Margin = new Padding(2);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(64, 37);
            BtnMinus.TabIndex = 25;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = false;
            BtnMinus.Click += operations;
            // 
            // BtnTimes
            // 
            BtnTimes.AccessibleName = "&*";
            BtnTimes.BackColor = Color.Orange;
            BtnTimes.FlatStyle = FlatStyle.Popup;
            BtnTimes.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTimes.ForeColor = SystemColors.ControlLightLight;
            BtnTimes.Location = new Point(228, 241);
            BtnTimes.Margin = new Padding(2);
            BtnTimes.Name = "BtnTimes";
            BtnTimes.Size = new Size(64, 37);
            BtnTimes.TabIndex = 26;
            BtnTimes.Text = "X";
            BtnTimes.UseVisualStyleBackColor = false;
            BtnTimes.Click += operations;
            // 
            // btnOver
            // 
            btnOver.BackColor = Color.Orange;
            btnOver.FlatStyle = FlatStyle.Popup;
            btnOver.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnOver.ForeColor = SystemColors.ControlLightLight;
            btnOver.Location = new Point(228, 282);
            btnOver.Margin = new Padding(2);
            btnOver.Name = "btnOver";
            btnOver.Size = new Size(64, 37);
            btnOver.TabIndex = 27;
            btnOver.Text = "/";
            btnOver.UseVisualStyleBackColor = false;
            btnOver.Click += operations;
            // 
            // BtnMod
            // 
            BtnMod.BackColor = Color.Gray;
            BtnMod.FlatStyle = FlatStyle.Popup;
            BtnMod.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMod.Location = new Point(83, 118);
            BtnMod.Margin = new Padding(2);
            BtnMod.Name = "BtnMod";
            BtnMod.Size = new Size(73, 37);
            BtnMod.TabIndex = 28;
            BtnMod.Text = "%";
            BtnMod.UseVisualStyleBackColor = false;
            BtnMod.Click += operations;
            // 
            // Output
            // 
            Output.BackColor = Color.Black;
            Output.BorderStyle = BorderStyle.None;
            Output.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Output.ForeColor = Color.White;
            Output.Location = new Point(11, 73);
            Output.Margin = new Padding(2);
            Output.Name = "Output";
            Output.ReadOnly = true;
            Output.Size = new Size(281, 29);
            Output.TabIndex = 29;
            Output.Text = "0";
            Output.TextAlign = HorizontalAlignment.Right;
            // 
            // OutputTracker
            // 
            OutputTracker.BackColor = Color.Black;
            OutputTracker.BorderStyle = BorderStyle.None;
            OutputTracker.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Italic, GraphicsUnit.Point);
            OutputTracker.ForeColor = Color.Gainsboro;
            OutputTracker.Location = new Point(11, 27);
            OutputTracker.Margin = new Padding(2);
            OutputTracker.Name = "OutputTracker";
            OutputTracker.ReadOnly = true;
            OutputTracker.RightToLeft = RightToLeft.Yes;
            OutputTracker.Size = new Size(281, 28);
            OutputTracker.TabIndex = 30;
            OutputTracker.Text = "0";
            OutputTracker.TextAlign = HorizontalAlignment.Right;
            // 
            // Delete_Character
            // 
            Delete_Character.BackColor = Color.Gray;
            Delete_Character.FlatStyle = FlatStyle.Popup;
            Delete_Character.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Delete_Character.Location = new Point(11, 118);
            Delete_Character.Margin = new Padding(2);
            Delete_Character.Name = "Delete_Character";
            Delete_Character.Size = new Size(68, 37);
            Delete_Character.TabIndex = 31;
            Delete_Character.Text = "Del";
            Delete_Character.UseVisualStyleBackColor = false;
            Delete_Character.Click += Delete_Character_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(303, 348);
            Controls.Add(Delete_Character);
            Controls.Add(OutputTracker);
            Controls.Add(Output);
            Controls.Add(BtnMod);
            Controls.Add(btnOver);
            Controls.Add(BtnTimes);
            Controls.Add(BtnMinus);
            Controls.Add(BtnPlus);
            Controls.Add(BtnPoint);
            Controls.Add(Btn2);
            Controls.Add(Btn8);
            Controls.Add(Btn9);
            Controls.Add(BtnRemove);
            Controls.Add(BtnEqual);
            Controls.Add(Btn6);
            Controls.Add(Btn3);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn7);
            Controls.Add(Btn1);
            Controls.Add(BtnZero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnZero;
        private Button Btn1;
        private Button Btn7;
        private Button Btn5;
        private Button Btn4;
        private Button Btn3;
        private Button Btn6;
        private Button BtnEqual;
        private Button BtnRemove;
        private Button Btn9;
        private Button Btn8;
        private Button Btn2;
        private Button BtnPoint;
        private Button BtnPlus;
        private Button BtnMinus;
        private Button BtnTimes;
        private Button btnOver;
        private Button BtnMod;
        private TextBox Output;
        private TextBox OutputTracker;
        private Button Delete_Character;
    }
}