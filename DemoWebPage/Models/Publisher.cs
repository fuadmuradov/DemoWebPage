using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebPage.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public Country Country { get; set; }
        public DocumentType DocumentType { get; set; }
        public Organization Organization { get; set; }
        public Topic Topic { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
