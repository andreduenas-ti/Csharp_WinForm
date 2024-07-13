using System;
using System.Numerics;

namespace TabuadaCoach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int acertos;
        int erros;
        int qual;

        private void corrigir_Click(object sender, EventArgs e)
        {
            try
            {
                qual = Convert.ToInt16(textBoxQual.Text);
                int qual1 = Convert.ToInt16(textBox1.Text);
                int qual2 = Convert.ToInt16(textBox2.Text);
                int qual3 = Convert.ToInt16(textBox3.Text);
                int qual4 = Convert.ToInt16(textBox4.Text);
                int qual5 = Convert.ToInt16(textBox5.Text);
                int qual6 = Convert.ToInt16(textBox6.Text);
                int qual7 = Convert.ToInt16(textBox7.Text);
                int qual8 = Convert.ToInt16(textBox8.Text);
                int qual9 = Convert.ToInt16(textBox9.Text);
                int qual10 = Convert.ToInt16(textBox10.Text);

                // Vezes 1
                if (qual == qual1)
                {
                    label12.Text = "CORRETO";
                    acertos++;
                }
                if (qual != qual1)
                {
                    label12.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + qual;
                    erros++;
                }

                // Vezes 2
                if ((qual * 2) == qual2)
                {
                    label13.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 2) != qual2)
                {
                    label13.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 2);
                    erros++;
                }

                //Vezes 3
                if ((qual * 3) == qual3)
                {
                    label14.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 3) != qual3)
                {
                    label14.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 3);
                    erros++;
                }

                //Vezes 4
                if ((qual * 4) == qual4)
                {
                    label15.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 4) != qual4)
                {
                    label15.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 4);
                    erros++;
                }

                //Vezes 5
                if ((qual * 5) == qual5)
                {
                    label16.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 5) != qual5)
                {
                    label16.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 5);
                    erros++;
                }

                //Vezes 6     
                if ((qual * 6) == qual6)
                {
                    label17.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 6) != qual6)
                {
                    label17.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 6);
                    erros++;
                }

                //Vezes 7
                if ((qual * 7) == qual7)
                {
                    label18.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 7) != qual7)
                {
                    label18.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 7);
                    erros++;
                }

                //Vezes 8
                if ((qual * 8 == qual8))
                {
                    label19.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 8) != qual8)
                {
                    label19.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 8);
                    erros++;
                }


                //Vezes 9
                if ((qual * 9) == qual9)
                {

                    label20.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 9) != qual9)
                {

                    label20.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 9);
                    erros++;
                }

                //Vezes 10
                if ((qual * 10) == qual10)
                {

                    label22.Text = "CORRETO";
                    acertos++;
                }
                if ((qual * 10) != qual10)
                {
                    label22.Text = "QUE PENA, VOCÊ ERROU, O VALOR CORRETO É " + (qual * 10);
                    erros++;
                }

                lblFinal.Text = "Total de acertos: " + acertos + " \nTotal de erros: " + erros + "\nDeseja começar novamente?";

            }
            catch
            {
                MessageBox.Show("Deu ruim na correção");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            try
            {

                acertos = 0;
                erros = 0;
                qual = 0;

                textBoxQual.Text = string.Empty;

                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;
                textBox8.Text = string.Empty;
                textBox9.Text = string.Empty;
                textBox10.Text = string.Empty;

                label12.Text = string.Empty;
                label13.Text = string.Empty;
                label14.Text = string.Empty;
                label15.Text = string.Empty;
                label16.Text = string.Empty;
                label17.Text = string.Empty;
                label18.Text = string.Empty;
                label19.Text = string.Empty;
                label20.Text = string.Empty;
                label22.Text = string.Empty;

                lblFinal.Text = string.Empty;
            }
            catch { MessageBox.Show("Deu ruim na limpeza"); }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
