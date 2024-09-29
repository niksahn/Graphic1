namespace Graphic1
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
            this.button1 = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RotateRight = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.SizeMinus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XRotateLeft = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1287, 406);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 0;
            button1.Text = "Нарисовать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MoveUp
            // 
            MoveUp.Location = new Point(1322, 435);
            MoveUp.Name = "MoveUp";
            MoveUp.Size = new Size(23, 23);
            MoveUp.TabIndex = 1;
            MoveUp.Text = "↑";
            MoveUp.UseVisualStyleBackColor = true;
            MoveUp.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1290, 519);
            button3.Name = "button3";
            button3.Size = new Size(46, 22);
            button3.TabIndex = 2;
            button3.Text = "↶";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1289, 610);
            button4.Name = "button4";
            button4.Size = new Size(46, 22);
            button4.TabIndex = 3;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RotateRight
            // 
            RotateRight.Location = new Point(1348, 519);
            RotateRight.Name = "RotateRight";
            RotateRight.Size = new Size(41, 22);
            RotateRight.TabIndex = 6;
            RotateRight.Text = "↷";
            RotateRight.UseVisualStyleBackColor = true;
            RotateRight.Click += RotateRight_Click;
            // 
            // MoveRight
            // 
            MoveRight.Location = new Point(1351, 460);
            MoveRight.Name = "MoveRight";
            MoveRight.Size = new Size(24, 23);
            MoveRight.TabIndex = 7;
            MoveRight.Text = "→";
            MoveRight.UseVisualStyleBackColor = true;
            MoveRight.Click += MoveRight_Click;
            // 
            // MoveLeft
            // 
            MoveLeft.Location = new Point(1290, 460);
            MoveLeft.Name = "MoveLeft";
            MoveLeft.Size = new Size(26, 23);
            MoveLeft.TabIndex = 8;
            MoveLeft.Text = "←";
            MoveLeft.UseVisualStyleBackColor = true;
            MoveLeft.Click += MoveLeft_Click;
            // 
            // MoveDown
            // 
            MoveDown.Location = new Point(1322, 481);
            MoveDown.Name = "MoveDown";
            MoveDown.Size = new Size(23, 22);
            MoveDown.TabIndex = 9;
            MoveDown.Text = "↓";
            MoveDown.UseVisualStyleBackColor = true;
            MoveDown.Click += MoveDown_Click;
            // 
            // SizeMinus
            // 
            SizeMinus.Location = new Point(1347, 610);
            SizeMinus.Name = "SizeMinus";
            SizeMinus.Size = new Size(42, 22);
            SizeMinus.TabIndex = 10;
            SizeMinus.Text = "-";
            SizeMinus.UseVisualStyleBackColor = true;
            SizeMinus.Click += SizeMinus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1267, 523);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 11;
            label1.Text = "Z:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1267, 554);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 12;
            label2.Text = "X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1267, 583);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 13;
            label3.Text = "Y:";
            // 
            // XRotateLeft
            // 
            XRotateLeft.Location = new Point(1291, 554);
            XRotateLeft.Name = "XRotateLeft";
            XRotateLeft.Size = new Size(46, 22);
            XRotateLeft.TabIndex = 14;
            XRotateLeft.Text = "↶";
            XRotateLeft.UseVisualStyleBackColor = true;
            XRotateLeft.Click += XRotateLeft_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1343, 554);
            button2.Name = "button2";
            button2.Size = new Size(46, 22);
            button2.TabIndex = 15;
            button2.Text = "↷";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(1291, 583);
            button5.Name = "button5";
            button5.Size = new Size(46, 22);
            button5.TabIndex = 16;
            button5.Text = "↶";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1343, 583);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 22);
            this.button6.TabIndex = 17;
            this.button6.Text = "↷";
            button6.Click += button6_Click;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1300, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "XOY";
            this.button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1300, 328);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "XOZ";
            this.button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;

            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1300, 367);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "YOZ";
            this.button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 644);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.XRotateLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeMinus);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveLeft);
            this.Controls.Add(this.MoveRight);
            this.Controls.Add(this.RotateRight);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button MoveUp;
        private Button button3;
        private Button button4;
        private Button RotateRight;
        private Button MoveRight;
        private Button MoveLeft;
        private Button MoveDown;
        private Button SizeMinus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button XRotateLeft;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}