using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wareman.Service
{
    public class Clients
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? LastLoginDate { get; set; }


        public List<Clients> BuildClients()
        {
            var list = new List<Clients>
            {
                new Clients{
                Id = 1,
                Email = "kennymore007@yahoo.com",
                Password = "thanks"
                }, new Clients{
                    Id= 2,
                    Email = "press.spark@gmail.com",
                    Password = "merci"
                }
            };
            return list;
        }
    }
}
