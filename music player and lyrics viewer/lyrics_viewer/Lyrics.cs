using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lyrics_viewer.Webref;
namespace lyrics_viewer
{
    class Lyrics
    {
        public static string Lyric(string artist,string song)
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
