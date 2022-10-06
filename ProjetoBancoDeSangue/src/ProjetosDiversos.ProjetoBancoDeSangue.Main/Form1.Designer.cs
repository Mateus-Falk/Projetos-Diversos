namespace ProjetosDiversos.ProjetoBancoDeSangue.Main
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
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnDoar = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbTipoSanguineo = new System.Windows.Forms.GroupBox();
            this.rbBp = new System.Windows.Forms.RadioButton();
            this.rbAn = new System.Windows.Forms.RadioButton();
            this.rbBn = new System.Windows.Forms.RadioButton();
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.rbOp = new System.Windows.Forms.RadioButton();
            this.rbABp = new System.Windows.Forms.RadioButton();
            this.rbABn = new System.Windows.Forms.RadioButton();
            this.rbAp = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.gbPaciente.SuspendLayout();
            this.gbTipoSanguineo.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaciente
            // 
            this.gbPaciente.BackColor = System.Drawing.Color.Yellow;
            this.gbPaciente.Controls.Add(this.label3);
            this.gbPaciente.Controls.Add(this.txtQuantidade);
            this.gbPaciente.Controls.Add(this.btnEstoque);
            this.gbPaciente.Controls.Add(this.btnLimpar);
            this.gbPaciente.Controls.Add(this.btnRetirar);
            this.gbPaciente.Controls.Add(this.btnDoar);
            this.gbPaciente.Controls.Add(this.txtIdade);
            this.gbPaciente.Controls.Add(this.txtNome);
            this.gbPaciente.Controls.Add(this.gbTipoSanguineo);
            this.gbPaciente.Controls.Add(this.label2);
            this.gbPaciente.Controls.Add(this.label1);
            this.gbPaciente.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaciente.Location = new System.Drawing.Point(40, 31);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(345, 387);
            this.gbPaciente.TabIndex = 0;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Cadastro de Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtQuantidade.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(238, 334);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(86, 33);
            this.txtQuantidade.TabIndex = 9;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEstoque.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstoque.Location = new System.Drawing.Point(232, 291);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(92, 37);
            this.btnEstoque.TabIndex = 8;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(126, 291);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 37);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRetirar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRetirar.Location = new System.Drawing.Point(20, 334);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(100, 37);
            this.btnRetirar.TabIndex = 6;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnDoar
            // 
            this.btnDoar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDoar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDoar.Location = new System.Drawing.Point(20, 291);
            this.btnDoar.Name = "btnDoar";
            this.btnDoar.Size = new System.Drawing.Size(100, 37);
            this.btnDoar.TabIndex = 5;
            this.btnDoar.Text = "Doar";
            this.btnDoar.UseVisualStyleBackColor = false;
            this.btnDoar.Click += new System.EventHandler(this.btnDoar_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtIdade.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(79, 82);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(245, 33);
            this.txtIdade.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNome.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(245, 33);
            this.txtNome.TabIndex = 3;
            // 
            // gbTipoSanguineo
            // 
            this.gbTipoSanguineo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbTipoSanguineo.Controls.Add(this.rbBp);
            this.gbTipoSanguineo.Controls.Add(this.rbAn);
            this.gbTipoSanguineo.Controls.Add(this.rbBn);
            this.gbTipoSanguineo.Controls.Add(this.rbOn);
            this.gbTipoSanguineo.Controls.Add(this.rbOp);
            this.gbTipoSanguineo.Controls.Add(this.rbABp);
            this.gbTipoSanguineo.Controls.Add(this.rbABn);
            this.gbTipoSanguineo.Controls.Add(this.rbAp);
            this.gbTipoSanguineo.Location = new System.Drawing.Point(20, 124);
            this.gbTipoSanguineo.Name = "gbTipoSanguineo";
            this.gbTipoSanguineo.Size = new System.Drawing.Size(304, 160);
            this.gbTipoSanguineo.TabIndex = 2;
            this.gbTipoSanguineo.TabStop = false;
            this.gbTipoSanguineo.Text = "Tipo Sanguineo";
            // 
            // rbBp
            // 
            this.rbBp.AutoSize = true;
            this.rbBp.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBp.Location = new System.Drawing.Point(17, 94);
            this.rbBp.Name = "rbBp";
            this.rbBp.Size = new System.Drawing.Size(43, 21);
            this.rbBp.TabIndex = 7;
            this.rbBp.TabStop = true;
            this.rbBp.Text = "B+";
            this.rbBp.UseVisualStyleBackColor = true;
            // 
            // rbAn
            // 
            this.rbAn.AutoSize = true;
            this.rbAn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAn.Location = new System.Drawing.Point(17, 67);
            this.rbAn.Name = "rbAn";
            this.rbAn.Size = new System.Drawing.Size(43, 21);
            this.rbAn.TabIndex = 6;
            this.rbAn.TabStop = true;
            this.rbAn.Text = "A-";
            this.rbAn.UseVisualStyleBackColor = true;
            // 
            // rbBn
            // 
            this.rbBn.AutoSize = true;
            this.rbBn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBn.Location = new System.Drawing.Point(17, 121);
            this.rbBn.Name = "rbBn";
            this.rbBn.Size = new System.Drawing.Size(42, 21);
            this.rbBn.TabIndex = 5;
            this.rbBn.TabStop = true;
            this.rbBn.Text = "B-";
            this.rbBn.UseVisualStyleBackColor = true;
            // 
            // rbOn
            // 
            this.rbOn.AutoSize = true;
            this.rbOn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOn.Location = new System.Drawing.Point(153, 121);
            this.rbOn.Name = "rbOn";
            this.rbOn.Size = new System.Drawing.Size(43, 21);
            this.rbOn.TabIndex = 4;
            this.rbOn.TabStop = true;
            this.rbOn.Text = "O-";
            this.rbOn.UseVisualStyleBackColor = true;
            // 
            // rbOp
            // 
            this.rbOp.AutoSize = true;
            this.rbOp.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOp.Location = new System.Drawing.Point(153, 97);
            this.rbOp.Name = "rbOp";
            this.rbOp.Size = new System.Drawing.Size(44, 21);
            this.rbOp.TabIndex = 3;
            this.rbOp.TabStop = true;
            this.rbOp.Text = "O+";
            this.rbOp.UseVisualStyleBackColor = true;
            // 
            // rbABp
            // 
            this.rbABp.AutoSize = true;
            this.rbABp.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbABp.Location = new System.Drawing.Point(153, 43);
            this.rbABp.Name = "rbABp";
            this.rbABp.Size = new System.Drawing.Size(53, 21);
            this.rbABp.TabIndex = 2;
            this.rbABp.TabStop = true;
            this.rbABp.Text = "AB+";
            this.rbABp.UseVisualStyleBackColor = true;
            // 
            // rbABn
            // 
            this.rbABn.AutoSize = true;
            this.rbABn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbABn.Location = new System.Drawing.Point(153, 70);
            this.rbABn.Name = "rbABn";
            this.rbABn.Size = new System.Drawing.Size(52, 21);
            this.rbABn.TabIndex = 1;
            this.rbABn.TabStop = true;
            this.rbABn.Text = "AB-";
            this.rbABn.UseVisualStyleBackColor = true;
            // 
            // rbAp
            // 
            this.rbAp.AutoSize = true;
            this.rbAp.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAp.Location = new System.Drawing.Point(17, 41);
            this.rbAp.Name = "rbAp";
            this.rbAp.Size = new System.Drawing.Size(44, 21);
            this.rbAp.TabIndex = 0;
            this.rbAp.TabStop = true;
            this.rbAp.Text = "A+";
            this.rbAp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.BackColor = System.Drawing.Color.Yellow;
            this.gbInformacoes.Controls.Add(this.txtConsole);
            this.gbInformacoes.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacoes.Location = new System.Drawing.Point(420, 31);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(345, 387);
            this.gbInformacoes.TabIndex = 1;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtConsole.Location = new System.Drawing.Point(31, 38);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(287, 333);
            this.txtConsole.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.gbPaciente);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Sistema Hemosc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbTipoSanguineo.ResumeLayout(false);
            this.gbTipoSanguineo.PerformLayout();
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnDoar;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbTipoSanguineo;
        private System.Windows.Forms.RadioButton rbBp;
        private System.Windows.Forms.RadioButton rbAn;
        private System.Windows.Forms.RadioButton rbBn;
        private System.Windows.Forms.RadioButton rbOn;
        private System.Windows.Forms.RadioButton rbOp;
        private System.Windows.Forms.RadioButton rbABp;
        private System.Windows.Forms.RadioButton rbABn;
        private System.Windows.Forms.RadioButton rbAp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}

