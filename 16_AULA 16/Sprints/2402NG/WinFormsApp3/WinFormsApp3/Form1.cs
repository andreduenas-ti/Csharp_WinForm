namespace WinFormsApp3
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
                //Conversão dos valores dos TextBoxes
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);
                double nota4 = Convert.ToDouble(textBox4.Text);
                double nota5 = Convert.ToDouble(textBox5.Text);

                //Calcular média
                double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                //Calcular média ponderada
                double ponderada = ((nota1*0.1) + (nota2*0.2) + (nota3*0.4) + (nota4*0.2) + (nota5*0.1)) / 1;
                
                //Aprovado ou Reprovado

                if (media >= 7)
                {
                    labelResultado.Text = "Aprovado";
                    MessageBox.Show("O aluno está aprovado");
                }
                else
                {
                    labelResultado.Text = "Reprovado";
                    MessageBox.Show("O aluno está reprovado");
                }
                labelMedia.Text = "Média: " + media;
                labelPonderada.Text = "Média ponderada: " + Math.Round(ponderada, 2);

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Resetar TestBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            labelResultado.Text = "Resultado";
            labelMedia.Text = "Média:";
            labelPonderada.Text = "Média ponderada:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sair
            Application.Exit();
        }
    }
}
