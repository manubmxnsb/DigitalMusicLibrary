using DigitalMusicLibrary.DataAccess.Entities;
using DigitalMusicLibrary.DataAccess.JsonModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DigitalMusicLibrary.DataAccess.DbContexts
{
	public class DigitalMusicLibraryDBContext : DbContext
	{
		public DbSet<Artist> Artists { get; set; } = null!;
		public DbSet<Album> Albums { get; set; } = null!;
		public DbSet<Song> Songs { get; set; } = null!;
		public DigitalMusicLibraryDBContext(DbContextOptions<DigitalMusicLibraryDBContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Song>()
				.HasOne(a => a.Album)
				.WithMany(b => b.Songs)
				.HasPrincipalKey(s => s.Id);
			modelBuilder.Entity<Album>()
				.HasOne(a => a.Artist)
				.WithMany(b => b.Albums)
				.HasPrincipalKey(c => c.Id);
		}
				/*new Artist()
				{
					Id = 1,
					Name = "Radiohead",
				},
				new Artist()
				{
					Id = 2,
					Name = "Portishead",
				},
				new Artist()
				{
					Id = 3,
					Name = "Rammstein",
				},
				new Artist()
				{
					Id = 4,
					Name = "Taylor Swift",
				});
			modelBuilder.Entity<Album>().HasData(
				new Album()
				{
					Id = 1,
					ArtistId = 1,
					Title = "The King of Limbs",
					Description = "\n\tThe King of Limbs is the eighth studio album by English rock band Radiohead, produced by Nigel Godrich. It was self-released on 18 February 2011 as a download in MP3 and WAV formats, followed by physical CD and 12\" vinyl releases on 28 March, a wider digital release via AWAL, and a special \"newspaper\" edition on 9 May 2011. The physical editions were released through the band's Ticker Tape imprint on XL in the United Kingdom, TBD in the United States, and Hostess Entertainment in Japan.\n      "
				},
				new Album()
				{
					Id = 2,
					ArtistId = 1,
					Title = "OK Computer",
					Description = "\n\tOK Computer is the third studio album by the English alternative rock band Radiohead, released on 16 June 1997 on Parlophone in the United Kingdom and 1 July 1997 by Capitol Records in the United States. It marks a deliberate attempt by the band to move away from the introspective guitar-oriented sound of their previous album The Bends. Its layered sound and wide range of influences set it apart from many of the Britpop and alternative rock bands popular at the time and laid the groundwork for Radiohead's later, more experimental work.\n      "
				},
				new Album()
				{
					Id = 3,
					ArtistId = 2,
					Title = "Dummy",
					Description = "\n\tDummy is the debut album of the Bristol-based group Portishead. Released in August 22, 1994 on Go! Discs, the album earned critical acclaim, winning the 1995 Mercury Music Prize. It is often credited with popularizing the trip-hop genre and is frequently cited in lists of the best albums of the 1990s. Although it achieved modest chart success overseas, it peaked at #2 on the UK Album Chart and saw two of its three singles reach #13. The album was certified gold in 1997 and has sold two million copies in Europe. As of September 2011, the album was certified double-platinum in the United Kingdom and has sold as of September 2011 825,000 copies.\n      "
				},
				new Album()
				{
					Id = 4,
					ArtistId = 2,
					Title = "Third",
					Description = "\n\tThird is the third studio album by English musical group Portishead, released on 27 April 2008, on Island Records in the United Kingdom, two days after on Mercury Records in the United States, and on 30 April 2008 on Universal Music Japan in Japan. It is their first release in 10 years, and their first studio album in eleven years. Third entered the UK Album Chart at #2, and became the band's first-ever American Top 10 album on the Billboard 200, reaching #7 in its entry week.\n      "
				},
				new Album()
				{
					Id = 5,
					ArtistId = 3,
					Title = "Herzeleid",
					Description = "\\n\\tHerzeleid is the debut album by German Neue Deutsche Härte band Rammstein. It was released on 29 September 1995 through Motor Music. The album's original cover depicted the band members' upper bodies without clothing. This caused critics to accuse the band of trying to sell themselves as \"poster boys for the master race\". The cover was replaced with a less controversial design for the album's international release. Despite the controversy, Herzeleid has been well received by critics and has since been certified platinum in Germany.\\n "
				},
				new Album()
				{
					Id = 6,
					ArtistId = 3,
					Title = "Mutter",
					Description = "\\n\\tMutter is the third album by German Neue Deutsche Härte band Rammstein. It was released on 2 April 2001 through Motor and Universal Music. The album's title means \"mother\" in German and is a reference to the band's song of the same name. Mutter has been well received by critics and was a commercial success, reaching number one in Germany, Austria, and Switzerland. It has since been certified platinum in several countries.\\n "
				},
				new Album()
				{
					Id = 7,
					ArtistId = 4,
					Title = "Fearless",
					Description = "\n\tFearless is the second studio album by American singer-songwriter Taylor Swift. It was released on November 11, 2008, by Big Machine Records. The album was a commercial success, topping the Billboard 200 for 11 non-consecutive weeks. It was also the best-selling album of 2009 in the United States. Fearless has been certified Diamond by the Recording Industry Association of America (RIAA) and has sold over 10 million copies worldwide. It won four Grammy Awards, including Album of the Year, making Swift the youngest recipient of the award at the time.\n "
				},
				new Album()
				{
					Id = 8,
					ArtistId = 4,
					Title = "1989",
					Description = "\n\t1989 is the fifth studio album by American singer-songwriter Taylor Swift. It was released on October 27, 2014, through Big Machine Records. The album marked a departure from the country music that had been Swift's trademark sound, and is described as her evolution into pop music. 1989 received generally positive reviews from music critics and was a commercial success, debuting at number one on the Billboard 200 and selling over 1.28 million copies in its first week. It has since been certified 9× Platinum by the RIAA and has sold over 10 million copies worldwide.\n "
				}*/
			

			/*modelBuilder.Entity<Song>().HasData(
				new Song()
				{
					Id = 1,
					AlbumId = 1,
					Title = "Bloom",
					Length = "5:15"
				},
				new User()
				{
					Id = 2,
					FirstName = "Ted",
					LastName = "Marshal",
					Role = RoleType.General,
					Email = "ted.marshal@red-to-blue.com",
					JobTitle = "Front-End Developer",
					Department = "Development",
					Picture = new Byte[10],
					PhoneNumber = "9876543210",
					DaysOff = 9,
				},
				new User()
				{
					Id = 3,
					FirstName = "Sofia",
					LastName = "Atkinson",
					Role = RoleType.HR,
					Email = "sofia.atkinson@red-to-blue.com",
					JobTitle = "Human Resources",
					Department = "HR",
					Picture = new Byte[10],
					PhoneNumber = "0918273465",
					DaysOff = 6,
				});

			modelBuilder.Entity<Event>().HasData(
				new Event()
				{
					Id = 1,
					Title = "National day",
					Description = "Celebrating Romanian National Day.",
					Date = new DateTime(2023, 12, 01),
					Location = LocationType.Online,
					Type = EventType.General
				},

				new Event()
				{
					Id = 2,
					Title = "Red to Blue 10th anniversary.",
					Description = "Celebrating 10 years of Red to Blue.",
					Date = new DateTime(2024, 08, 20),
					Location = LocationType.Online,
					Type = EventType.General
				});*/

			/*base.OnModelCreating(modelBuilder);*/
		}
	}

