using System;

namespace ADD_Backend.Object
{
    public class DLParams
    {
        private string name;
        private Uri uri_s;

        public string Name { get { return name; } }
        public Uri Uri_s { get { return uri_s; } }

        public DLParams (Uri uri, string name)
        {
            this.name = name;
            this.uri_s = uri;
        }
    }
}
