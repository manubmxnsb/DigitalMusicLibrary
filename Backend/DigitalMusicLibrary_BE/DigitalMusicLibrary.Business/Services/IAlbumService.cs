using DigitalMusicLibrary.Business.Models;

namespace DigitalMusicLibrary.Business.Services
{
	public interface IAlbumService
	{
		Task<AlbumDTO> GetAlbum(int id);
		Task<IEnumerable<AlbumDTO>> GetAllAlbums();
		Task EditAlbum(AlbumDTO albumToUpdate);
		Task<bool> AlbumExists(int albumId);
	}
}
