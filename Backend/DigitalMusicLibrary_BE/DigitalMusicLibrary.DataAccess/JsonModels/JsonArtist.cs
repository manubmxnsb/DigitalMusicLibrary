using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.JsonModels
{
	public class JsonArtist
	{
		public string name { get; set; }
		public ICollection<JsonAlbum> albums { get; set; }
	}
}
