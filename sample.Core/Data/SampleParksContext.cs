namespace sample.Core.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SampleParksContext : DbContext
    {
        public SampleParksContext()
            : base("name=SampleParksContext")
        {
        }

        public virtual DbSet<Park> Parks { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Park>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Parks)
                .Map(m => m.ToTable("ParksTags").MapLeftKey("ParksId").MapRightKey("TagsId"));
        }
    }
}
