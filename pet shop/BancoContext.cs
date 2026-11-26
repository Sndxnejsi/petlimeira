using Microsoft.EntityFrameworkCore;
using PetShoope;
using PetShoope.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShoope.Data
{
    // O DbContext é a classe base do EF Core que gerencia
    // a conexão com o banco de dados
    // Aqui ela é obtida por herança
    public class BancoContext : DbContext
    {
        // Propriedades que funcionam como o controle remoto para executar as ações do CRUD
        public DbSet<animaisForm> Controleanimais { get; set; }
        public DbSet<carteirasvacinacaoForm> Controlecarteiravacinacao { get; set; }
        public DbSet<consultasForm> Controleconsultas { get; set; }
        public DbSet<consultaprocedimentosForm> Controleconsultaprocedimentos { get; set; }
        public DbSet<procedimentosForm> Controleprocedimentos { get; set; }
        public DbSet<tutorForm> Controletutores { get; set; }
        public DbSet<veterinariosForm> Controleveterianarios { get; set; }

        // Método para informações e configuração do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conexao = "server=127.0.0.1;port=3307;database=petshoop;user=root;";
            // O AutoDetect vai identificar automaticamente a versão do seu banco MySQL/MariaDB
            options.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }
    }
}