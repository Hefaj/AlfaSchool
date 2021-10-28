using AlfaSchool.Repository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlfaSchool.Repository.DbAccess.Model;

namespace AlfaSchool.Repository.DbAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
