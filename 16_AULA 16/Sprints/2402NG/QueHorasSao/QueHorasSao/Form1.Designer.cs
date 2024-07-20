namespace QueHorasSao
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
            label1 = new Label();
            textBoxHoraGa = new TextBox();
            label2 = new Label();
            comboBoxPais = new ComboBox();
            lblPais = new Label();
            btnPretend = new Button();
            lbldados = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 60);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Horas no Brasil";
            // 
            // textBoxHoraGa
            // 
            textBoxHoraGa.Location = new Point(46, 93);
            textBoxHoraGa.Name = "textBoxHoraGa";
            textBoxHoraGa.Size = new Size(109, 27);
            textBoxHoraGa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 154);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Escolha o país:";
            // 
            // comboBoxPais
            // 
            comboBoxPais.FormattingEnabled = true;
            comboBoxPais.Items.AddRange(new object[] { "China", "Russia", "Irã", "Coréia do Norte", "Venezuela" });
            comboBoxPais.Location = new Point(46, 199);
            comboBoxPais.Name = "comboBoxPais";
            comboBoxPais.Size = new Size(109, 28);
            comboBoxPais.TabIndex = 3;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(205, 60);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(96, 20);
            lblPais.TabIndex = 4;
            lblPais.Text = "País em foco:";
            // 
            // btnPretend
            // 
            btnPretend.Location = new Point(46, 272);
            btnPretend.Name = "btnPretend";
            btnPretend.Size = new Size(106, 29);
            btnPretend.TabIndex = 5;
            btnPretend.Text = "Gerar informações";
            btnPretend.UseVisualStyleBackColor = true;
            btnPretend.Click += btnPretend_Click;
            // 
            // lbldados
            // 
            lbldados.AutoSize = true;
            lbldados.Location = new Point(205, 124);
            lbldados.Name = "lbldados";
            lbldados.Size = new Size(92, 20);
            lbldados.TabIndex = 6;
            lbldados.Text = "Aguardando";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(lbldados);
            Controls.Add(btnPretend);
            Controls.Add(lblPais);
            Controls.Add(comboBoxPais);
            Controls.Add(label2);
            Controls.Add(textBoxHoraGa);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Estudo: variáveis de tempo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxHoraGa;
        private Label label2;
        private ComboBox comboBoxPais;
        private Label lblPais;
        private Button btnPretend;
        private Label lbldados;
    }
}
