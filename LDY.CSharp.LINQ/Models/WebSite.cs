using System;
using System.Collections.Generic;
using System.Text;

namespace LDY.CSharp.LINQ.Models {
    public class WebSite {
        public int id { get; }

        public List<Page> Pages { get; }

        public Language MainLanguage { get; set; }
    }
}
