using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200Team8.Models;
using System.Data.Entity;

namespace MIS4200Team8.DAL
{
    public class Context8 : DbContext
    {
        public Context8() : base ("name=DefaultConnection")
        {

        }

        public DbSet<UserDetail> UserDetails { get; set; }
        
    }
}