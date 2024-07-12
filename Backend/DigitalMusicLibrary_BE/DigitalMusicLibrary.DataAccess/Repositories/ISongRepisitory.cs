using DigitalMusicLibrary.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.Repositories
{
	public interface ISongRepisitory
	{
		Task<Song?> GetSongAsync(long SongId);
		Task<IEnumerable<Song>> GetAllSongsAsync();
		Task<bool> SongExistsAsync(long cityId);
		Task DeleteSongs(List<long> SongIds);
		Task EditSong(Song song);

	}
}
