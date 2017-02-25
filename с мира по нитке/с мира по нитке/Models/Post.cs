using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace с_мира_по_нитке.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Zaglav { get; set; }
        public string Text { get; set; }
        public int Karma { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
        public int Prosmotrov { get; set; }
        public string Category { get; set; }
        public string Razdel { get; set; }
        public string Kratk { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}