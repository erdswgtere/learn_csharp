

namespace Echelon
{
    public class GetFiles
    {
        public class Folders : IFolders
        {
            public Folders(string source, string target)
            {
                Source = source;
                Target = target;
            }

            public string Source { get; }
            public string Target { get; }
        }
    }
}
