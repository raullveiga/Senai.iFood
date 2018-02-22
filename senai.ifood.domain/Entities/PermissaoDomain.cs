using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class PermissaoDomain : BaseDomain
    {
        
        public ICollection<UsuarioPermissaoDomain> UsuarioPermissao { get; set; }
    }
}