using System;
using System.Collections.Generic;

namespace ADD_Backend.Object
{
    public class DLList
    {
        private List<Uri> uri_l;

        public List<Uri> Uri_l { get { return uri_l; } }

        public DLList(List<Uri> uriList)
        {
            this.uri_l = uriList;
        }
    }
}
