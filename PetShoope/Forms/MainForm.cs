using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetShoope.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dadosExternosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // obeter  a data e hora atuaL
            DateTime dataHoraAtual = DateTime.Now;

            //atualizar o status com data e hora 
            status2.Text = dataHoraAtual.ToString();
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // Pergunta se o usuário realmente quer sair
                DialogResult resposta = MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    // Fecha a aplicação inteira
                    Application.Exit();
                }
            }
        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formtutor = new tutorForm();
            formtutor.MdiParent = this;
            formtutor.WindowState = FormWindowState.Maximized;
            formtutor.Show();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formtutor = new animaisForm();
            formtutor.MdiParent = this;
            formtutor.WindowState = FormWindowState.Maximized;
            formtutor.Show();
        }

        private void carteiraDeVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formtutor = new carteirasvacinacaoForm();
            formtutor.MdiParent = this;
            formtutor.WindowState = FormWindowState.Maximized;
            formtutor.Show();
        }

        private void veterináriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formtutor = new veterinariosForm();
            formtutor.MdiParent = this;
            formtutor.WindowState = FormWindowState.Maximized;
            formtutor.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formtutor = new consultasForm();
            formtutor.MdiParent = this;
            formtutor.WindowState = FormWindowState.Maximized;
            formtutor.Show();
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formtutor = new consultaprocedimentosForm();
            formtutor.MdiParent = this;
            formtutor.WindowState = FormWindowState.Maximized;
            formtutor.Show();
        }
    }
}