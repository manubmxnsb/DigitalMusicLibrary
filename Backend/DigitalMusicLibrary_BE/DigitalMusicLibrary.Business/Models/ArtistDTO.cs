using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.Business.Models
{
	public class ArtistDTO
	{
		public long Id { get; set; }
		public string name { get; set; }
		public ICollection<AlbumDTO> albums { get; set; }
	}
}
