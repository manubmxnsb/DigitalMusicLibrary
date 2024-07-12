using AutoMapper;
using DigitalMusicLibrary.Business.Models;
using DigitalMusicLibrary.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.Business.Profiles
{
	public class AlbumProfile : Profile
	{
		public AlbumProfile()
		{ 
			CreateMap<Album, AlbumDTO>();
			CreateMap<Album, AlbumDTO>().ReverseMap();
		}
	}
}
