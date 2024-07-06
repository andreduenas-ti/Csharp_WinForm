namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // o texto do label será alterado
            // todo toque será respeitado
            //label1.Text = "Olá, " + textBox1.Text + " ! Seja Bem-vindo(a) ao C# :)";

            label1.Text = "Seu nome é: "+ textBox1.Text + " " + textBox2.Text;   
        }
    }
}
