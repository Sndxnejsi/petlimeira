using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetShoope.Data;
using PetShoope.Models;


namespace PetShoope.Forms
{
    public partial class tutorForm : Form
    {
        private int idSelecionado = 0;

        public tutorForm()
        {
            InitializeComponent();
            ListarTutores();
        }

        private void ListarTutores()
        {
            var banco = new BancoContext();

            var tutores =
                from t in banco.Controletutores
                select new
                {
                    t.IdTutor,
                    t.Nome,
                    t.Cpf,
                    t.Rua,
                    t.Numero,
                    t.Bairro,
                    t.Cidade,
                    t.Cep,
                    t.Telefone
                };

            dataGridView1.DataSource = tutores.ToList();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtnomecompleto.Text))
            {
                MessageBox.Show("Informe o nome do tutor");
                txtnomecompleto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(texttelefone.Text))
            {
                MessageBox.Show("Informe o telefone do tutor");
                texttelefone.Focus();
                return false;
            }

            var banco = new BancoContext();
            bool jaExiste = banco.Controletutores.Any(
                t => t.Nome == txtnomecompleto.Text.Trim() &&
                     t.Telefone == texttelefone.Text.Trim() &&
                     t.IdTutor != idSelecionado);

            if (jaExiste)
            {
                MessageBox.Show("Já existe um tutor com este nome e telefone");
                return false;
            }

            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            var banco = new BancoContext();

            var tutor = new Tutor
            {
                Nome = txtnomecompleto.Text.Trim(),
                Cpf = txtcpf.Text.Trim(),
                Rua = textrua.Text.Trim(),
                Numero = textnumero.Text.Trim(),
                Bairro = textBairro.Text.Trim(),
                Cidade = textcidade.Text.Trim(),
                Cep = textcep.Text.Trim(),
                Telefone = texttelefone.Text.Trim()
            };

            banco.Controletutores.Add(tutor);
            banco.SaveChanges();

            ListarTutores();
            Limpar();
            MessageBox.Show("Dados gravados com sucesso");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um tutor na tabela para atualizar");
                return;
            }

            if (!Validar())
                return;

            var banco = new BancoContext();

            var tutor = banco.Controletutores.Find(idSelecionado);
            if (tutor == null)
            {
                MessageBox.Show("Tutor não encontrado");
                return;
            }

            tutor.Nome = txtnomecompleto.Text.Trim();
            tutor.Cpf = txtcpf.Text.Trim();
            tutor.Rua = textrua.Text.Trim();
            tutor.Numero = textnumero.Text.Trim();
            tutor.Bairro = textBairro.Text.Trim();
            tutor.Cidade = textcidade.Text.Trim();
            tutor.Cep = textcep.Text.Trim();
            tutor.Telefone = texttelefone.Text.Trim();

            banco.SaveChanges();

            ListarTutores();
            Limpar();
            MessageBox.Show("Dados atualizados com sucesso");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um tutor na tabela para excluir");
                return;
            }

            var resposta = MessageBox.Show(
                "Deseja realmente excluir este tutor?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            try
            {
                var banco = new BancoContext();

                var tutor = banco.Controletutores.Find(idSelecionado);
                if (tutor != null)
                {
                    banco.Controletutores.Remove(tutor);
                    banco.SaveChanges();
                }

                ListarTutores();
                Limpar();
                MessageBox.Show("Tutor excluído com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir. Este tutor pode ter animais vinculados.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            idSelecionado = 0;
            txtnomecompleto.Clear();
            txtcpf.Clear();
            textrua.Clear();
            textnumero.Clear();
            textBairro.Clear();
            textcidade.Clear();
            textcep.Clear();
            texttelefone.Clear();
            txtnomecompleto.Focus();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var linha = dataGridView1.Rows[e.RowIndex];

            idSelecionado = Convert.ToInt32(linha.Cells["IdTutor"].Value);
            txtnomecompleto.Text = linha.Cells["Nome"].Value?.ToString();
            txtcpf.Text = linha.Cells["Cpf"].Value?.ToString();
            textrua.Text = linha.Cells["Rua"].Value?.ToString();
            textnumero.Text = linha.Cells["Numero"].Value?.ToString();
            textBairro.Text = linha.Cells["Bairro"].Value?.ToString();
            textcidade.Text = linha.Cells["Cidade"].Value?.ToString();
            textcep.Text = linha.Cells["Cep"].Value?.ToString();
            texttelefone.Text = linha.Cells["Telefone"].Value?.ToString();
        }

        private void txtnomecompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}