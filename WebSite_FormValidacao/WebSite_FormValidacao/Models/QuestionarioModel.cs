using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSite_FormValidacao.Models
{
    public class QuestionarioModel
    {
        [Required]
        [DisplayName("Tipo de Projeto")]
        public string TipoProjeto { get; set; }

        [Required(ErrorMessage = "O CEP deve ser informado!")]
        [RegularExpression(@"^\d{8}$|^\d{5}-\d{3}$",ErrorMessage ="O código postal deverá estar no formato de 00000000 ou 00000-000 ")]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "o nome de contato deve ser informado!")]
        [StringLength(50, MinimumLength = 5)]
        public string Contato { get; set; }

        [Required(ErrorMessage = "o e-mail é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "o número de telefone deve ser informado!")]
        [DataType(DataType.PhoneNumber,ErrorMessage = "Forneça o número do telefone no formato (00)000-0000")]
        [DisplayName("Número do telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe a descrição do projeto.")]
        [DisplayName("Descrição do Projeto")]
        [StringLength(5000,MinimumLength = 20)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }   
    }
}