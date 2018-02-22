using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities{
    public class RestauranteDomain : BaseDomain
    {
        [Required]
        [StringLength(50)]
        public string Responsavel { get; set; }

        [Required]
        [StringLength(50)]
        public string Site { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ForeignKey("EspecialidadeId")]
        public EspecialidadeDomain Especialidade { get; set; }
        public int EspecialidadeId { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }


        public ICollection<ProdutoRestauranteDomain> Produtos { get; set; }
        
    }
}