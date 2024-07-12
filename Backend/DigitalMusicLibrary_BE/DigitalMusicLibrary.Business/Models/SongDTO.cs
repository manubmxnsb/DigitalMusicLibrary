using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.Business.Models
{
	public class SongDTO
	{
		public long Id { get; set; }
		public string title { get; set; }
		public string length { get; set; }
	}
}
