using AutoMapper;
using DigitalMusicLibrary.Business.Models;
using DigitalMusicLibrary.DataAccess.Entities;
using DigitalMusicLibrary.DataAccess.Repositories;

namespace DigitalMusicLibrary.Business.Services
{
	public class ArtistService : IArtistService
	{
		private readonly IArtistRepository _ArtistRepository;
		private readonly IMapper _mapper;

		public ArtistService(IArtistRepository ArtistRepository, IMapper mapper)
		{
			_ArtistRepository = ArtistRepository ?? throw new ArgumentNullException(nameof(ArtistRepository));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}
		public async Task<ArtistDTO> GetArtist(int id)
		{
			var Artist = await _ArtistRepository.GetArtistAsync(id);
			return _mapper.Map<ArtistDTO>(Artist);
		}

		public async Task<IEnumerable<ArtistDTO>> GetAllArtists()
		{
			var allArtists = await _ArtistRepository.GetAllArtistsAsync();
			var mappedAllArtists = allArtists.Select(_mapper.Map<ArtistDTO>);
			return mappedAllArtists;
		}

		public async Task EditArtist(ArtistDTO ArtistToUpdate)
		{
			var ArtistEdit = _mapper.Map<Artist>(ArtistToUpdate);
			await _ArtistRepository.EditArtist(ArtistEdit);
		}

		public async Task<bool> ArtistExists(int ArtistId)
		{
			return await _ArtistRepository.ArtistExistsAsync(ArtistId);
		}
	}
}
