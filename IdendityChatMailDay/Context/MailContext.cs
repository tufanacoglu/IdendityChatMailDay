using IdendityChatMailDay.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdendityChatMailDay.Context
{
    public class MailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Tufan;Initial Catalog=EmailChatDb;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
