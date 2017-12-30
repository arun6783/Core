using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MobileTrader.Web.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }
      
        public string Name { get; set; }

        public virtual ICollection<ModelResource> Models { get; set; }

        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}