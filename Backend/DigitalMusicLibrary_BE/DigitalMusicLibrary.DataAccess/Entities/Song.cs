using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DigitalMusicLibrary.DataAccess.Entities
{
	public class Song
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		[ForeignKey("AlbumId")]
		public Album? Album { get; set; }
		public long AlbumId { get; set; }

		public string Title { get; set; }

		public string Length { get; set; }

	}
}

