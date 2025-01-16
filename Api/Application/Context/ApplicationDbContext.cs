using Application.Context;
using Domain.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        #region Constractor

        /// <summary>
        /// Application database context
        /// </summary>
        /// <param name="options">Request: Db context</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer("Data Source=UT-LTP-887;Initial Catalog=TaskManagement;Persist Security Info=True;User ID=sa;Password=Utthunga@2024;Trust Server Certificate=True");


        #region Public properties

        public DbSet<User> Users { get; set; } = null!;

        #endregion
    }
}
