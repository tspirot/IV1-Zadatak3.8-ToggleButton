namespace Zadatak3._8
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
            myToggleButton1 = new MyToggleButton();
            myToggleButton2 = new MyToggleButton();
            SuspendLayout();
            // 
            // myToggleButton1
            // 
            myToggleButton1.AutoSize = true;
            myToggleButton1.Location = new Point(110, 76);
            myToggleButton1.MinimumSize = new Size(35, 22);
            myToggleButton1.Name = "myToggleButton1";
            myToggleButton1.OffBackColor = Color.Gray;
            myToggleButton1.OffToggleColor = Color.Gainsboro;
            myToggleButton1.OnBackColor = Color.MediumSlateBlue;
            myToggleButton1.OnToggleColor = Color.WhiteSmoke;
            myToggleButton1.Size = new Size(35, 22);
            myToggleButton1.SolidStyle = true;
            myToggleButton1.TabIndex = 0;
            myToggleButton1.UseVisualStyleBackColor = true;
            // 
            // myToggleButton2
            // 
            myToggleButton2.AutoSize = true;
            myToggleButton2.Location = new Point(262, 102);
            myToggleButton2.MinimumSize = new Size(88, 44);
            myToggleButton2.Name = "myToggleButton2";
            myToggleButton2.OffBackColor = Color.FromArgb(255, 255, 128);
            myToggleButton2.OffToggleColor = Color.Silver;
            myToggleButton2.OnBackColor = Color.Lime;
            myToggleButton2.OnToggleColor = Color.WhiteSmoke;
            myToggleButton2.Size = new Size(88, 44);
            myToggleButton2.SolidStyle = true;
            myToggleButton2.TabIndex = 1;
            myToggleButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myToggleButton2);
            Controls.Add(myToggleButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyToggleButton myToggleButton1;
        private MyToggleButton myToggleButton2;
    }
}