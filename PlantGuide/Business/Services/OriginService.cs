using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class OriginService:Crud<Origin,CreateOriginDTO>,IOriginService
{
    public OriginService(IMapper _mapper,IOriginRepository _repo)
        : base(_mapper, _repo)
    {
        
    }
}
