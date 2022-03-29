using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace project_work
{
    public class User
    {
        public User(string first_name, string last_name, string email, string role, string city, string code, string password, string birth_date)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.role = role;
            this.city = city;
            this.code = code;
            this.password = password;
            this.birth_date = birth_date;
            bookedbooks=new BindingList<Book>();
        }
        private string email;
        public string first_name{get;set;}
        public string last_name{get;set;}
        public string Email 
        { 
            get { return email; } 
            set { 
                if (value.Contains("@") && value.Contains("."))
                    email = value; 
                else 
                    MessageBox.Show("email errata"); 
            }}
        public string role{get;set;}
        public string city{get;set;}
        public string code{get;set;}
        public string password{get;set;}
        public string birth_date{get;set;}
        public BindingList<Book> bookedbooks {get;set;}
    }
}
