﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.WEB.Models
{
    public class ContactContext : DbContext
    {
        public DbSet<ContactModel> Contacts { get; set; }

        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
