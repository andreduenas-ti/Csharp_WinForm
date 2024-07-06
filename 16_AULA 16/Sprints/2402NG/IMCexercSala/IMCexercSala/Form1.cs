namespace IMCexercSala
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
                string[] pares = textBoxDados.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string resultados = "";


                for (int i = 0; i < pares.Length; i++)
                {
                    string[] valores = pares[i].Split(',');
                    if (valores.Length != 2)
                    {
                        MessageBox.Show("Por favor, insira pares de peso e altura válidos");
                        return;


                    }
                    double peso = Convert.ToDouble(valores[0]);
                    double altura = Convert.ToDouble(valores[1]);

                    double imc = (peso / (altura * altura) * 10000);

                    // Categoria

                    string categoria = "";

                    if (imc <= 18.5)
                    {

                        categoria = "Abaixo do peso";
                    }
                    else if (imc > 18.5 && imc <= 24.9)
                    {
                        categoria = "Peso normal";
                    }
                    else if (imc > 24.9 && imc <= 29.9)
                    {
                        categoria = "Sobrepeso";
                    }
                    else if (imc > 29.9 && imc <= 34.9)
                    {
                        categoria = "Obesidade grau I";
                    }
                    else if (imc > 34.9 && imc <= 39.9)
                    {
                        categoria = "Obesidade grau II";
                    }
                    else
                    {
                        categoria = "Obesidade grau III";
                    }

                    resultados += $"Par {i + 1}: IMC = {imc:F2} Categoria = {categoria}\n";
                }


                lbl_Resultado.Text = "Resultado do IMC: \n" + resultados;
                MessageBox.Show(resultados, "Resultado do IMC: ");
            }


            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para a altura");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxDados.Text = null;
                lbl_Resultado.Text = null;
            }
            catch
            {
                MessageBox.Show("Deu pepino!");
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch {
                MessageBox.Show("Deu pepino!");
            }
        }
    }
}
