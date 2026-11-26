using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetShoope.Models
{
    // Anotação para indicar qual tabela esta classe representa
    [Table("tutores")]
    public class Tutor
    {
        // Propriedades da classe
        // get é pegar ou ler
        // set é definir ou alterar

        [Key]
        [Column("id")]
        public int IdTutor { get; set; }

        [Column("nome_completo")]
        public string Nome { get; set; } = string.Empty;

        [Column("cpf")]
        public string Cpf { get; set; } = string.Empty;

        [Column("rua")]
        public string Rua { get; set; } = string.Empty;

        [Column("numero")]
        public string Numero { get; set; } = string.Empty;

        [Column("bairro")]
        public string Bairro { get; set; } = string.Empty;

        [Column("cidade")]
        public string Cidade { get; set; } = string.Empty;

        [Column("cep")]
        public string Cep { get; set; } = string.Empty;

        [Column("telefone")]
        public string Telefone { get; set; } = string.Empty;
    }
}