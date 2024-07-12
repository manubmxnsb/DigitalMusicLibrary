using DigitalMusicLibrary.DataAccess.Entities;
using DigitalMusicLibrary.DataAccess.JsonModels;
using DigitalMusicLibrary.DataAccess.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace DigitalMusicLibrary.DataAccess.DbContexts
{
	public static class SeedData
	{
		public static void Initialize(DigitalMusicLibraryDBContext context)
		{
			if (context.Artists.Any())
			{
				return;
			}
			List<JsonArtist> jsonArtists = new List<JsonArtist>();
			using (StreamReader r = new StreamReader("D:\\IT\\DigitalMusicLibrary\\Backend\\DigitalMusicLibrary_BE\\DigitalMusicLibrary_BE\\Resources\\data.json"))
			{
				string json = r.ReadToEnd();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
				jsonArtists = JsonSerializer.Deserialize<List<JsonArtist>>(json);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
			}
			foreach (JsonArtist jsonArtist in jsonArtists)
			{
				context.Artists.AddRange(
						new Artist()
						{
							Name = jsonArtist.name,
							Albums = jsonArtist.albums.ConvertToEntity(),
						});
			}
			context.SaveChanges();
		}
	}
}
