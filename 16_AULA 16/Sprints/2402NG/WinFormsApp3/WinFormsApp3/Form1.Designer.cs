namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labelResultado = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            labelMedia = new Label();
            labelPonderada = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 237);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 0;
            button1.Text = "Calcular média";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 370);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 0;
            button2.Text = "Resetar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 405);
            button3.Name = "button3";
            button3.Size = new Size(169, 29);
            button3.TabIndex = 0;
            button3.Text = "Sair do programa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(22, 336);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(75, 20);
            labelResultado.TabIndex = 1;
            labelResultado.Text = "Resultado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 197);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(50, 27);
            textBox5.TabIndex = 2;
            // 
            // labelMedia
            // 
            labelMedia.AutoSize = true;
            labelMedia.Location = new Point(22, 278);
            labelMedia.Name = "labelMedia";
            labelMedia.Size = new Size(51, 20);
            labelMedia.TabIndex = 3;
            labelMedia.Text = "Média";
            // 
            // labelPonderada
            // 
            labelPonderada.AutoSize = true;
            labelPonderada.Location = new Point(22, 307);
            labelPonderada.Name = "labelPonderada";
            labelPonderada.Size = new Size(126, 20);
            labelPonderada.TabIndex = 4;
            labelPonderada.Text = "Média Ponderada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 5;
            label1.Text = "Insira as cinco notas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 450);
            Controls.Add(label1);
            Controls.Add(labelPonderada);
            Controls.Add(labelMedia);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelResultado);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label labelResultado;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label labelMedia;
        private Label labelPonderada;
        private Label label1;
    }
}
