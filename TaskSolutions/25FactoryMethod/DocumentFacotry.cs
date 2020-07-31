using System.Collections.Generic;

namespace _25FactoryMethod
{
    public abstract class DocumentFactory
    {
        public static IDocument CreateCV(string name)
        {
            var pages = new List<Page>()
            {
                new Page(){ PageTitle="Skills"},
                new Page(){ PageTitle="Expirience"},
                new Page(){ PageTitle="Education"},
                new Page(){ PageTitle="Personal Information"}
            };
            return new CV() { Pages = pages, Name = name };
        }

        public static IDocument CreateReport(string reportTitle)
        {
            var pages = new List<Page>()
            {
                new Page(){ PageTitle="Description"},
                new Page(){ PageTitle="Appendix"},
            };
            return new Report() { Pages = pages, Title = reportTitle };
        }

        public static IDocument CreateStory(string author)
        {
            var pages = new List<Page>()
            {
                new Page(){ PageTitle="Introduction"},
                new Page(){ PageTitle="Develop"},
                new Page(){ PageTitle="End"}
            };
            return new Story() { Pages = pages, Author = author };
        }
    }
}
