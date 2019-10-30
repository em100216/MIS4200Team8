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
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<sendPoints> sendPoints { get; set; }

        
    }
}