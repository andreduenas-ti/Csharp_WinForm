namespace AuxilioKilowPag
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
            salarioBox = new TextBox();
            label2 = new Label();
            gastoBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            precoBox = new TextBox();
            label4 = new Label();
            contaBox = new TextBox();
            label5 = new Label();
            comDescBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Salário Mínimo";
            // 
            // salarioBox
            // 
            salarioBox.Location = new Point(18, 55);
            salarioBox.Name = "salarioBox";
            salarioBox.Size = new Size(142, 27);
            salarioBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 99);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Energia consumida";
            // 
            // gastoBox
            // 
            gastoBox.Location = new Point(18, 122);
            gastoBox.Name = "gastoBox";
            gastoBox.Size = new Size(142, 27);
            gastoBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(18, 168);
            button1.Name = "button1";
            button1.Size = new Size(142, 55);
            button1.TabIndex = 4;
            button1.Text = "Calcular valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 32);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 5;
            label3.Text = "Preço do quilowatt";
            // 
            // precoBox
            // 
            precoBox.Location = new Point(274, 55);
            precoBox.Name = "precoBox";
            precoBox.Size = new Size(142, 27);
            precoBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 85);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 7;
            label4.Text = "Valor a ser pago";
            // 
            // contaBox
            // 
            contaBox.Location = new Point(274, 108);
            contaBox.Name = "contaBox";
            contaBox.Size = new Size(142, 27);
            contaBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 138);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 9;
            label5.Text = "Valor com desconto";
            // 
            // comDescBox
            // 
            comDescBox.Location = new Point(274, 161);
            comDescBox.Name = "comDescBox";
            comDescBox.Size = new Size(142, 27);
            comDescBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comDescBox);
            Controls.Add(label5);
            Controls.Add(contaBox);
            Controls.Add(label4);
            Controls.Add(precoBox);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(gastoBox);
            Controls.Add(label2);
            Controls.Add(salarioBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox salarioBox;
        private Label label2;
        private TextBox gastoBox;
        private Button button1;
        private Label label3;
        private TextBox precoBox;
        private Label label4;
        private TextBox contaBox;
        private Label label5;
        private TextBox comDescBox;
    }
}
