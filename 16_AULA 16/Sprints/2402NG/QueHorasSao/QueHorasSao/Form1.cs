using System.Security.Cryptography.X509Certificates;

namespace QueHorasSao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPretend_Click(object sender, EventArgs e)
        {

            var horaBrasil = Convert.ToDateTime(textBoxHoraGa.Text);

            string pais = Convert.ToString(comboBoxPais.Text);


            try
            {
                if (pais == "China")
                {

                    lblPais.Text = "País em foco: China";

                    var gmtChina = new TimeSpan(11, 0, 0);

                    var horaChina = horaBrasil + gmtChina;


                    //Em km/h
                    double velocidadeMi = 24140;


                    // Em Km
                    double distanciaChina = 17000;

                    // Em horas
                    double alcanceA = (distanciaChina / velocidadeMi);

                    //Arredondamento

                    double alcanceB = Math.Round(alcanceA, 8);
                    // Convertendo para horas

                    var alcanceC = TimeSpan.FromHours(alcanceB);

                    lbldados.Text = Convert.ToString("Agora na China é: " + horaChina + "\nAlcançável por MBIC em: " + alcanceC + " horas");
                }
                else if (pais == "Russia")
                {

                    lblPais.Text = "País em foco: Rússia";

                    var gmtRussia = new TimeSpan(6, 0, 0);

                    var horaRussia = horaBrasil + gmtRussia;


                    //Em km/h
                    double velocidadeMi = 24140;


                    // Em Km
                    double distanciaRussia = 13911;

                    // Em horas
                    double alcanceA = (distanciaRussia / velocidadeMi);

                    //Arredondamento

                    double alcanceB = Math.Round(alcanceA, 8);
                    // Convertendo para horas

                    var alcanceC = TimeSpan.FromHours(alcanceB);

                    lbldados.Text = Convert.ToString("Agora na Russia é: " + horaRussia + "\nAlcançável por MBIC em: " + alcanceC + " horas");

                }
                else if (pais == "Irã")
                {

                    lblPais.Text = "País em foco: Irã";

                    var gmtIra = new TimeSpan((Convert.ToInt16(6.5)), 0, 0);

                    var horaIra = horaBrasil + gmtIra;


                    //Em km/h
                    double velocidadeMi = 24140;


                    // Em Km
                    double distanciaIra = 12365;

                    // Em horas
                    double alcanceA = (distanciaIra / velocidadeMi);

                    //Arredondamento

                    double alcanceB = Math.Round(alcanceA, 8);
                    // Convertendo para horas

                    var alcanceC = TimeSpan.FromHours(alcanceB);

                    lbldados.Text = Convert.ToString("Agora no Irã é: " + horaIra + "\nAlcançável por MBIC em: " + alcanceC + " horas");

                }
                else if (pais == "Coréia do Norte")
                {

                    lblPais.Text = "País em foco: Coréia do Norte";

                    var gmtCoreia = new TimeSpan(12, 0, 0);

                    var horaCoreia = horaBrasil + gmtCoreia;


                    //Em km/h
                    double velocidadeMi = 24140;


                    // Em Km
                    double distanciaCoreia = 17629;

                    // Em horas
                    double alcanceA = (distanciaCoreia / velocidadeMi);

                    //Arredondamento

                    double alcanceB = Math.Round(alcanceA, 8);
                    // Convertendo para horas

                    var alcanceC = TimeSpan.FromHours(alcanceB);

                    lbldados.Text = Convert.ToString("Agora na Coréia do Norte é: " + horaCoreia + "\nAlcançável por MBIC em: " + alcanceC + " horas");

                }
                else if (pais == "Venezuela")
                {

                    lblPais.Text = "País em foco: Venezuela";


                    var gmtVenezuela = new TimeSpan((-1), 0, 0);

                    var horaVenezuela = horaBrasil + gmtVenezuela;


                    //Em km/h
                    double velocidadeMi = 24140;


                    // Em Km
                    double distanciaVenezuela = 3578;

                    // Em horas
                    double alcanceA = (distanciaVenezuela / velocidadeMi);

                    //Arredondamento

                    double alcanceB = Math.Round(alcanceA, 8);
                    // Convertendo para horas

                    var alcanceC = TimeSpan.FromHours(alcanceB);

                    lbldados.Text = Convert.ToString("Agora na Venezuela é: " + horaVenezuela + "\nAlcançável por MBIC em: " + alcanceC + " horas");

                }
            }
            catch
            {


                MessageBox.Show("Deu ruim!");


            }
        }
    }
}
