using DigitalMusicLibrary.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.Repositories
{
	public interface IArtistRepository
	{
		Task<Artist?> GetArtistAsync(int artistId);
		Task<IEnumerable<Artist>> GetAllArtistsAsync();
		Task<bool> ArtistExistsAsync(int cityId);
/*		Task DeleteArtists(List<long> artistIds);
*/		Task EditArtist(Artist artist);
	}
}
