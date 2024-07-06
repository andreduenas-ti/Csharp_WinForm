namespace Centena_Dezena_Unidade
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
            textBox1 = new TextBox();
            button1 = new Button();
            Centena = new Label();
            Dezena = new Label();
            Unidade = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira um numero abaixo do milhar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 65);
            button1.Name = "button1";
            button1.Size = new Size(241, 29);
            button1.TabIndex = 2;
            button1.Text = "Separar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Centena
            // 
            Centena.AutoSize = true;
            Centena.Location = new Point(9, 104);
            Centena.Name = "Centena";
            Centena.Size = new Size(0, 20);
            Centena.TabIndex = 3;
            // 
            // Dezena
            // 
            Dezena.AutoSize = true;
            Dezena.Location = new Point(9, 124);
            Dezena.Name = "Dezena";
            Dezena.Size = new Size(0, 20);
            Dezena.TabIndex = 4;
            // 
            // Unidade
            // 
            Unidade.AutoSize = true;
            Unidade.Location = new Point(9, 142);
            Unidade.Name = "Unidade";
            Unidade.Size = new Size(0, 20);
            Unidade.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 181);
            Controls.Add(Unidade);
            Controls.Add(Dezena);
            Controls.Add(Centena);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label Centena;
        private Label Dezena;
        private Label Unidade;
    }
}
