namespace wf_hw_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            button2.Location = new Point(random.Next(0, 284 - 61), random.Next(0, 261 - 37));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Спасибо!";
            button2.Visible = false;
            button1.Visible = false;
        }
    }
}