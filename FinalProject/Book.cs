using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public double DailyPrice { get;private set; }
        public string Author { get; set; }
        public int CopiesCount { get; set; }
        public List <Borrowing>Borrowings { get; set; }

        private Book() { }
        private Book(string title,double dailyPrice,string author,int copiescount )
        {
            Title = title;
            DailyPrice = dailyPrice;
                Author = author;
            CopiesCount = copiescount;
        }
        public static Book Create(string title, double dailyPrice, string author, int copiescount)
        {
            
            return new Book(title,dailyPrice,author,copiescount);   
        }
        
       
    }
}
