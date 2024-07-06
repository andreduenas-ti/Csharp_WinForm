namespace IMCexercSala
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
            textBoxDados = new TextBox();
            button1 = new Button();
            lbl_Resultado = new Label();
            label1 = new Label();
            reset = new Button();
            fechar = new Button();
            SuspendLayout();
            // 
            // textBoxDados
            // 
            textBoxDados.Location = new Point(31, 88);
            textBoxDados.Name = "textBoxDados";
            textBoxDados.Size = new Size(227, 27);
            textBoxDados.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(31, 132);
            button1.Name = "button1";
            button1.Size = new Size(227, 29);
            button1.TabIndex = 1;
            button1.Text = "Calcular IMC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Location = new Point(31, 164);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(0, 20);
            lbl_Resultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 66);
            label1.TabIndex = 3;
            label1.Text = "Insira pares de peso e altura. Utilize \",\" para separar peso e altura e \";\" para separar os pares";
            // 
            // reset
            // 
            reset.Location = new Point(31, 222);
            reset.Name = "reset";
            reset.Size = new Size(225, 29);
            reset.TabIndex = 4;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // fechar
            // 
            fechar.Location = new Point(31, 272);
            fechar.Name = "fechar";
            fechar.Size = new Size(225, 29);
            fechar.TabIndex = 5;
            fechar.Text = "Fechar";
            fechar.UseVisualStyleBackColor = true;
            fechar.Click += fechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 355);
            Controls.Add(fechar);
            Controls.Add(reset);
            Controls.Add(label1);
            Controls.Add(lbl_Resultado);
            Controls.Add(button1);
            Controls.Add(textBoxDados);
            Name = "Form1";
            Text = "IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDados;
        private Button button1;
        private Label lbl_Resultado;
        private Label label1;
        private Button reset;
        private Button fechar;
    }
}
