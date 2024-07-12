using DigitalMusicLibrary.Business.Models;
using DigitalMusicLibrary.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigitalMusicLibrary_BE.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ArtistsController : ControllerBase
	{
		private readonly IArtistService _ArtistService;
		public ArtistsController(IArtistService ArtistService)
		{
			_ArtistService = ArtistService ?? throw new ArgumentNullException(nameof(ArtistService));
		}
		[HttpGet("{id}")]
		public async Task<ActionResult> GetArtist(int id)
		{
			var Artist = await _ArtistService.GetArtist(id);
			return Ok(Artist);
		}
		[HttpGet("All")]
		public async Task<ActionResult<IEnumerable<ArtistDTO>>> GetAllArtists()
		{
			var Artists = await _ArtistService.GetAllArtists();
			return Ok(Artists);
		}

		[HttpPut("{id}/Edit")]
		public async Task<ActionResult> EditArtist(ArtistDTO ArtistToUpdate)
		{
			await _ArtistService.EditArtist(ArtistToUpdate);
			return NoContent();
		}
	}
}
