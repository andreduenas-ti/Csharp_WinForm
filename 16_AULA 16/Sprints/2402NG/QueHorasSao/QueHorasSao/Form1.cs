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

                    lblPais.Text = "Pa�s em foco: China";

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

                    lbldados.Text = Convert.ToString("Agora na China �: " + horaChina + "\nAlcan��vel por MBIC em: " + alcanceC + " horas");
                }
                else if (pais == "Russia")
                {

                    lblPais.Text = "Pa�s em foco: R�ssia";

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

                    lbldados.Text = Convert.ToString("Agora na Russia �: " + horaRussia + "\nAlcan��vel por MBIC em: " + alcanceC + " horas");

                }
                else if (pais == "Ir�")
                {

                    lblPais.Text = "Pa�s em foco: Ir�";

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

                    lbldados.Text = Convert.ToString("Agora no Ir� �: " + horaIra + "\nAlcan��vel por MBIC em: " + alcanceC + " horas");

                }
                else if (pais == "Cor�ia do Norte")
                {

                    lblPais.Text = "Pa�s em foco: Cor�ia do Norte";

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

                    lbldados.Text = Convert.ToString("Agora na Cor�ia do Norte �: " + horaCoreia + "\nAlcan��vel por MBIC em: " + alcanceC + " horas");

                }
                else if (pais == "Venezuela")
                {

                    lblPais.Text = "Pa�s em foco: Venezuela";


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

                    lbldados.Text = Convert.ToString("Agora na Venezuela �: " + horaVenezuela + "\nAlcan��vel por MBIC em: " + alcanceC + " horas");

                }
            }
            catch
            {


                MessageBox.Show("Deu ruim!");


            }
        }
    }
}
