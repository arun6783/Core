using AutoMapper;
using MobileTrader.Entity;
using MobileTrader.Web.Controllers.Resources;

namespace MobileTrader.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();

            CreateMap<Model, ModelResource>();
        }
    }
}