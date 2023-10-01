namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float marks = float.Parse(textBox1.Text);
            if(marks<=100 && marks >= 90)
            {
                l1.Text = "grade A";
            }
            else if (marks<90 && marks >= 80)
            {
                l1.Text = "grade B";
            }
            else if (marks < 90 && marks >= 80)
            {
                l1.Text = "grade B";
            }
            else if (marks < 80 && marks >= 70)
            {
                l1.Text = "grade C";
            }
            else if (marks < 70 && marks >= 60)
            {
                l1.Text = "grade D";
            }
            else if (marks < 60)
            {
                l1.Text = "grade F, AND YOUR FAILED THE EXAME ";
            }
            else
            {
                l1.Text = "Not reconized your data!";
            }

            //string name, number, address, home;
            //name = textBox1.Text;
            //number = textBox2.Text;
            //address = textBox3.Text;
            //home = textBox4.Text;
            //MessageBox.Show("yes you do correctelly");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l2.Hide();
            txtCanab.Hide();
            button2.Hide();
        }
    }
}