using DigitalMusicLibrary.DataAccess.DbContexts;
using DigitalMusicLibrary.DataAccess.Entities;
using DigitalMusicLibrary.DataAccess.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.Repositories
{
	public class ArtistRepository : IArtistRepository
	{
		private readonly DigitalMusicLibraryDBContext _context;

		public ArtistRepository(DigitalMusicLibraryDBContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public async Task<Artist?> GetArtistAsync(int ArtistId)
		{
			var Artist = await _context.Artists
					.Include(a => a.Albums)
					.ThenInclude(al => al.Songs)
					.FirstOrDefaultAsync
				(Artist => Artist.Id == ArtistId);
			return Artist == null ? throw new NotFoundException() : Artist;
		}

		public async Task<IEnumerable<Artist>> GetAllArtistsAsync()
		{

			var allArtists = _context.Artists
				.Include(a => a.Albums)
				.ThenInclude(al => al.Songs);
			var ArtistsToReturn = await allArtists.ToListAsync();
			return ArtistsToReturn;
		}
		public async Task EditArtist(Artist ArtistToUpdate)
		{
			if (!await _context.Artists.AnyAsync(Artist => Artist.Id == ArtistToUpdate.Id))
			{
				throw new NotFoundException();
			}

			_context.Artists.Update(ArtistToUpdate);
			await _context.SaveChangesAsync();
		}

		public async Task<bool> ArtistExistsAsync(int ArtistId)
		{
			return await _context.Artists.AnyAsync(Artist => Artist.Id == ArtistId);
		}
	}
}
