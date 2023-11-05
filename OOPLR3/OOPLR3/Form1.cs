using Microsoft.VisualBasic;

namespace OOPLR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Telephone.Count.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new MobilePhone().Info());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new HomeTelephone().Info());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new Telephone().Info());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var weight = double.Parse(Interaction.InputBox("Введіть вагу мобільного телефону:", "Введення"));
                var width = double.Parse(Interaction.InputBox("Введіть ширину мобільного телефону:", "Введення"));
                var height = double.Parse(Interaction.InputBox("Введіть висоту мобільного телефону:", "Введення"));
                var name = Interaction.InputBox("Введіть назву мобільного телефону:", "Введення");
                var mp = new MobilePhone(width, height, weight, name);
                MessageBox.Show(mp.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var weight = double.Parse(Interaction.InputBox("Введіть вагу стаціонарного телефону:", "Введення"));
                var width = double.Parse(Interaction.InputBox("Введіть ширину стаціонарного телефону:", "Введення"));
                var height = double.Parse(Interaction.InputBox("Введіть висоту стаціонарного телефону:", "Введення"));
                var name = Interaction.InputBox("Введіть назву стаціонарного телефону:", "Введення");
                var sp = new HomeTelephone(width, height, weight, name);
                MessageBox.Show(sp.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
        }
    }
}
