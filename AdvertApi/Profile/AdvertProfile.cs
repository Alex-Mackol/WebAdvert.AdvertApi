using AdvertApi.Models;
using AdvertApi.Services;

namespace AdvertApi.Profile
{
    public class AdvertProfile : AutoMapper.Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertDbModel, AdvertModel>().ReverseMap();
        }
    }
}
