using DemoWebPage.Models;
using DemoWebPage.VModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       static List<Author> authors = new List<Author>()
            {
                new Author(){ Id = 1, Name="Bill"},
                new Author(){ Id = 2, Name="Steve"},
                new Author(){ Id = 3, Name="Ram"},
                new Author(){ Id = 4, Name="Abdul"},
                new Author(){ Id = 5, Name="Fuad"},
                new Author(){ Id = 6, Name="Murad"},
                new Author(){ Id = 7, Name="Nihad"},
                new Author(){ Id = 8, Name="Orxan"}
            };

        static List<Topic> topics = new List<Topic>()
            {
                new Topic(){Id=1, Name="P2p Loan"},
                new Topic(){Id=2, Name="Blokchain"}
            };

       static List<Country> countries = new List<Country>() {
            new Country(){Id=1, Name="UK"},
            new Country(){Id=2, Name="US"},
            new Country(){Id=3, Name = "China"}
            };

       static List<DocumentType> documentTypes = new List<DocumentType>()
            {
                new DocumentType(){Id=1, Name=".pdf"},
                new DocumentType(){Id=2, Name=".txt"},
                new DocumentType(){Id=3, Name=".word"}
            };

       static List<Organization> organizations = new List<Organization>()
            {
                new Organization(){Id = 1, Name="BMT"},
                new Organization(){Id = 2, Name="CTNB"},
                new Organization(){Id = 3, Name="KTMT"}
            };

       static List<Publisher> publishers = new List<Publisher>()
            {
                new Publisher(){
                    Id = 1, Author = authors[0],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 2, Author = authors[1],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Info Blokchain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 3, Author = authors[2],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
                       new Publisher(){
                    Id = 4, Author = authors[3],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 5, Author = authors[4],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Wornings BlogChain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 6, Author = authors[5],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
                    new Publisher(){
                    Id = 7, Author = authors[0],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 8, Author = authors[1],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Info Blokchain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 9, Author = authors[2],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
                       new Publisher(){
                    Id = 10, Author = authors[3],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 11, Author = authors[4],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Wornings BlogChain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 12, Author = authors[5],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
                       new Publisher(){
                    Id = 13, Author = authors[0],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 14, Author = authors[1],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Info Blokchain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 15, Author = authors[2],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
                       new Publisher(){
                    Id = 16, Author = authors[3],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 17, Author = authors[4],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Wornings BlogChain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 18, Author = authors[5],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
                    new Publisher(){
                    Id = 19, Author = authors[0],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 20, Author = authors[1],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Info Blokchain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 21, Author = authors[2],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
                       new Publisher(){
                    Id = 22, Author = authors[3],
                    Organization = organizations[0], DocumentType= documentTypes[0],
                    Country = countries[0], Topic = topics[0],
                    FileName = "Wornings P2PLoan", FilePath="skjnfrfwenf'oewf"
                },
                 new Publisher(){
                    Id = 23, Author = authors[4],
                    Organization = organizations[1], DocumentType= documentTypes[1],
                    Country = countries[1], Topic = topics[1],
                    FileName = "Wornings BlogChain", FilePath="skjnfrfwenf'oewf"
                },
                  new Publisher(){
                    Id = 24, Author = authors[5],
                    Organization = organizations[2], DocumentType= documentTypes[2],
                    Country = countries[2], Topic = topics[0],
                    FileName = "Info P2PLoan in UK", FilePath="skjnfrfwenf'oewf",
                },
            };

        public IActionResult Index()
        {

            return View(publishers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult P2pLoan()
        {
            PublisherVM publisherVM = new PublisherVM()
            {
                Publishers = publishers,
                Authors = authors,
                Countries = countries,
                DocumentTypes = documentTypes,
                Topics = topics,
                Organizations = organizations
            };
            return View(publisherVM);
        }

        
        public IActionResult GetList(int[] authorList, int[] organizationList, int[] countryList, int[] documentList, int[] topicList)
        {
           // , int[] organizationList, int[] countryList, int[] documentList, int[] topicList
            return PartialView("_ListPartialView");
        }
    }
}
