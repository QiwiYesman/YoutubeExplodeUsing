using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    public class FilePath
    {
        string file_name = "";
        public string NameOnly
        {
            get => file_name;
            set => file_name = ReplaceInvalidChars(value);
        }
        public string Extension { get; set; } = "";
        public string Folder { get; set; } = "/storage/Download";
        public string Name => NameOnly + "." + Extension;
        public string FullPath => Path.Combine(Folder, Name);       
        public string FullPathWithoutExt => Path.Combine(Folder, NameOnly);
        static string ReplaceInvalidChars(string filename)=>
            string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));

    }
}
