using System.Runtime.CompilerServices;

namespace WinForms___init_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bay")
            {
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private async void button3_Click(object sender, EventArgs e)
        {
            string date = $"{DateTime.Today.Day}.{DateTime.Today.Month}.{DateTime.Today.Year}";
            string time = $"{DateTime.Now.TimeOfDay}";
            MessageBox.Show(date);
            await Task.Delay(2000);
            MessageBox.Show(time);
        }
        public static int NWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else if (b > a)
                {
                    b = b - a;
                }
            }
            return a;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] split = textBox2.Text.Split(" ");
            textBox3.Text = $"{NWD(int.Parse(split[0]), int.Parse(split[1]))}";
            textBox4.Text = $"{(int.Parse(split[0]) * int.Parse(split[1])) / NWD(int.Parse(split[0]), int.Parse(split[1]))}";
        }
    }
}
