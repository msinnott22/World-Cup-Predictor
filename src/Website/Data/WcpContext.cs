using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Data.Dto;
using Data.Interfaces;

namespace Data
{
    public class WcpContext : DbContext
    {
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Prediction> Predictions { get; set; }
        public DbSet<Player> Players { get; set; }

        public WcpContext() : base("name=WCP")
        {
        }

        public WcpContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer(new NullDatabaseInitializer<WcpContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Teams)
                .WithRequired(t => t.Group);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Predictions)
                .WithRequired(p => p.Game);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Players)
                .WithRequired(p => p.Game);

            modelBuilder.Entity<Player>()
                .HasMany(p => p.Predictions)
                .WithRequired(p => p.Player);
        }

        public T Load<T>(Guid id) where T : class, IEntity
        {
            return Set<T>().FirstOrDefault(x => x.Id.Equals(id));
        }

        public IQueryable<T> Query<T>() where T : class, IEntity
        {
            return Set<T>();
        }

        public void Insert<T>(T item) where T : class, IEntity
        {
            Set<T>().Add(item);
        }

        public void Delete<T>(T item) where T : class, IEntity
        {
            Set<T>().Remove(item);
        }
    }
}
