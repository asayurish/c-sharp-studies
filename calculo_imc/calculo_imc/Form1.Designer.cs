namespace calculo_imc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(70, 180);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(96, 32);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(18, 41);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(224, 18);
            this.lbl_peso.TabIndex = 1;
            this.lbl_peso.Text = "Digite seu peso em quilogramas:";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altura.Location = new System.Drawing.Point(18, 110);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(205, 18);
            this.lbl_altura.TabIndex = 2;
            this.lbl_altura.Text = "Digite a sua altura em metros:";
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imc.Location = new System.Drawing.Point(339, 41);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(42, 20);
            this.lbl_imc.TabIndex = 3;
            this.lbl_imc.Text = "IMC:";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(21, 66);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(202, 20);
            this.txt_peso.TabIndex = 4;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(21, 136);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(202, 20);
            this.txt_altura.TabIndex = 5;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(306, 66);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(170, 20);
            this.txt_resultado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(306, 136);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(226, 20);
            this.txt_categoria.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_categoria;
    }
}

