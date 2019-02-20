using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityLab.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Users(int ID, string FirstName, string LastName, string Email, string Phone)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }

        public Users()
        {

        }
    }

    public class DBEntityLab : DbContext
    {
        public DbSet<Users> Users { get; set; }
    }
}
