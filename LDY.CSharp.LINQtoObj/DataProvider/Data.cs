using System;
using System.Collections.Generic;
using System.Text;
using LDY.CSharp.LINQ.Models;

namespace LDY.CSharp.LINQ.DataProvider {
    public class Data : IData {
        public WebSite GetWebSite() {
            return new WebSite(GetPages(),"w1");
        }

        private List<Page> GetPages() {
            Dictionary<string, Language> languages = GetLanguages();
            return new List<Page>() {
                new Page(new List<Language>(){ languages["English"] },"p1"),
                new Page(new List<Language>(){ languages["English"], languages["German"] },"p2"),
                new Page(new List<Language>(){ languages["Danish"], languages["Italian"] },"p3"),
                new Page(new List<Language>(){ languages["English"], languages["Danish"] },"p4"),
            };
        }

        private Dictionary<string, Language> GetLanguages() {
            return new Dictionary<string, Language>() {
                {"English" , new Language("English", new char[]{'a', 'b', 'e'}, "l1")},
                {"German" , new Language("German", new char[]{'a', 'b', 'c', 'g'},"l2")},
                {"Italian" , new Language("Italian", new char[]{'a', 'c', 'i'}, "l3")},
                {"Danish" , new Language("Danish", new char[]{'a', 'c', 'd'}, "l4")}
            };
        }
    }
}
