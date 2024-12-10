using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class PhotoService : Crud<Photo, CreatePhotoDTO>, IPhotoService
{
    private readonly IMapper mapper;
    private readonly IPhotoRepository repo;

    public PhotoService(IMapper _mapper, IPhotoRepository _repo)
        : base(_mapper, _repo)
    {
        mapper = _mapper;
        repo = _repo;
    }

    public async Task<List<Photo>> GetByPlantId(int plantId)
    {
        return await repo.GetByPlantId(plantId);
    }
}
