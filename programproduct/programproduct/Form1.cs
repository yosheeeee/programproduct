
namespace programproduct
{
    public partial class Programproduct : Form
    {   
        string input;
        string output;
        double schet;
        string strtochn;
        int tochn;
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
            input = textBox2.Text;           
            if (String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Ведите значение для подсчета");
            }
            bool chek = double.TryParse(input, out schet);
            if (chek)
            {
                schet = Math.Sqrt(schet);
            }
            strtochn = textBox3.Text;
            if (!String.IsNullOrEmpty(strtochn))
            {
                chek = int.TryParse(strtochn, out tochn);
                if (!chek)
                {
                    MessageBox.Show("Введите целое положительное значение");
                }else if(tochn<0)
                {
                    MessageBox.Show("Введите целое положительное значение");
                }
                else
                {
                    schet=Math.Round(schet,tochn);
                }
            }
            textBox1.Text=Convert.ToString(schet);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = null;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            if (label6.Text != newForm.chooselanguage)
            {
                switch (newForm.chooselanguage)
                {
                    case "en":
                        label6.Text = "en";
                        label1.Text = "This program calculates square roots";
                        textBox2.PlaceholderText = "value";
                        textBox3.PlaceholderText = "result";
                        label4.Text = "character precision";
                        textBox3.PlaceholderText = "value";
                        button2.Text = "clear";
                        button1.Text = "calculate";
                        break;
                    case "fr":
                        label6.Text = "fr";
                        label1.Text = "Ce programme calcule les racines carrées";
                        textBox2.PlaceholderText = "évaluer";
                        textBox3.PlaceholderText = "résultat";
                        label4.Text = "précision des caractères";
                        textBox3.PlaceholderText = "évaluer";
                        button2.Text = "dégager";
                        button1.Text = "calculer";
                        break;
                    case "ru":
                        label6.Text = "ru";
                        label1.Text = "Данная программа считает квадратные корни";
                        textBox2.PlaceholderText = "значение";
                        textBox3.PlaceholderText = "ответ";
                        label4.Text = "точность знаков";
                        textBox3.PlaceholderText = "значение";
                        button2.Text = "очистить";
                        button1.Text = "посчитать";
                        break;

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}