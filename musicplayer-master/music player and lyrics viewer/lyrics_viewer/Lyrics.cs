using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lyrics_viewer.Webref;
namespace lyrics_viewer
{
    public class Lyrics : Lyrical
    {
        public string artist = "";
        public string song = "";

        public Lyrics(string songPath)
        {
            var file = TagLib.File.Create(@songPath);
            try
            {
                song = file.Tag.Title;
                artist = file.Tag.AlbumArtists.First();
            }
            catch
            {

            }
        }

        public string showLyrics()
        {
            Webref.apiv1 LyrcService = new Webref.apiv1();
            try
            {
                SearchLyricResult[] x = LyrcService.SearchLyric(artist, song);
                int id = x[0].LyricId;
                string cs = x[0].LyricChecksum;
                GetLyricResult lyc = LyrcService.GetLyric(id, cs);
                return lyc.Lyric;
            }
            catch
            {
                return "Lyrics not found";
            }
        }
    }
}
