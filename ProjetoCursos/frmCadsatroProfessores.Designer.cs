namespace ProjetoCursos
{
    partial class frmCadastroProfessores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_professorLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cepLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProfessores));
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            
            
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            
            id_professorLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            
            this.SuspendLayout();
            // 
            // id_professorLabel
            // 
            id_professorLabel.AutoSize = true;
            id_professorLabel.Location = new System.Drawing.Point(20, 38);
            id_professorLabel.Name = "id_professorLabel";
            id_professorLabel.Size = new System.Drawing.Size(43, 13);
            id_professorLabel.TabIndex = 0;
            id_professorLabel.Text = "Codigo:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(78, 38);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(20, 83);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 4;
            enderecoLabel.Text = "endereco:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(20, 131);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 6;
            bairroLabel.Text = "bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(207, 131);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 8;
            cidadeLabel.Text = "cidade:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(20, 180);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(19, 13);
            ufLabel.TabIndex = 10;
            ufLabel.Text = "uf:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(207, 180);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 12;
            telefoneLabel.Text = "telefone:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(78, 180);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 14;
            cepLabel.Text = "cep:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 252);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(id_professorLabel);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(enderecoLabel);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(bairroLabel);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(cidadeLabel);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(ufLabel);
            this.tabPage1.Controls.Add(this.txtUF);
            this.tabPage1.Controls.Add(telefoneLabel);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(cepLabel);
            this.tabPage1.Controls.Add(this.txtCEP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // professorBindingNavigator
            // 
            
            // 
            // bindingNavigatorAddNewItem
            // 
           
            // 
            // professorBindingSource
            // 
           
            // 
            // bdprojetocursosDataSet
            // 
            
            // 
            // bindingNavigatorCountItem
            // 
            
            // 
            // bindingNavigatorDeleteItem
            // 
           
            // 
            // bindingNavigatorMoveFirstItem
            // 
            
            // 
            // bindingNavigatorMovePreviousItem
            // 
            
            // 
            // bindingNavigatorSeparator
            // 
            
            // 
            // bindingNavigatorPositionItem
            // 
            
            // 
            // bindingNavigatorSeparator1
            // 
            
            // 
            // bindingNavigatorMoveNextItem
            // 
            
            // 
            // bindingNavigatorMoveLastItem
            // 
           
            // 
            // bindingNavigatorSeparator2
            // 
            
            // 
            // professorBindingNavigatorSaveItem
            // 
            
            // 
            // txtCodigo
            // 
            
            this.txtCodigo.Location = new System.Drawing.Point(20, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(42, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            
            this.txtNome.Location = new System.Drawing.Point(77, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEndereco
            // 
            
            this.txtEndereco.Location = new System.Drawing.Point(20, 99);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(332, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtBairro
            // 
            
            this.txtBairro.Location = new System.Drawing.Point(20, 147);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(163, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            
            this.txtCidade.Location = new System.Drawing.Point(210, 147);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(142, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtUF
            // 
            
            this.txtUF.Location = new System.Drawing.Point(20, 196);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(37, 20);
            this.txtUF.TabIndex = 11;
            // 
            // txtTelefone
            // 
            
            this.txtTelefone.Location = new System.Drawing.Point(210, 196);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(142, 20);
            this.txtTelefone.TabIndex = 13;
            // 
            // txtCEP
            // 
            
            this.txtCEP.Location = new System.Drawing.Point(77, 196);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // professorTableAdapter
            // 
           
            // 
            // tableAdapterManager
            // 
            
            // 
            // frmCadastroProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 298);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadastroProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.Load += new System.EventHandler(this.frmCadastroProfessores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCEP;
        
    }
}