using System;
using Microsoft.EntityFrameworkCore;
using SKL.Report.Core.Models;

namespace SKL.Report.Core.Services
{
    public class ReportDBContext : DbContext
    {
        public ReportDBContext(DbContextOptions<ReportDBContext> options) : base(options)
        {
        }
        public DbSet<rpt_info> rpt_Infos { get; set; }
        public DbSet<rpt_modules> rpt_Modules { get; set; }
        public DbSet<rpt_comment> rpt_Comments { get; set; }
        public DbSet<rpt_user> rpt_Users { get; set; }
        public DbSet<rpt_userscores> rpt_Userscores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<rpt_info>().ToTable("rpt_info");
            modelBuilder.Entity<rpt_modules>().ToTable("rpt_modules");
            modelBuilder.Entity<rpt_comment>().ToTable("rpt_comment");
            modelBuilder.Entity<rpt_user>().ToTable("rpt_user");
            modelBuilder.Entity<rpt_userscores>().ToTable("rpt_userscores");
        }
    }
}
