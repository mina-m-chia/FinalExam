using System;
using System.Linq;

namespace FinalExam.Models
{
    public interface IQuotesRepository
    {
        IQueryable<Quote> Quotes { get; }

        public void SaveQuote(Quote q);

        public void CreateQuote(Quote q);

        public void DeleteQuote(Quote q);
    }
}
