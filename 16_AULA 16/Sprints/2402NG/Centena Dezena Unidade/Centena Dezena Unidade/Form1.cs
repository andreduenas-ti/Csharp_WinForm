using System.Windows.Forms.VisualStyles;

namespace Centena_Dezena_Unidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double entrada = Convert.ToDouble(textBox1.Text);
            int centena = Convert.ToInt16(Math.Floor((entrada / 100)));
            int dezena = Convert.ToInt16(Math.Floor((entrada % 100) / 10));
            double unidade = (entrada  % 10) % 10;

            Centena.Text = "Centena: " + centena.ToString();
            Dezena.Text = "Dezena: " + dezena.ToString();
            Unidade.Text = "Unidade: " + unidade.ToString();
        }
    }
}
