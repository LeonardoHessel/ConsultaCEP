
namespace ConsultaCEP
{
    partial class FrmConsultaCEPs
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.labEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.labRua = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCEP
            // 
            this.labCEP.AutoSize = true;
            this.labCEP.Location = new System.Drawing.Point(16, 15);
            this.labCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCEP.Name = "labCEP";
            this.labCEP.Size = new System.Drawing.Size(38, 16);
            this.labCEP.TabIndex = 0;
            this.labCEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Info;
            this.txtCEP.Location = new System.Drawing.Point(16, 34);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(205, 22);
            this.txtCEP.TabIndex = 1;
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.txtRua);
            this.gbxResultado.Controls.Add(this.labRua);
            this.gbxResultado.Controls.Add(this.txtBairro);
            this.gbxResultado.Controls.Add(this.labBairro);
            this.gbxResultado.Controls.Add(this.txtCidade);
            this.gbxResultado.Controls.Add(this.labCidade);
            this.gbxResultado.Controls.Add(this.txtEstado);
            this.gbxResultado.Controls.Add(this.labEstado);
            this.gbxResultado.Location = new System.Drawing.Point(16, 73);
            this.gbxResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxResultado.Size = new System.Drawing.Size(496, 230);
            this.gbxResultado.TabIndex = 2;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = global::ConsultaCEP.Properties.Resources.busca_cep;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultar.Location = new System.Drawing.Point(304, 15);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(208, 59);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.Location = new System.Drawing.Point(21, 46);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(456, 22);
            this.txtEstado.TabIndex = 3;
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Location = new System.Drawing.Point(21, 26);
            this.labEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(54, 16);
            this.labEstado.TabIndex = 2;
            this.labEstado.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCidade.Location = new System.Drawing.Point(21, 94);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(456, 22);
            this.txtCidade.TabIndex = 5;
            // 
            // labCidade
            // 
            this.labCidade.AutoSize = true;
            this.labCidade.Location = new System.Drawing.Point(21, 74);
            this.labCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCidade.Name = "labCidade";
            this.labCidade.Size = new System.Drawing.Size(55, 16);
            this.labCidade.TabIndex = 4;
            this.labCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBairro.Location = new System.Drawing.Point(21, 142);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(456, 22);
            this.txtBairro.TabIndex = 7;
            // 
            // labBairro
            // 
            this.labBairro.AutoSize = true;
            this.labBairro.Location = new System.Drawing.Point(21, 122);
            this.labBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBairro.Name = "labBairro";
            this.labBairro.Size = new System.Drawing.Size(47, 16);
            this.labBairro.TabIndex = 6;
            this.labBairro.Text = "Bairro:";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRua.Location = new System.Drawing.Point(21, 190);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(456, 22);
            this.txtRua.TabIndex = 9;
            // 
            // labRua
            // 
            this.labRua.AutoSize = true;
            this.labRua.Location = new System.Drawing.Point(21, 170);
            this.labRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRua.Name = "labRua";
            this.labRua.Size = new System.Drawing.Size(36, 16);
            this.labRua.TabIndex = 8;
            this.labRua.Text = "Rua:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::ConsultaCEP.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(304, 317);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::ConsultaCEP.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(412, 317);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 28);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmConsultaCEPs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 368);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.labCEP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultaCEPs";
            this.Text = "Consultar CEPs";
            this.gbxResultado.ResumeLayout(false);
            this.gbxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label labRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label labBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label labCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

