namespace exemplo2_OO
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
            this.lbl_numero1 = new System.Windows.Forms.Label();
            this.lbl_numero2 = new System.Windows.Forms.Label();
            this.lbl_mostrar = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.lbl_mostrarsobrenome = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_sobrenomedigita = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.lbl_mostraridade = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_idadedigitar = new System.Windows.Forms.Label();
            this.txt_professor = new System.Windows.Forms.TextBox();
            this.lbl_mostrarprofessor = new System.Windows.Forms.Label();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.lbl_professordigitar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_numero1
            // 
            this.lbl_numero1.AutoSize = true;
            this.lbl_numero1.Location = new System.Drawing.Point(22, 10);
            this.lbl_numero1.Name = "lbl_numero1";
            this.lbl_numero1.Size = new System.Drawing.Size(75, 13);
            this.lbl_numero1.TabIndex = 0;
            this.lbl_numero1.Text = "Digite o nome:";
            // 
            // lbl_numero2
            // 
            this.lbl_numero2.AutoSize = true;
            this.lbl_numero2.Location = new System.Drawing.Point(9, 87);
            this.lbl_numero2.Name = "lbl_numero2";
            this.lbl_numero2.Size = new System.Drawing.Size(38, 13);
            this.lbl_numero2.TabIndex = 1;
            this.lbl_numero2.Text = "Nome:";
            // 
            // lbl_mostrar
            // 
            this.lbl_mostrar.AutoSize = true;
            this.lbl_mostrar.Location = new System.Drawing.Point(53, 87);
            this.lbl_mostrar.Name = "lbl_mostrar";
            this.lbl_mostrar.Size = new System.Drawing.Size(73, 13);
            this.lbl_mostrar.TabIndex = 2;
            this.lbl_mostrar.Text = "Mostrar Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(150, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(377, 97);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(80, 68);
            this.btn_set.TabIndex = 4;
            this.btn_set.Text = "Armazenar em Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(377, 187);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 45);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar em Get";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(12, 145);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(150, 20);
            this.txt_sobrenome.TabIndex = 9;
            this.txt_sobrenome.TextChanged += new System.EventHandler(this.txt_sobrenome_TextChanged);
            // 
            // lbl_mostrarsobrenome
            // 
            this.lbl_mostrarsobrenome.AutoSize = true;
            this.lbl_mostrarsobrenome.Location = new System.Drawing.Point(67, 200);
            this.lbl_mostrarsobrenome.Name = "lbl_mostrarsobrenome";
            this.lbl_mostrarsobrenome.Size = new System.Drawing.Size(99, 13);
            this.lbl_mostrarsobrenome.TabIndex = 8;
            this.lbl_mostrarsobrenome.Text = "Mostrar Sobrenome";
            this.lbl_mostrarsobrenome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(9, 200);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(64, 13);
            this.lbl_sobrenome.TabIndex = 7;
            this.lbl_sobrenome.Text = "Sobrenome:";
            // 
            // lbl_sobrenomedigita
            // 
            this.lbl_sobrenomedigita.AutoSize = true;
            this.lbl_sobrenomedigita.Location = new System.Drawing.Point(22, 123);
            this.lbl_sobrenomedigita.Name = "lbl_sobrenomedigita";
            this.lbl_sobrenomedigita.Size = new System.Drawing.Size(101, 13);
            this.lbl_sobrenomedigita.TabIndex = 6;
            this.lbl_sobrenomedigita.Text = "Digite o sobrenome:";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(12, 260);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(150, 20);
            this.txt_idade.TabIndex = 13;
            // 
            // lbl_mostraridade
            // 
            this.lbl_mostraridade.AutoSize = true;
            this.lbl_mostraridade.Location = new System.Drawing.Point(53, 315);
            this.lbl_mostraridade.Name = "lbl_mostraridade";
            this.lbl_mostraridade.Size = new System.Drawing.Size(72, 13);
            this.lbl_mostraridade.TabIndex = 12;
            this.lbl_mostraridade.Text = "Mostrar Idade";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(9, 315);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(37, 13);
            this.lbl_idade.TabIndex = 11;
            this.lbl_idade.Text = "Idade:";
            // 
            // lbl_idadedigitar
            // 
            this.lbl_idadedigitar.AutoSize = true;
            this.lbl_idadedigitar.Location = new System.Drawing.Point(22, 238);
            this.lbl_idadedigitar.Name = "lbl_idadedigitar";
            this.lbl_idadedigitar.Size = new System.Drawing.Size(75, 13);
            this.lbl_idadedigitar.TabIndex = 10;
            this.lbl_idadedigitar.Text = "Digite a idade:";
            // 
            // txt_professor
            // 
            this.txt_professor.Location = new System.Drawing.Point(12, 373);
            this.txt_professor.Name = "txt_professor";
            this.txt_professor.Size = new System.Drawing.Size(150, 20);
            this.txt_professor.TabIndex = 17;
            // 
            // lbl_mostrarprofessor
            // 
            this.lbl_mostrarprofessor.AutoSize = true;
            this.lbl_mostrarprofessor.Location = new System.Drawing.Point(67, 428);
            this.lbl_mostrarprofessor.Name = "lbl_mostrarprofessor";
            this.lbl_mostrarprofessor.Size = new System.Drawing.Size(120, 13);
            this.lbl_mostrarprofessor.TabIndex = 16;
            this.lbl_mostrarprofessor.Text = "Mostrar Nome Professor";
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(9, 428);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(54, 13);
            this.lbl_professor.TabIndex = 15;
            this.lbl_professor.Text = "Professor:";
            // 
            // lbl_professordigitar
            // 
            this.lbl_professordigitar.AutoSize = true;
            this.lbl_professordigitar.Location = new System.Drawing.Point(22, 351);
            this.lbl_professordigitar.Name = "lbl_professordigitar";
            this.lbl_professordigitar.Size = new System.Drawing.Size(136, 13);
            this.lbl_professordigitar.TabIndex = 14;
            this.lbl_professordigitar.Text = "Digite o nome do professor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 482);
            this.Controls.Add(this.txt_professor);
            this.Controls.Add(this.lbl_mostrarprofessor);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.lbl_professordigitar);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.lbl_mostraridade);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_idadedigitar);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.lbl_mostrarsobrenome);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_sobrenomedigita);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_mostrar);
            this.Controls.Add(this.lbl_numero2);
            this.Controls.Add(this.lbl_numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero1;
        private System.Windows.Forms.Label lbl_numero2;
        private System.Windows.Forms.Label lbl_mostrar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.Label lbl_mostrarsobrenome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_sobrenomedigita;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label lbl_mostraridade;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_idadedigitar;
        private System.Windows.Forms.TextBox txt_professor;
        private System.Windows.Forms.Label lbl_mostrarprofessor;
        private System.Windows.Forms.Label lbl_professor;
        private System.Windows.Forms.Label lbl_professordigitar;
    }
}

