using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using DigitalMusicLibrary.DataAccess.Entities;

namespace DigitalMusicLibrary.DataAccess.Entities
{
	public class Album
	{
		[Key]
		public long Id { get; set; }
		[ForeignKey("ArtistId")]
		public Artist? Artist { get; set; }
		public long ArtistId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public List<Song> Songs { get; set; } = new List<Song>();
	}

}
