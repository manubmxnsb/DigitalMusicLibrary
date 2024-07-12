
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace DigitalMusicLibrary.DataAccess.Entities
{
	public class Artist
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		public string Name { get; set; }
		public ICollection<Album> Albums { get; set; } = new List<Album>();
	}
}
