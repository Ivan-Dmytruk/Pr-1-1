using System.Drawing.Text;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace Pr_1_1
{
    public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
            button3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            button1.Text = "Фото 1";

        }
        private int state = 0;
        private Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            changeState();
        }
        private void changeState()
        {
            int minX = 300;
            int maxX = 1100;
            int minY = 30;
            int maxY = 350;
            int minSizeX = 160;
            int maxSizeX = 860;
            int minSizeY = 130;
            int maxSizeY = 660;

            if (state == 0 || state == 3)
            {
                button1_action1();
            v1:
                int newX = rand.Next(0, 1400);
                int newY = rand.Next(0, 800);
                if (newX < minX || newX > maxX || newY < minY || newY > maxY)
                    goto v1;

                v2:
                int newSizeX = rand.Next(0, 1000);
                int newSizeY = rand.Next(0, 700);
                if (newSizeX < minSizeX || newSizeX > maxSizeX || newSizeY < minSizeY || newSizeY > maxSizeY)
                    goto v2;

                pictureBox1.Location = new Point(newX, newY);
                pictureBox1.Size = new Size(newSizeX, newSizeY);  
            }
            else if (state == 1)
            {
                button1_action2();
            v3:
                int newX = rand.Next(0, 1400);
                int newY = rand.Next(0, 800);
                if (newX < minX || newX > maxX || newY < minY || newY > maxY)
                    goto v3;

                v4:
                int newSizeX = rand.Next(0, 1000);
                int newSizeY = rand.Next(0, 700);
                if (newSizeX < minSizeX || newSizeX > maxSizeX || newSizeY < minSizeY || newSizeY > maxSizeY)
                    goto v4;

                pictureBox2.Location = new Point(newX, newY);
                pictureBox2.Size = new Size(newSizeX, newSizeY);  
            }
            else if (state == 2)
            {
                button1_action3();
            v5:
                int newX = rand.Next(0, 1400);
                int newY = rand.Next(0, 800);
                if (newX < minX || newX > maxX || newY < minY || newY > maxY)
                    goto v5;

                v6:
                int newSizeX = rand.Next(0, 1000);
                int newSizeY = rand.Next(0, 700);
                if (newSizeX < minSizeX || newSizeX > maxSizeX || newSizeY < minSizeY || newSizeY > maxSizeY)
                    goto v6;

                pictureBox3.Location = new Point(newX, newY);
                pictureBox3.Size = new Size(newSizeX, newSizeY); 
            }
        }
        private void button1_action1()
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            button1.Text = "Фото 2";
            button3.Visible = true;
            state = 1;
        }
        private void button1_action2()
        {
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            button1.Text = "Фото 3";
            button3.Visible = true;
            state = 2;
        }
        private void button1_action3()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            button1.Text = "Фото 1";
            button3.Visible = true;
            state = 3;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Size = new Size(button2.Width + 10, button2.Height + 5);

            int randomState = rand.Next(1, 4);
            switch (randomState)
            {
                case 1:
                    button1_action1();
                    break;
                case 2:
                    button1_action2();
                    break;
                case 3:
                    button1_action3();
                    break;
            }

            System.Windows.Forms.Timer resizeTimer = new System.Windows.Forms.Timer();
            resizeTimer.Interval = 300; 

            int minWidth = 80;
            int maxWidth = 200;
            int minHeight = 30;
            int maxHeight = 100;

            resizeTimer.Tick += (s, args) =>
            {
                int newWidth = rand.Next(minWidth, maxWidth + 1);
                int newHeight = rand.Next(minHeight, maxHeight + 1);

                button2.Size = new Size(newWidth, newHeight);
            };

            resizeTimer.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            button1.Text = "Фото 1";
            button3.Visible = false;
            state = 0;
        }
    }
}
