namespace IMCcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Recepciona os dados

                double massa = Convert.ToDouble(pesoBox.Text);
                double altura = Convert.ToDouble(alturaBox.Text);

                // Calculo do IMC

                double imc = (massa) / (altura * altura);

                // Apresentando IMC

                imcBox.Text = Math.Round(imc, 2).ToString();

                // Classificação de obesidade

                if (imc < 18.5)
                {
                    grauImcBox.Text = "Baixo peso.";

                }
                if (imc >= 18.5 && imc < 24.9)
                {

                    grauImcBox.Text = "Peso normal";

                }
                if (imc >= 25 && imc < 29.9)
                {

                    grauImcBox.Text = "Sobrepeso";

                }
                if (imc >= 30 && imc < 34.9)
                {
                    grauImcBox.Text = "Obesidade grau I";
                }
                if (imc >= 35 && imc < 39.9)
                {
                    grauImcBox.Text = "Obesidade grau II";

                }
                else
                {
                    grauImcBox.Text = "Obesidade grau III";
                }


            }


            catch
            {
                MessageBox.Show("Deu pepino!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesoBox.Text = null;
            alturaBox.Text = null;
            imcBox.Text = null;
            grauImcBox.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
