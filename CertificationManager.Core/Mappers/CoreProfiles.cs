using AutoMapper;
using CertificationManager.Core.Abstractions.Dtos;
using CertificationManager.Infrastructure.Abstractions.Entities;

namespace CertificationManager.Core.Mappers
{
    public class CoreProfiles : Profile
    {
        public CoreProfiles()
        {
            CreateMap<CertificacionesVolumenes, ClientesDto>().ReverseMap();
        }
    }
}