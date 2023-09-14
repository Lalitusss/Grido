using AutoMapper;
using BE_HelacorTest.Models.dto;

namespace BE_HelacorTest.Models.profiles
{
    public class RepartoProfile: Profile
    {
        public RepartoProfile()
        {
            CreateMap<Repartos, RepartoDto>();
            CreateMap<RepartoDto, Repartos>();
        }
    }
}
