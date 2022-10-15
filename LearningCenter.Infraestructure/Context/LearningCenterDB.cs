using System;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infraestructure.Context;

public class LearningCenterDB : DbContext
{
    public DbSet<Category> Categories { get; set; }  
    public DbSet<Tutorial> Tutorials { get; set; }  
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)

    {
        builder.Entity<Category>().ToTable("Categories");
        
        builder.Entity<Category>().HasKey(p => p.id);

        builder.Entity<Category>().Property(p => p.id).IsRequired().ValueGeneratedOnAdd();

        builder.Entity<Category>().Property(c => c.name).IsRequired().HasMaxLength(60);

        builder.Entity<Category>().Property(c => c.DateCreted).IsRequired().HasDefaultValue(DateTime.Now);

        builder.Entity<Category>().Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
   
        builder.Entity<Tutorial>().ToTable("Tutorials");

        builder.Entity<Tutorial>().HasKey(p => p.id);



        builder.Entity<User>().ToTable("Users");

        builder.Entity<User>().HasKey(p => p.id);
    }
}