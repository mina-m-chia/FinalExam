using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalExam.Models;

namespace FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private IQuotesRepository repo { get; set; }

        public HomeController(IQuotesRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var quotes = repo.Quotes
                .OrderBy(x => x.Author)
                .ToList();

            return View(quotes);
        }

        public IActionResult Details(int quoteid)
        {
            var quote = repo.Quotes
                .Where(x => x.QuoteID == quoteid)
                .FirstOrDefault();

            return View(quote);
        }

        [HttpGet]
        public IActionResult AddQuote()
        {
            var quote = repo.Quotes.Select(x => x.QuoteID);

            return View("AddEditQuote");
        }

        [HttpPost]
        public IActionResult AddQuote(Quote q)
        {
            if (ModelState.IsValid)
            {
                repo.CreateQuote(q);

                return View("Confirmation", q);
            }
            else
            {
                return View("AddEditQuote");
            }
        }

        [HttpGet]
        public IActionResult Edit(int quoteid)
        {
            var quote = repo.Quotes
                .Where(x => x.QuoteID == quoteid)
                .FirstOrDefault();

            return View("AddEditQuote", quote);
        }

        [HttpPost]
        public IActionResult Edit(Quote q)
        {
            repo.SaveQuote(q);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int quoteid)
        {
            var quote = repo.Quotes.Single(x => x.QuoteID == quoteid);

            return View(quote);
        }

        [HttpPost]
        public IActionResult Delete(Quote q)
        {
            repo.DeleteQuote(q);

            return RedirectToAction("Index");
        }

        public IActionResult Random()
        {
            Random rdm = new Random();

            //find id of latest record
            var lastRecord = repo.Quotes.OrderByDescending(x => x.QuoteID).First();
            int count = lastRecord.QuoteID + 1;

            //grab random id
            int num = rdm.Next(1, count);

            //to make sure id isn't an id that was deleted earlier
            bool exists = repo.Quotes.Any(x => x.QuoteID == num);

            var quote = repo.Quotes
                    .Where(x => x.QuoteID == num)
                    .FirstOrDefault();

            if (exists)
            {
                quote = repo.Quotes
                    .Where(x => x.QuoteID == num)
                    .FirstOrDefault();
            }
            //if id was deleted, just grab the next id
            else
            {
                quote = repo.Quotes
                    .Where(x => x.QuoteID == (num + 1))
                    .FirstOrDefault();
            }
            return View(quote);
        }


    }
}
