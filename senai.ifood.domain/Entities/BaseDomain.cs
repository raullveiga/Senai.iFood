using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities

{
    public abstract class BaseDomain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }
    }
}