using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GStore.Data

public class AppDbContext : IdentityDbContext<Usuario>

{    public class AppDbContext
    {
        
    }

    public DbSet<>

    protected override  void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Definindo nomes do Identity
        builder.Entity<IdentityUser>().ToTable("usuario");
        builder.Entity<IdentityRole>().ToTable("perfil");
        builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfil");
        builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_regra");
        builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");
        builder.Entity<IdentityUserToken<string>>().ToTable("usuario_token");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("perfil_regra");
        #endregion
    }
}