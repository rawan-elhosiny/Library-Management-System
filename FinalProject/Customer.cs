using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Text;

namespace FinalProject
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string NationalId { get;  set; }
        public string Name { get; private set; }
        
        public string Phone { get;private  set; }
        public string  Email { get; private set; }
        
        public List<Borrowing> Borrowings { get; set; }

        private Customer () { }//بمنع ان انا اعمل اوبجكت فاضي 
        private Customer(string id, string name,string phone , string email) {
        
            Phone = phone;
            NationalId=id;
            Name = name; 
            Email = email;
        } 
        public static Customer Add ( string id,string name, string phone, string email)
        {
            return new Customer (id,name, phone, email);
        }
        
    }
}
