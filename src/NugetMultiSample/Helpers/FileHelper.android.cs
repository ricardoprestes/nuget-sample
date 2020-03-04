using System;
using System.IO;
using NugetMultiSample.Abstractions;
using NugetMultiSample.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelperAndroid))]
namespace NugetMultiSample.Helpers
{
    public class FileHelperAndroid : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
