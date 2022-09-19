namespace ExercicioAvaliacao
{
    partial class Telefones
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdTelefone = new System.Windows.Forms.TextBox();
            this.txtNomeProprietario = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwTelefones = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTelefones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DDD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operadora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // txtIdTelefone
            // 
            this.txtIdTelefone.Enabled = false;
            this.txtIdTelefone.Location = new System.Drawing.Point(136, 21);
            this.txtIdTelefone.Name = "txtIdTelefone";
            this.txtIdTelefone.Size = new System.Drawing.Size(57, 20);
            this.txtIdTelefone.TabIndex = 5;
            // 
            // txtNomeProprietario
            // 
            this.txtNomeProprietario.Location = new System.Drawing.Point(136, 57);
            this.txtNomeProprietario.Name = "txtNomeProprietario";
            this.txtNomeProprietario.Size = new System.Drawing.Size(287, 20);
            this.txtNomeProprietario.TabIndex = 6;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(136, 135);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(57, 20);
            this.txtDDD.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(278, 135);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // cmbOperadora
            // 
            this.cmbOperadora.FormattingEnabled = true;
            this.cmbOperadora.Location = new System.Drawing.Point(136, 95);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(159, 21);
            this.cmbOperadora.TabIndex = 10;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(0, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(116, 38);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(136, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(116, 38);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(275, 0);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(116, 38);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Location = new System.Drawing.Point(32, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 47);
            this.panel1.TabIndex = 12;
            // 
            // dgwTelefones
            // 
            this.dgwTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTelefones.Location = new System.Drawing.Point(32, 257);
            this.dgwTelefones.Name = "dgwTelefones";
            this.dgwTelefones.Size = new System.Drawing.Size(391, 150);
            this.dgwTelefones.TabIndex = 13;
            // 
            // Telefones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.dgwTelefones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbOperadora);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtNomeProprietario);
            this.Controls.Add(this.txtIdTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Telefones";
            this.Text = "Telefones";
            this.Load += new System.EventHandler(this.Telefones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTelefones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdTelefone;
        private System.Windows.Forms.TextBox txtNomeProprietario;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwTelefones;
    }
}