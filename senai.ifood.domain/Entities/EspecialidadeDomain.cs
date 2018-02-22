using System.Collections.Generic;

namespace senai.ifood.domain.Entities
{
    public class EspecialidadeDomain : BaseDomain
    {
        public ICollection<RestauranteDomain> Restaurantes { get; set; }
    }
}