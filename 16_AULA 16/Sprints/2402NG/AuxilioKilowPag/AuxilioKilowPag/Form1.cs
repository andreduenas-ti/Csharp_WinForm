namespace AuxilioKilowPag
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
                //Receber dados

                double salario = Convert.ToDouble(salarioBox.Text);
                double gasto = Convert.ToDouble(gastoBox.Text);

                //Calculo de preço do quilowatt

                double preco = (salario / 7)/100;
                precoBox.Text = Math.Round(preco, 2) + " reais";

                //Valor a ser pago

                double conta = preco * gasto;
                contaBox.Text = Math.Round(conta, 2) + " reais";

                //Valor a ser pago com desconto de 10%

                double cDesconto = conta * 0.9 ;

                comDescBox.Text = Math.Round(cDesconto, 2) + " reais";
            }
            catch {
                MessageBox.Show("Deu pepino!");
            }
        }
    }
}
