using DigitalMusicLibrary.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.JsonModels
{
	public class JsonAlbum
	{
		public string title { get; set; }
		public string description { get; set; }
		public List<JsonSong> songs { get; set; }
	}
}
