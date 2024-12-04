using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class SourceService : Crud<Source, CreateSourceDTO>, ISourceService
{
    public SourceService(IMapper _mapper, ISourceRepository _repo)
        : base(_mapper, _repo)
    {

    }
}
