using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Clony_Exemplo.Models
{
    public class Membro
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Nome")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Informar o nome completo")]
        public string Nome { get; set; }

        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("RG")]
        [StringLength(9)]
        public string Identidade { get; set; }

        [DisplayName("Mãe")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Informar o nome completo")]
        public string Mae { get; set; }

        [DisplayName("Pai")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Informar o nome completo")]
        public string Pai { get; set; }

        [DisplayName("Estado Civil")]
        [StringLength(20)]
        public string EstadoCivil { get; set; }

        [DisplayName("Tem Filhos?")]
        public bool Filhos { get; set; }

        public int Quantos { get; set; }

        [DisplayName("Endereço")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Informar o nome completo")]
        public string Endereco { get; set; }

        [DisplayName("Cep")]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [DisplayName("Facebook")]
        [DataType(DataType.Html)]
        public string Facebook { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Batismo")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}", ConvertEmptyStringToNull = true, NullDisplayText = "[Não Informado]")]
        public DateTime? DataBatismo { get; set; }

        [StringLength(20)]
        public string Cargo { get; set; }

    }

    public class MembroDBContext : DbContext
    {
        public DbSet<Membro> Membros { get; set; }
    }
}