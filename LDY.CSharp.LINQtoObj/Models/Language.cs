using System;
using System.Collections.Generic;
using System.Text;

namespace LDY.CSharp.LINQ.Models {
    public class Language {
        public string Id { get; }

        public string Name { get; }

        public char[] Alphabet { get; }

        public Language(string name, char[] alphabet, string id) {
            Name = name;
            Alphabet = alphabet;
            Id = id;
        }
    }
}
