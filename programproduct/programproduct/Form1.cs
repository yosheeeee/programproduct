
namespace programproduct
{
    public partial class Programproduct : Form
    {
        public Programproduct()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            string output;
            double schet;
            schet = Convert.ToDouble(input);
            schet = Math.Sqrt(schet);
            output = schet.ToString();
            textBox1.Text = output ;
        }
    }
}