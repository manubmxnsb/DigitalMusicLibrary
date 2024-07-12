using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.Business.Models
{
	public class AlbumDTO
	{
		public long Id { get; set; }
		public string title { get; set; }
		public ICollection<SongDTO> songs { get; set; }
		public string description { get; set; }
	}
}
