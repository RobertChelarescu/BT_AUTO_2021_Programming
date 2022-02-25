using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Other.ExtensionFile
{
    class CredentialsDbContext : DbContext
    {
        public DbSet<EFModels.CredentialsAG> credentialsAG { get; set; }
        private string connectionString;

        // Use base constructor with options
        public CredentialsDbContext(DbContextOptions<CredentialsDbContext> options) : base(options)
        {

        }

        // Constructor with connection string
        public CredentialsDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

    }
}

