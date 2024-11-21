
namespace GUI
{
    partial class lblNome
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(77, 14);
            this.txtCID.MaxLength = 6;
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(136, 23);
            this.txtCID.TabIndex = 1;
            this.txtCID.TextChanged += new System.EventHandler(this.txtCID_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 49);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(510, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(43, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Nome:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(77, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Criar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(77, 197);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.RowTemplate.Height = 25;
            this.gridClientes.Size = new System.Drawing.Size(510, 235);
            this.gridClientes.TabIndex = 7;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(252, 14);
            this.txtTipo.MaxLength = 100;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(335, 23);
            this.txtTipo.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(219, 17);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 15);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(77, 87);
            this.txtSintomas.MaxLength = 350;
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(510, 71);
            this.txtSintomas.TabIndex = 10;
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(12, 90);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(59, 15);
            this.lblSintomas.TabIndex = 11;
            this.lblSintomas.Text = "Sintomas:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(512, 168);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "* Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(368, 168);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseMnemonic = false;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(219, 168);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 14;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "*Para deletar registros utilize apenas o nome da doença.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.label1);
            this.Name = "lblNome";
            this.Text = "Cadastro Internacional de Doenças";
            this.Load += new System.EventHandler(this.lblNome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label2;
    }
}

