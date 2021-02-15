using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMgnt_WebAPI.Models;

namespace StudentMgnt_WebAPI.Data
{
    public class StudentMgnt_WebAPIContext : DbContext
    {
        public StudentMgnt_WebAPIContext (DbContextOptions<StudentMgnt_WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMgnt_WebAPI.Models.Student> Student { get; set; }
    }
}
