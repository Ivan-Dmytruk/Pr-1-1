namespace Pr_1_1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(418, 4);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Анкета Студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 1;
            label2.Text = "Дмитрук";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(54, 26);
            label3.TabIndex = 2;
            label3.Text = "Іван";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(14, 124);
            label4.Name = "label4";
            label4.Size = new Size(79, 26);
            label4.TabIndex = 3;
            label4.Text = "Пі-232";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(120, 26);
            label5.TabIndex = 4;
            label5.Text = "19.06.2008";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_1_2025_04_03_22_17_16;
            pictureBox1.Location = new Point(300, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.photo_12_2025_04_03_22_09_58;
            pictureBox2.Location = new Point(300, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(313, 428);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(52, 270);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 327);
            button2.Name = "button2";
            button2.Size = new Size(102, 37);
            button2.TabIndex = 9;
            button2.Text = "Рандом";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(52, 384);
            button3.Name = "button3";
            button3.Size = new Size(102, 43);
            button3.TabIndex = 10;
            button3.Text = "Очистити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.photo_9_2025_04_03_22_09_58;
            pictureBox3.Location = new Point(300, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(313, 428);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 564);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox3;
    }
}
