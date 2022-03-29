using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace project_work
{
    public class Loan
    {
        public Loan(string isbn, string usercode, DateTime initialdate, DateTime enddate, string rating)
        {
            Isbn = isbn;
            Usercode = usercode;
            Initialdate = initialdate;
            Enddate = enddate;
            Rating = rating;
        }

        public string Isbn{get;set;}
        public string Usercode { get; set; }
        public DateTime Initialdate { get; set; }
        public DateTime Enddate { get; }
        public string Rating { get; set; }
    }   
}
