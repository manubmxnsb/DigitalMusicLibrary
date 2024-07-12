using DigitalMusicLibrary.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.Repositories
{
	public interface IAlbumRepository
	{
		Task<Artist?> GetArtistAsync(long ArtistId);
		Task<IEnumerable<Album>> GetAllAlbumsAsync();
		Task<bool> ArtistExistsAsync(long cityId);
		Task DeleteArtists(List<long> ArtistIds);
		Task EditAlbum(Album album);
	}
}
