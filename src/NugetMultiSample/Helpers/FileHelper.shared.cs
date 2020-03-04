using NugetMultiSample.Abstractions;
using Xamarin.Forms;

namespace NugetMultiSample.Helpers
{
    public class FileHelper
    {
        public string GetLocalFilePath(string filename)
            => DependencyService.Get<IFileHelper>().GetLocalFilePath(filename);
    }
}
