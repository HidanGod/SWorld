using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace с_мира_по_нитке.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public string Roles { get; set; }
        public DateTime Date_Registration { get; set; }
        public DateTime Date_Birth { get; set; }
        public string Follow { get; set; }
        public string Follower { get; set; }
        public string Sex { get; set; }
        public string Avatar { get; set; }
        public int Karma { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Job { get; set; }

      

        public ICollection<Post> Posts { get; set; }
        public User()
        {
            Posts = new List<Post>();
        }
    }
}