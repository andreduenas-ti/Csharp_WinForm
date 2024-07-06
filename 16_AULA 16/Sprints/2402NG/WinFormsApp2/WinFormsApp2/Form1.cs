using System.Linq.Expressions;

namespace WinFormsApp2
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
                //Capturar os valores dos TextBox
                double valor1 = Convert.ToDouble(textBox1.Text);
                double valor2 = Convert.ToDouble(textBox2.Text);
                double resultado = 0;

                //Capturar a operação no ComboBox
                string operacao = comboBox1.SelectedItem.ToString();

                //Realizar a operação
                switch (operacao)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        ;
                        resultado = valor1 - valor2;
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        break;
                    case "^":
                        resultado = (Convert.ToInt16(valor1) ^ Convert.ToInt16(valor2));
                        break;
                    case "/":
                        if (valor1 != 0) //Operador lógico
                            resultado = valor1 / valor2;

                        else
                            MessageBox.Show("Divisão por 0 não é permitida.");
                        break;

                }
                //resultado no label

                label1.Text = "Resultado: " + resultado.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Deu pepino.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Math.PI.ToString();
        }
    }
}

