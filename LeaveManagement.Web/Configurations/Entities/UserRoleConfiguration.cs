using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a",
                    UserId = "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a",
                    UserId = "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01"
                }
            );
        }
    }
}