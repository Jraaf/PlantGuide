using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class FamilyService : Crud<Family,CreateFamilyDTO>,IFamilyService
{
    public FamilyService(IMapper _mapper, IFamilyRepository _repo)
        :base(_mapper, _repo)
    {
        
    }
}
