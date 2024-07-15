namespace AreaCalc
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
            comboBoxAreaDe = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxRaio = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxBase = new TextBox();
            textBoxAltura = new TextBox();
            label5 = new Label();
            lblResultado = new Label();
            btnCalcular = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBoxAreaDe
            // 
            comboBoxAreaDe.FormattingEnabled = true;
            comboBoxAreaDe.Items.AddRange(new object[] { "Círculo", "Triângulo", "Quadrado" });
            comboBoxAreaDe.Location = new Point(175, 30);
            comboBoxAreaDe.Name = "comboBoxAreaDe";
            comboBoxAreaDe.Size = new Size(151, 28);
            comboBoxAreaDe.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Calcule a área do: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Raio: ";
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(175, 84);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(151, 27);
            textBoxRaio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 128);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Base:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 177);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 5;
            label4.Text = "Altura:";
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(175, 128);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(151, 27);
            textBoxBase.TabIndex = 6;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(175, 174);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(151, 27);
            textBoxAltura.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 289);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 8;
            label5.Text = "Resultado: ";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(175, 289);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(39, 226);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(287, 29);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 335);
            button1.Name = "button1";
            button1.Size = new Size(287, 29);
            button1.TabIndex = 11;
            button1.Text = "Limpar campos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 400);
            button2.Name = "button2";
            button2.Size = new Size(287, 29);
            button2.TabIndex = 12;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(label5);
            Controls.Add(textBoxAltura);
            Controls.Add(textBoxBase);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxRaio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxAreaDe);
            Name = "Form1";
            Text = "Calculadora de Áreas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAreaDe;
        private Label label1;
        private Label label2;
        private TextBox textBoxRaio;
        private Label label3;
        private Label label4;
        private TextBox textBoxBase;
        private TextBox textBoxAltura;
        private Label label5;
        private Label lblResultado;
        private Button btnCalcular;
        private Button button1;
        private Button button2;
    }
}
