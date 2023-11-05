using Microsoft.VisualBasic;
using System.Globalization;

namespace OOPLR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telephone tel = new();
            MessageBox.Show(tel.Info());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var screenSize = double.Parse(Interaction.InputBox("Введіть розмір екрану телефону: ", "Введення"));
                var width = double.Parse(Interaction.InputBox("Введіть ширину телефону: ", "Введення"));
                var length = double.Parse(Interaction.InputBox("Введіть довжину телефону: ", "Введення"));
                var thickness = double.Parse(Interaction.InputBox("Введіть товщину телефону: ", "Введення"));
                var creationDate = DateTime.ParseExact(Interaction.InputBox("Введіть дату виготовлення телефону у форматі (ddMMyyyy): ", "Введення"), "ddMMyyyy", CultureInfo.InvariantCulture);
                Telephone tel = new(screenSize, width, length, thickness, creationDate);
                MessageBox.Show(tel.Info());
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Помилка");
            }


        }
    }
}
