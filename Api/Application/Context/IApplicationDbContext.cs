using Domain.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Application.Context
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
    }
}
