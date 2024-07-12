using DigitalMusicLibrary.DataAccess.Entities;
using DigitalMusicLibrary.DataAccess.JsonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.Extensions
{
	public static class JsonSongExtension
	{
		public static List<Song> ConvertSongsToEntity(this List<JsonSong> jsonSongs)
		{
			/*            foreach (var album in jsonAlbums)
						{
							Console.Write(album.Title.ToString());
							Console.Write("WORKS");
						}*/
			List<Song> results = (from jsonSong in jsonSongs
								   select new Song()
								   {
									   Title = jsonSong.title,
									   Length = jsonSong.length,
								   }).ToList();
			return results;
		}
	}
}
