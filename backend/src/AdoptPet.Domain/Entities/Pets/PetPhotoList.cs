namespace AdoptPet.Domain.Entities.Pets;

public class PetPhotoList
{
    private PetPhotoList()
    {
    }

    public PetPhotoList(IEnumerable<PetPhoto> photos) 
    {
        Photos = photos.ToList();
    }

    public IReadOnlyList<PetPhoto> Photos { get; } = [];


}
