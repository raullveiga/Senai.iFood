using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class UsuarioDomain : BaseDomain
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [ForeignKey("UsuarioId")]
        public ICollection<UsuarioPermissaoDomain> UsuarioPermissaos { get; set; }  

        [ForeignKey("RestauranteId")]
        public ICollection<RestauranteDomain> Restaurantes { get; set; }     

        [ForeignKey("ClienteId")]
        public ICollection<ClienteDomain> Clientes { get; set; }
    }
}