using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    using Collage;
    using System.IO;

    public class CollageSettings
    {
        public CollageSettings(
            CollageDimensionSettings collageDimensionSettings,            
            List<FileInfo> inputFiles,
            DirectoryInfo outputDirectory)
        {
            this.Dimensions = collageDimensionSettings;            
            this.InputFiles = inputFiles;
            this.OutputDirectory = outputDirectory;
        }

        public CollageDimensionSettings Dimensions { get; private set; }
        public List<FileInfo> InputFiles { get; private set; }
        public DirectoryInfo OutputDirectory { get; private set; }
    }
}
