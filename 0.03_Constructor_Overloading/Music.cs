using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Constructor_Overloading
{
    class Music
    {
        public Music(){}

        public Music(string band)
        {
            Band = band;
        }

        public Music(string band, string album)
        {
            Band = band;
            Album = Album;
        }

        public Music(string band, string album, int year)
        {
            Band = band;
            Album = album;
            Date = year;
        }

        public string Band { get; set; }
        public string Album { get; set; }
        public int Date { get; set; }
    }
}
