using Microsoft.EntityFrameworkCore;
using PineBerry_0._0._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry_0._0._1.DataContext
{
    public class MainContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Berry> Berries { get; set; }

        public DbSet<QnA> QnAs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: 일단은 테스트를 위해서 SA로 하니까 나중에 찾아보고 바꿔야 함
            optionsBuilder.UseSqlServer(@"Server = localhost; Database = AspnetClass; User Id = sa; Password = martin03110170@;");
        }
    }
}
