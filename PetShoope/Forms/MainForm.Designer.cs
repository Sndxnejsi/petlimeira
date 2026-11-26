namespace PetShoope.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            tutorToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem = new ToolStripMenuItem();
            dadosExternosToolStripMenuItem = new ToolStripMenuItem();
            carteiraDeVacinaçãoToolStripMenuItem = new ToolStripMenuItem();
            veterináriosToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            especialidadeToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            status2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            telefoneToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, dadosExternosToolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1158, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tutorToolStripMenuItem, animalToolStripMenuItem, telefoneToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // tutorToolStripMenuItem
            // 
            tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            tutorToolStripMenuItem.Size = new Size(180, 22);
            tutorToolStripMenuItem.Text = "Tutor";
            tutorToolStripMenuItem.Click += tutorToolStripMenuItem_Click;
            // 
            // animalToolStripMenuItem
            // 
            animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            animalToolStripMenuItem.Size = new Size(180, 22);
            animalToolStripMenuItem.Text = "Animal";
            animalToolStripMenuItem.Click += animalToolStripMenuItem_Click;
            // 
            // dadosExternosToolStripMenuItem
            // 
            dadosExternosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carteiraDeVacinaçãoToolStripMenuItem, veterináriosToolStripMenuItem });
            dadosExternosToolStripMenuItem.Name = "dadosExternosToolStripMenuItem";
            dadosExternosToolStripMenuItem.Size = new Size(99, 20);
            dadosExternosToolStripMenuItem.Text = "Dados Externos";
            dadosExternosToolStripMenuItem.Click += dadosExternosToolStripMenuItem_Click;
            // 
            // carteiraDeVacinaçãoToolStripMenuItem
            // 
            carteiraDeVacinaçãoToolStripMenuItem.Name = "carteiraDeVacinaçãoToolStripMenuItem";
            carteiraDeVacinaçãoToolStripMenuItem.Size = new Size(187, 22);
            carteiraDeVacinaçãoToolStripMenuItem.Text = "Carteira de Vacinação";
            carteiraDeVacinaçãoToolStripMenuItem.Click += carteiraDeVacinaçãoToolStripMenuItem_Click;
            // 
            // veterináriosToolStripMenuItem
            // 
            veterináriosToolStripMenuItem.Name = "veterináriosToolStripMenuItem";
            veterináriosToolStripMenuItem.Size = new Size(187, 22);
            veterináriosToolStripMenuItem.Text = "Veterinários";
            veterináriosToolStripMenuItem.Click += veterináriosToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, especialidadeToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(218, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            consultaToolStripMenuItem.Click += consultaToolStripMenuItem_Click;
            // 
            // especialidadeToolStripMenuItem
            // 
            especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
            especialidadeToolStripMenuItem.Size = new Size(218, 22);
            especialidadeToolStripMenuItem.Text = "Consultas é procedimentos";
            especialidadeToolStripMenuItem.Click += especialidadeToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, status2 });
            statusStrip1.Location = new Point(0, 439);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1158, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(67, 17);
            toolStripStatusLabel1.Text = "PetShoop  |";
            // 
            // status2
            // 
            status2.Name = "status2";
            status2.Size = new Size(45, 17);
            status2.Text = "Status2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // telefoneToolStripMenuItem
            // 
            telefoneToolStripMenuItem.Name = "telefoneToolStripMenuItem";
            telefoneToolStripMenuItem.Size = new Size(180, 22);
            telefoneToolStripMenuItem.Text = "telefone";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 461);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "PetShoope  ";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem dadosExternosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel status2;
        private ToolStripMenuItem tutorToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem carteiraDeVacinaçãoToolStripMenuItem;
        private ToolStripMenuItem veterináriosToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem especialidadeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem telefoneToolStripMenuItem;
    }
}