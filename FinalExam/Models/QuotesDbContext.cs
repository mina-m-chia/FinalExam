using System;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Models
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext (DbContextOptions<QuotesDbContext> options) : base (options)
        { }

        public DbSet<Quote> Quotes { get; set; }

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quote>().HasData(

                new Quote
                {
                    QuoteID = 1,
                    Text = "Spencer out",
                    Author = "Spencer Hilton",
                    Date = "1/8/22",
                    Subject = "Inspirational",
                    Citation = "BYU Box"
                }

                );
        }
    }
}
