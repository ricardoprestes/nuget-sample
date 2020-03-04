using System;
using NugetMultiSample.Abstractions;

//[assembly: Dependency(typeof(FileHelperiOS))]
namespace NugetMultiSample.Helpers
{
    public class FileHelperiOS : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
