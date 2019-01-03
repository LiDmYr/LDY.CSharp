using System;
using System.Collections.Generic;
using System.Text;

namespace LDY.CSharp.LINQ.Models {
    public class WebSite {
        public string Id { get; }

        public List<Page> Pages { get; }

        public Language MainLanguage { get; set; }

        public WebSite(List<Page> pages, string id) {
            Pages = pages;
            Id = id;
        }
    }
}
