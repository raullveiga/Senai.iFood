using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities{
    public class ClienteDomain :BaseDomain
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(50)]
        public string Sexo { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }
        
    }
}