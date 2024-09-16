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
            button1 = new Button();
            MoveUp = new Button();
            button3 = new Button();
            button4 = new Button();
            RotateRight = new Button();
            MoveRight = new Button();
            MoveLeft = new Button();
            MoveDown = new Button();
            SizeMinus = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            XRotateLeft = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
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
            button6.Location = new Point(1343, 583);
            button6.Name = "button6";
            button6.Size = new Size(46, 22);
            button6.TabIndex = 17;
            button6.Text = "↷";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 644);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(XRotateLeft);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SizeMinus);
            Controls.Add(MoveDown);
            Controls.Add(MoveLeft);
            Controls.Add(MoveRight);
            Controls.Add(RotateRight);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(MoveUp);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
    }
}