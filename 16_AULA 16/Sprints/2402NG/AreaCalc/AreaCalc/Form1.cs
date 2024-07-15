using System.Security.Cryptography.X509Certificates;

namespace AreaCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {


                string poligono = comboBoxAreaDe.Text;



                switch (poligono)
                {
                    case "C�rculo":
                        areaCirculo();
                        break;


                    case "Tri�ngulo":
                        areaTriangulo();
                        break;


                    case "Quadrado":
                        areaQuadrado();
                        break;
                        {

                        }
                }



            }
            catch
            { MessageBox.Show("Problema no switch case!"); }

            //�rea do c�rculo

            void areaCirculo()
            {
                try
                {
                    double raio = Convert.ToDouble(textBoxRaio.Text);

                    double circulo = Math.Round((raio * raio * Math.PI), 2);

                    lblResultado.Text = circulo.ToString();
                }
                catch
                {
                    MessageBox.Show("Problema na fun��o do c�rculo.");
                }
            }


            //�rea do tri�ngulo


            void areaTriangulo()
            {

                try
                {

                    double baseT = Convert.ToDouble(textBoxBase.Text);

                    double alturaT = Convert.ToDouble(textBoxAltura.Text);

                    double triangulo = Math.Round(((baseT * alturaT) / 2), 2);

                    lblResultado.Text = triangulo.ToString();
                }
                catch
                {
                    MessageBox.Show("Problema na fun��o do tri�ngulo.");
                }
            }



            //�rea do quadrado

            void areaQuadrado()
            {
                try
                {
                    double baseQ = Convert.ToDouble(textBoxBase.Text);

                    double alturaQ = Convert.ToDouble(textBoxAltura.Text);

                    double quadrado = Math.Round((baseQ * alturaQ), 2);

                    lblResultado.Text = quadrado.ToString();
                }
                catch
                {
                    MessageBox.Show("Problema na fun��o do quadrado.");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxAltura.Text = string.Empty;
                textBoxBase.Text = string.Empty;
                textBoxRaio.Text = string.Empty;
                lblResultado.Text = string.Empty;
                comboBoxAreaDe.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Problema na limpeza");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
