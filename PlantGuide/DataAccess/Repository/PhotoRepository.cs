using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class PhotoRepository : Repo<Photo, int>, IPhotoRepository
{
    public PhotoRepository(PlantguideContext context)
        : base(context)
    {

    }
}
