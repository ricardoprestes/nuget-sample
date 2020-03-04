using System;
using System.IO;
using NugetMultiSample.Abstractions;
using NugetMultiSample.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelperiOS))]
namespace NugetMultiSample.Helpers
{
    public class FileHelperiOS : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library");
            if (!Directory.Exists(libFolder))
                Directory.CreateDirectory(libFolder);

            return Path.Combine(libFolder, filename);
        }
    }
}
