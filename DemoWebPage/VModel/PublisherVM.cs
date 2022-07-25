using DemoWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DemoWebPage.VModel
{
    public class PublisherVM
    {
        public List<DemoWebPage.Models.Publisher> Publishers { get; set; }
        public List<Author> Authors { get; set; }
        public List<DocumentType> DocumentTypes { get; set; }
        public List<Country> Countries { get; set; }
        public List<Organization> Organizations { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
