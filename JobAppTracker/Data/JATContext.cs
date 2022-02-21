using JobAppTracker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Data
{
    public class JATContext : DbContext
    {

        //Property to hold the UserName value
        public string UserName
        {
            get; private set;
        }

        public JATContext(DbContextOptions<JATContext> options) : base(options)
        {
            UserName = "SeedData";
        }

        //To give access to IHttpContextAccessor for Audit Data with IAuditable
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JATContext(DbContextOptions<JATContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            UserName = _httpContextAccessor.HttpContext?.User.Identity.Name;
            UserName = UserName ?? "Unknown";
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Employer> Employers { get; set; }

        public DbSet<Application> Applications { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Posting> Postings { get; set; }
        public DbSet<Status> Statuses { get; set; }

        //Model Builder Event
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Add a unique index to the Country
            modelBuilder.Entity<Country>()
            .HasIndex(c => new { c.Name})
            .IsUnique();

            //Add a unique index to the Employer Name
            modelBuilder.Entity<Employer>()
            .HasIndex(e => new { e.Name })
            .IsUnique();


            //Many to Many Intersection
            modelBuilder.Entity<JobType>()
            .HasKey(t => new { t.TypeID, t.ApplicationID });

            //Many to Many Intersection
            modelBuilder.Entity<PostingType>()
            .HasKey(t => new { t.TypeID, t.PostingID });


            //Prevent Cascade Delete from Employer to Application
            //so we are prevented from deleting an Employer with
            //Applications assigned
            modelBuilder.Entity<Employer>()
                .HasMany<Application>(e => e.Applications)
                .WithOne(a => a.Employer)
                .HasForeignKey(a => a.EmployerID)
                .OnDelete(DeleteBehavior.Restrict);

            //Prevent Cascade Delete JobType
            modelBuilder.Entity<JobType>()
                .HasOne(jt => jt.Type)
                .WithMany(t => t.JobTypes)
                .HasForeignKey(jt => jt.TypeID)
                .OnDelete(DeleteBehavior.Restrict);

            //Prevent Cascade Delete PostingType
            modelBuilder.Entity<PostingType>()
                .HasOne(pt => pt.Type)
                .WithMany(t => t.PostingTypes)
                .HasForeignKey(pt => pt.TypeID)
                .OnDelete(DeleteBehavior.Restrict);


            //Cascading Delete Behavior


        }


    }
}
