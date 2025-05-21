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
            if (state == 0 || state == 3)
                button1_action1();
            else if (state == 1)
                button1_action2();
            else if (state == 2)
                button1_action3();

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
