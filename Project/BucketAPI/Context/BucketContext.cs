using Bucket.Models;
using Microsoft.EntityFrameworkCore;

namespace Bucket.Context
{
    public class BucketContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            builder.Entity<User>()
                .HasIndex(e=>e.UserEmail)
                .IsUnique();
        }
        public DbSet<ProjectTag> ProjectTags { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Like> Likes { get; set; }

        public BucketContext(DbContextOptions<BucketContext> options) : base(options) { }
    }
}
