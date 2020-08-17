using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SendEmailProject.Models
{
    public class SendEmailProjectContext : DbContext
    {
        public SendEmailProjectContext (DbContextOptions<SendEmailProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SendEmailProject.Models.EmailModel> EmailModel { get; set; }
    }
}
