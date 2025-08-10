namespace exemplo03_heranca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_armazenar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cartao = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(63, 39);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(63, 91);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(100, 20);
            this.txt_cartao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cartão";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(63, 65);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(100, 20);
            this.txt_rg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // btn_armazenar
            // 
            this.btn_armazenar.Location = new System.Drawing.Point(225, 52);
            this.btn_armazenar.Name = "btn_armazenar";
            this.btn_armazenar.Size = new System.Drawing.Size(103, 45);
            this.btn_armazenar.TabIndex = 6;
            this.btn_armazenar.Text = "Armazenar e Demonstrar";
            this.btn_armazenar.UseVisualStyleBackColor = true;
            this.btn_armazenar.Click += new System.EventHandler(this.btn_armazenar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(75, 160);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 13);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "lbl_nome";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(75, 189);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(32, 13);
            this.lbl_rg.TabIndex = 10;
            this.lbl_rg.Text = "lbl_rg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "RG:";
            // 
            // lbl_cartao
            // 
            this.lbl_cartao.AutoSize = true;
            this.lbl_cartao.Location = new System.Drawing.Point(75, 223);
            this.lbl_cartao.Name = "lbl_cartao";
            this.lbl_cartao.Size = new System.Drawing.Size(53, 13);
            this.lbl_cartao.TabIndex = 12;
            this.lbl_cartao.Text = "lbl_cartao";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cartão:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.lbl_cartao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_armazenar);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_armazenar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cartao;
        private System.Windows.Forms.Label label9;
    }
}

