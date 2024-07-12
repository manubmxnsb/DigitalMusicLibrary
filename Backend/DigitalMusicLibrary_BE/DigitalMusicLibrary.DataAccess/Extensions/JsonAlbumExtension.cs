using DigitalMusicLibrary.DataAccess.Entities;
using DigitalMusicLibrary.DataAccess.JsonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMusicLibrary.DataAccess.Extensions
{
    public static class JsonAlbumExtension
    {
        public static ICollection<Album> ConvertToEntity(this ICollection<JsonAlbum> jsonAlbums)
        {
/*            foreach (var album in jsonAlbums)
            {
                Console.Write(album.Title.ToString());
                Console.Write("WORKS");
            }*/
            ICollection<Album> results = (from jsonAlbum in jsonAlbums
                                   select new Album()
                                   {
                                       Title = jsonAlbum.title,
                                       Description = jsonAlbum.description,
                                       Songs = jsonAlbum.songs.ConvertSongsToEntity(),
                                   }).ToList();
            return results;
        }
    }
}
