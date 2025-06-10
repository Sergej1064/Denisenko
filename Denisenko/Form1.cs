using System.Windows.Forms;

namespace Denisenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedWord = listBox1.SelectedItem.ToString();

                // ѕроверка, чтобы не добавл€ть дубликаты
                if (!listBox2.Items.Contains(selectedWord))
                {
                    listBox2.Items.Add(selectedWord);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedWord = listBox1.SelectedItem.ToString();

                // ѕроверка, чтобы не добавл€ть дубликаты
                if (!listBox2.Items.Contains(selectedWord))
                {
                    listBox2.Items.Add(selectedWord);
                }
            }
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
