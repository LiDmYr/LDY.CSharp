using System;
using System.Collections.Generic;
using System.Text;

namespace LDY.CSharp.LINQ.Models {
    public class Page {
        public string Id { get; }

        public List<Language> Languages { get; }

        public Page(List<Language> languages, string id) {
            Id = id;
            Languages = languages;
        }
    }
}
