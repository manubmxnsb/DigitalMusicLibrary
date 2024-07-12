using DigitalMusicLibrary.Business.Models;


namespace DigitalMusicLibrary.Business.Services
{
	public interface ISongService
	{
		Task<SongDTO> GetSong(int id);
		Task<IEnumerable<SongDTO>> GetAllSongs();
		Task EditSong(SongDTO songToUpdate);
		Task<bool> SongExists(int songId);
	}
}
