using DigitalMusicLibrary.Business.Models;

namespace DigitalMusicLibrary.Business.Services
{
	public interface IArtistService
	{
		Task<ArtistDTO> GetArtist(int id);
		Task<IEnumerable<ArtistDTO>> GetAllArtists();
		Task EditArtist(ArtistDTO artistToUpdate);
		Task<bool> ArtistExists(int artistId);
	}
}
