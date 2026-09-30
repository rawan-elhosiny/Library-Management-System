using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinalProject
{
    public  class Borrowing
    {
        [Key]
        public int ID { get;private set; }
        public bool IsReturned { get; private set; }
        public DateTime BorrowingDate {  get;  set; }
        public DateTime DueDate { get;  set; }
        public DateTime? ReturnDate { get; private set; }
        public double TotalPrice { get;  set; }
        public string NationalId { get; private set; }
        public Customer Customer { get;private  set; } 
        public int BookId { get;private set; }
        public Book Book { get; private set; }
        public string CustomerName => Customer?.Name;
        public string BookName => Book?.Title;

        public int NumberOfDays { get; private set; }
        private Borrowing() { }
        private Borrowing(Customer customer, Book book,DateTime borrowingDate,int numberOfDays,DateTime dueDate, double totalPrice) 
        { 
        
        IsReturned= false;//By default
        BorrowingDate= borrowingDate;
        ReturnDate= null;
        Customer = customer;
        
        Book = book;
        BookId= Book.BookId;
        NumberOfDays = numberOfDays;
        TotalPrice = totalPrice;
        DueDate = dueDate;
        }
        public static Borrowing Create(Customer customer, Book book, DateTime borrowDate, int numberOfDays)
        {
            if (customer == null) throw new ArgumentNullException("customer data is required");
            if (book == null) throw new ArgumentNullException("Book data is required");
            double totalPrice=numberOfDays*book.DailyPrice;
            DateTime calculatedDueDate = borrowDate.AddDays(numberOfDays);
            book.CopiesCount -= 1;
            return new Borrowing (customer, book, borrowDate, numberOfDays, calculatedDueDate, totalPrice);
           
        }
        

        public  double ReturnBook( )
        {
            if (IsReturned)
            {
                throw new InvalidOperationException("This book has already been returned");
            }
            IsReturned = true;
            Book.CopiesCount += 1;
            ReturnDate = DateTime.Today;

            int delayDays = (ReturnDate.Value.Date - DueDate.Date).Days;
            if (delayDays>0)
            {
                double finePerDay = 5;
              double delayPrice= (delayDays * finePerDay);
                TotalPrice+= (delayDays * finePerDay);
                return delayPrice;
            }
            return 0;
        }

    }
}
