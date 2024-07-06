namespace IMCcalc
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
            pesoBox = new TextBox();
            label2 = new Label();
            alturaBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            imcBox = new TextBox();
            label4 = new Label();
            grauImcBox = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira seu peso em kg";
            // 
            // pesoBox
            // 
            pesoBox.Location = new Point(29, 54);
            pesoBox.Name = "pesoBox";
            pesoBox.Size = new Size(243, 27);
            pesoBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 93);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 2;
            label2.Text = "Insira sua altura em metros";
            // 
            // alturaBox
            // 
            alturaBox.Location = new Point(29, 116);
            alturaBox.Name = "alturaBox";
            alturaBox.Size = new Size(243, 27);
            alturaBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(29, 159);
            button1.Name = "button1";
            button1.Size = new Size(243, 29);
            button1.TabIndex = 4;
            button1.Text = "Calcular IMC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 211);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = "IMC";
            // 
            // imcBox
            // 
            imcBox.Location = new Point(70, 208);
            imcBox.Name = "imcBox";
            imcBox.Size = new Size(202, 27);
            imcBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 255);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 7;
            label4.Text = "Classificação";
            // 
            // grauImcBox
            // 
            grauImcBox.Location = new Point(29, 278);
            grauImcBox.Name = "grauImcBox";
            grauImcBox.Size = new Size(243, 27);
            grauImcBox.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(29, 356);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 9;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(151, 356);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 10;
            button3.Text = "Fechar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 398);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(grauImcBox);
            Controls.Add(label4);
            Controls.Add(imcBox);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(alturaBox);
            Controls.Add(label2);
            Controls.Add(pesoBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora de IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox pesoBox;
        private Label label2;
        private TextBox alturaBox;
        private Button button1;
        private Label label3;
        private TextBox imcBox;
        private Label label4;
        private TextBox grauImcBox;
        private Button button2;
        private Button button3;
    }
}
