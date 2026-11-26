namespace PetShoope.Forms
{
    partial class tutorForm
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
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            txtLimpar = new Button();
            groupBox1 = new GroupBox();
            btnExcluir = new Button();
            texttelefone = new TextBox();
            textcep = new TextBox();
            textcidade = new TextBox();
            txtcpf = new TextBox();
            textrua = new TextBox();
            textBairro = new TextBox();
            textnumero = new TextBox();
            txtnomecompleto = new TextBox();
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            txtCampoBusca = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(78, 352);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(66, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(160, 352);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(66, 23);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtLimpar
            // 
            txtLimpar.Location = new Point(242, 352);
            txtLimpar.Name = "txtLimpar";
            txtLimpar.Size = new Size(66, 23);
            txtLimpar.TabIndex = 10;
            txtLimpar.Text = "Limpar";
            txtLimpar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(texttelefone);
            groupBox1.Controls.Add(textcep);
            groupBox1.Controls.Add(textcidade);
            groupBox1.Controls.Add(txtcpf);
            groupBox1.Controls.Add(textrua);
            groupBox1.Controls.Add(textBairro);
            groupBox1.Controls.Add(textnumero);
            groupBox1.Controls.Add(txtnomecompleto);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(txtLimpar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 381);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Tutor";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(0, 352);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(66, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // texttelefone
            // 
            texttelefone.Font = new Font("Segoe UI", 11.25F);
            texttelefone.Location = new Point(6, 295);
            texttelefone.Name = "texttelefone";
            texttelefone.PlaceholderText = "telefone";
            texttelefone.Size = new Size(201, 27);
            texttelefone.TabIndex = 18;
            // 
            // textcep
            // 
            textcep.Font = new Font("Segoe UI", 11.25F);
            textcep.Location = new Point(6, 262);
            textcep.Name = "textcep";
            textcep.PlaceholderText = "cep";
            textcep.Size = new Size(201, 27);
            textcep.TabIndex = 17;
            // 
            // textcidade
            // 
            textcidade.Font = new Font("Segoe UI", 11.25F);
            textcidade.Location = new Point(6, 229);
            textcidade.Name = "textcidade";
            textcidade.PlaceholderText = "cidade";
            textcidade.Size = new Size(201, 27);
            textcidade.TabIndex = 16;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Segoe UI", 11.25F);
            txtcpf.Location = new Point(6, 65);
            txtcpf.Name = "txtcpf";
            txtcpf.PlaceholderText = "CPF";
            txtcpf.Size = new Size(201, 27);
            txtcpf.TabIndex = 15;
            // 
            // textrua
            // 
            textrua.Font = new Font("Segoe UI", 11.25F);
            textrua.Location = new Point(6, 111);
            textrua.Name = "textrua";
            textrua.PlaceholderText = "rua";
            textrua.Size = new Size(201, 27);
            textrua.TabIndex = 14;
            // 
            // textBairro
            // 
            textBairro.Font = new Font("Segoe UI", 11.25F);
            textBairro.Location = new Point(6, 196);
            textBairro.Name = "textBairro";
            textBairro.PlaceholderText = "Bairro";
            textBairro.Size = new Size(201, 27);
            textBairro.TabIndex = 13;
            // 
            // textnumero
            // 
            textnumero.Font = new Font("Segoe UI", 11.25F);
            textnumero.Location = new Point(6, 154);
            textnumero.Name = "textnumero";
            textnumero.PlaceholderText = "Numero";
            textnumero.Size = new Size(201, 27);
            textnumero.TabIndex = 12;
            // 
            // txtnomecompleto
            // 
            txtnomecompleto.Font = new Font("Segoe UI", 11.25F);
            txtnomecompleto.Location = new Point(6, 22);
            txtnomecompleto.Name = "txtnomecompleto";
            txtnomecompleto.PlaceholderText = "nome completo";
            txtnomecompleto.Size = new Size(201, 27);
            txtnomecompleto.TabIndex = 11;
            txtnomecompleto.TextChanged += txtnomecompleto_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 434);
            dataGridView1.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(680, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCampoBusca
            // 
            txtCampoBusca.Location = new Point(413, 12);
            txtCampoBusca.Name = "txtCampoBusca";
            txtCampoBusca.PlaceholderText = "Buscar Tutor";
            txtCampoBusca.Size = new Size(225, 23);
            txtCampoBusca.TabIndex = 14;
            // 
            // tutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 510);
            Controls.Add(txtCampoBusca);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "tutorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tutorForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button txtLimpar;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtnomecompleto;
        private TextBox textcep;
        private TextBox textcidade;
        private TextBox txtcpf;
        private TextBox textrua;
        private TextBox textBairro;
        private TextBox textnumero;
        private TextBox texttelefone;
        private Button btnBuscar;
        private TextBox txtCampoBusca;
        private Button btnExcluir;
    }
}