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
            settingsButton = new Button();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            RotateRight = new Button();
            MoveRight = new Button();
            MoveLeft = new Button();
            MoveDown = new Button();
            SizeMinus = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1287, 445);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 0;
            button1.Text = "Нарисовать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MoveUp
            // 
            MoveUp.Location = new Point(1322, 474);
            MoveUp.Name = "MoveUp";
            MoveUp.Size = new Size(23, 23);
            MoveUp.TabIndex = 1;
            MoveUp.Text = "↑";
            MoveUp.UseVisualStyleBackColor = true;
            MoveUp.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1290, 558);
            button3.Name = "button3";
            button3.Size = new Size(46, 22);
            button3.TabIndex = 2;
            button3.Text = "↶";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1290, 593);
            button4.Name = "button4";
            button4.Size = new Size(46, 22);
            button4.TabIndex = 3;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // settingsButton
            // 
            settingsButton.Image = Properties.Resources.settings1;
            settingsButton.Location = new Point(1349, 12);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(40, 40);
            settingsButton.TabIndex = 4;
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1417, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 237);
            panel1.TabIndex = 5;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 97);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Мировые";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 59);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Экранные";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Отображение координат";
            // 
            // RotateRight
            // 
            RotateRight.Location = new Point(1348, 558);
            RotateRight.Name = "RotateRight";
            RotateRight.Size = new Size(41, 22);
            RotateRight.TabIndex = 6;
            RotateRight.Text = "↷";
            RotateRight.UseVisualStyleBackColor = true;
            RotateRight.Click += RotateRight_Click;
            // 
            // MoveRight
            // 
            MoveRight.Location = new Point(1351, 499);
            MoveRight.Name = "MoveRight";
            MoveRight.Size = new Size(24, 23);
            MoveRight.TabIndex = 7;
            MoveRight.Text = "→";
            MoveRight.UseVisualStyleBackColor = true;
            MoveRight.Click += MoveRight_Click;
            // 
            // MoveLeft
            // 
            MoveLeft.Location = new Point(1290, 499);
            MoveLeft.Name = "MoveLeft";
            MoveLeft.Size = new Size(26, 23);
            MoveLeft.TabIndex = 8;
            MoveLeft.Text = "←";
            MoveLeft.UseVisualStyleBackColor = true;
            MoveLeft.Click += MoveLeft_Click;
            // 
            // MoveDown
            // 
            MoveDown.Location = new Point(1322, 520);
            MoveDown.Name = "MoveDown";
            MoveDown.Size = new Size(23, 22);
            MoveDown.TabIndex = 9;
            MoveDown.Text = "↓";
            MoveDown.UseVisualStyleBackColor = true;
            MoveDown.Click += MoveDown_Click;
            // 
            // SizeMinus
            // 
            SizeMinus.Location = new Point(1348, 593);
            SizeMinus.Name = "SizeMinus";
            SizeMinus.Size = new Size(42, 22);
            SizeMinus.TabIndex = 10;
            SizeMinus.Text = "-";
            SizeMinus.UseVisualStyleBackColor = true;
            SizeMinus.Click += SizeMinus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 644);
            Controls.Add(SizeMinus);
            Controls.Add(MoveDown);
            Controls.Add(MoveLeft);
            Controls.Add(MoveRight);
            Controls.Add(RotateRight);
            Controls.Add(panel1);
            Controls.Add(settingsButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(MoveUp);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button MoveUp;
        private Button button3;
        private Button button4;
        private Button settingsButton;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button RotateRight;
        private Button MoveRight;
        private Button MoveLeft;
        private Button MoveDown;
        private Button SizeMinus;
    }
}