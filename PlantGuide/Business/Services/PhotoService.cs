using AutoMapper;
using DataAccess.Models;
using PlantGuide.Business.DTO;
using PlantGuide.Business.Services.Base;
using PlantGuide.Business.Services.Interfaces;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.Business.Services;

public class PhotoService : Crud<Photo, CreatePhotoDTO>, IPhotoService
{
    public PhotoService(IMapper _mapper, IPhotoRepository _repo)
        : base(_mapper, _repo)
    {

    }
}
