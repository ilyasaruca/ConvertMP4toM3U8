using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMP4toM3U8
{
    class Program
    {
        static void Main(string[] args)
        {
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();

            ffMpeg.GetVideoThumbnail("input file path", "output_thumbnail_file.jpg");

            Console.Write("Thumbnail Created."); 
        }
    }
}
