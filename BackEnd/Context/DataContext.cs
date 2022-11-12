using AcademyTest.Entities;
using AcademyTest.Repositories;

using Microsoft.EntityFrameworkCore;

namespace AcademyTest.Context{
    public class DataContext:DbContext{
        public DataContext(DbContextOptions <DataContext> options): base(options){}

        public DbSet <User> Users => Set<User>();
        public DbSet <InventoryItem> Items => Set<InventoryItem>();

        
    }
}