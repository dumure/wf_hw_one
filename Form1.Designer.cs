﻿namespace wf_hw_one
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 86);
            label1.Name = "label1";
            label1.Size = new Size(236, 44);
            label1.TabIndex = 0;
            label1.Text = "Вы поставите мне 12?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(52, 154);
            button1.Name = "button1";
            button1.Size = new Size(61, 37);
            button1.TabIndex = 1;
            button1.Text = "Да";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 154);
            button2.Name = "button2";
            button2.Size = new Size(61, 37);
            button2.TabIndex = 2;
            button2.Text = "Нет";
            button2.UseVisualStyleBackColor = true;
            button2.MouseEnter += button2_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "Form1";
            Text = "Задание 1.1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}