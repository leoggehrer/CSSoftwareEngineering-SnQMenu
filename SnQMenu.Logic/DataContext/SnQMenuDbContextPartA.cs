//@GeneratedCode
namespace SnQMenu.Logic.DataContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    partial class SnQMenuDbContext
    {
        protected DbSet<Entities.Persistence.MasterData.AvailableLanguage> AvailableLanguageSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.MasterData.Restaurant> RestaurantSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Food.Menu> MenuSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Food.MenuItem> MenuItemSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Food.MenuSection> MenuSectionSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Account.Access> AccessSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Account.ActionLog> ActionLogSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Account.Identity> IdentitySet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Account.IdentityXRole> IdentityXRoleSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Account.LoginSession> LoginSessionSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Account.Role> RoleSet
        {
            get;
            set;
        }
        protected DbSet<Entities.Persistence.Account.User> UserSet
        {
            get;
            set;
        }
        partial void GetDbSet<C, E>(ref DbSet<E> dbSet) where E : class
        {
            if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IAvailableLanguage))
            {
                dbSet = AvailableLanguageSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.MasterData.IRestaurant))
            {
                dbSet = RestaurantSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenu))
            {
                dbSet = MenuSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuItem))
            {
                dbSet = MenuItemSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Food.IMenuSection))
            {
                dbSet = MenuSectionSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IAccess))
            {
                dbSet = AccessSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IActionLog))
            {
                dbSet = ActionLogSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentity))
            {
                dbSet = IdentitySet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IIdentityXRole))
            {
                dbSet = IdentityXRoleSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.ILoginSession))
            {
                dbSet = LoginSessionSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IRole))
            {
                dbSet = RoleSet as DbSet<E>;
            }
            else if (typeof(C) == typeof(SnQMenu.Contracts.Persistence.Account.IUser))
            {
                dbSet = UserSet as DbSet<E>;
            }
        }
        static partial void DoModelCreating(ModelBuilder modelBuilder)
        {
            var availableLanguageBuilder = modelBuilder.Entity<Entities.Persistence.MasterData.AvailableLanguage>();
            availableLanguageBuilder.ToTable("AvailableLanguage", "MasterData")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.MasterData.AvailableLanguage>().Property(p => p.RowVersion).IsRowVersion();
            availableLanguageBuilder.Property(p => p.Text)
            .HasMaxLength(64);
            availableLanguageBuilder
            .HasIndex(c => new
            {
                c.RestaurantId
                , c.LanguageCode
            }
            )
            .IsUnique();
            ConfigureEntityType(availableLanguageBuilder);
            var restaurantBuilder = modelBuilder.Entity<Entities.Persistence.MasterData.Restaurant>();
            restaurantBuilder.ToTable("Restaurant", "MasterData")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.MasterData.Restaurant>().Property(p => p.RowVersion).IsRowVersion();
            restaurantBuilder.Property(p => p.Guid)
            .IsRequired()
            .HasDefaultValueSql("NEWID()");
            restaurantBuilder.Property(p => p.ImageUrl)
            .HasMaxLength(256);
            restaurantBuilder
            .HasIndex(c => c.UniqueName)
            .IsUnique();
            restaurantBuilder.Property(p => p.UniqueName)
            .IsRequired()
            .HasMaxLength(256);
            restaurantBuilder.Property(p => p.DisplayName)
            .IsRequired()
            .HasMaxLength(256);
            restaurantBuilder.Property(p => p.Description)
            .HasMaxLength(2048);
            restaurantBuilder.Property(p => p.WebsiteText)
            .HasMaxLength(1024);
            ConfigureEntityType(restaurantBuilder);
            var menuBuilder = modelBuilder.Entity<Entities.Persistence.Food.Menu>();
            menuBuilder.ToTable("Menu", "Food")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Food.Menu>().Property(p => p.RowVersion).IsRowVersion();
            menuBuilder.Property(p => p.Guid)
            .IsRequired()
            .HasDefaultValueSql("NEWID()");
            menuBuilder.Property(p => p.Notes)
            .HasMaxLength(1024);
            ConfigureEntityType(menuBuilder);
            var menuItemBuilder = modelBuilder.Entity<Entities.Persistence.Food.MenuItem>();
            menuItemBuilder.ToTable("MenuItem", "Food")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Food.MenuItem>().Property(p => p.RowVersion).IsRowVersion();
            menuItemBuilder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(256);
            menuItemBuilder.Property(p => p.Description)
            .HasMaxLength(1024);
            menuItemBuilder.Property(p => p.Guid)
            .IsRequired()
            .HasDefaultValueSql("NEWID()");
            menuItemBuilder.Property(p => p.ImageUrl)
            .HasMaxLength(256);
            menuItemBuilder.Property(p => p.InternalName)
            .HasMaxLength(64);
            menuItemBuilder.Property(p => p.AllergenType)
            .HasMaxLength(30);
            ConfigureEntityType(menuItemBuilder);
            var menuSectionBuilder = modelBuilder.Entity<Entities.Persistence.Food.MenuSection>();
            menuSectionBuilder.ToTable("MenuSection", "Food")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Food.MenuSection>().Property(p => p.RowVersion).IsRowVersion();
            menuSectionBuilder.Property(p => p.Guid)
            .IsRequired()
            .HasDefaultValueSql("NEWID()");
            menuSectionBuilder.Property(p => p.ImageUrl)
            .HasMaxLength(256);
            menuSectionBuilder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(256);
            menuSectionBuilder.Property(p => p.Description)
            .HasMaxLength(1024);
            ConfigureEntityType(menuSectionBuilder);
            var accessBuilder = modelBuilder.Entity<Entities.Persistence.Account.Access>();
            accessBuilder.ToTable("Access", "Account")
            .HasKey("Id");
            accessBuilder
            .HasIndex(c => c.Key)
            .IsUnique();
            accessBuilder.Property(p => p.Key)
            .IsRequired()
            .HasMaxLength(512);
            accessBuilder.Property(p => p.Value)
            .HasMaxLength(4096);
            ConfigureEntityType(accessBuilder);
            var actionLogBuilder = modelBuilder.Entity<Entities.Persistence.Account.ActionLog>();
            actionLogBuilder.ToTable("ActionLog", "Account")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Account.ActionLog>().Property(p => p.RowVersion).IsRowVersion();
            ConfigureEntityType(actionLogBuilder);
            var identityBuilder = modelBuilder.Entity<Entities.Persistence.Account.Identity>();
            identityBuilder.ToTable("Identity", "Account")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Account.Identity>().Property(p => p.RowVersion).IsRowVersion();
            identityBuilder.Property(p => p.Guid)
            .IsRequired()
            .HasMaxLength(36);
            identityBuilder
            .HasIndex(c => c.Name)
            .IsUnique();
            identityBuilder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(128);
            identityBuilder
            .HasIndex(c => c.Email)
            .IsUnique();
            identityBuilder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(128);
            identityBuilder
            .Ignore(c => c.Password);
            ConfigureEntityType(identityBuilder);
            var identityXRoleBuilder = modelBuilder.Entity<Entities.Persistence.Account.IdentityXRole>();
            identityXRoleBuilder.ToTable("IdentityXRole", "Account")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Account.IdentityXRole>().Property(p => p.RowVersion).IsRowVersion();
            ConfigureEntityType(identityXRoleBuilder);
            var loginSessionBuilder = modelBuilder.Entity<Entities.Persistence.Account.LoginSession>();
            loginSessionBuilder.ToTable("LoginSession", "Account")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Account.LoginSession>().Property(p => p.RowVersion).IsRowVersion();
            loginSessionBuilder
            .Ignore(c => c.IsRemoteAuth);
            loginSessionBuilder
            .Ignore(c => c.Origin);
            loginSessionBuilder
            .Ignore(c => c.Name);
            loginSessionBuilder
            .Ignore(c => c.Email);
            loginSessionBuilder
            .Ignore(c => c.TimeOutInMinutes);
            loginSessionBuilder
            .Ignore(c => c.JsonWebToken);
            loginSessionBuilder.Property(p => p.SessionToken)
            .IsRequired()
            .HasMaxLength(128);
            loginSessionBuilder.Property(p => p.OptionalInfo)
            .HasMaxLength(4096);
            ConfigureEntityType(loginSessionBuilder);
            var roleBuilder = modelBuilder.Entity<Entities.Persistence.Account.Role>();
            roleBuilder.ToTable("Role", "Account")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Account.Role>().Property(p => p.RowVersion).IsRowVersion();
            roleBuilder
            .HasIndex(c => c.Designation)
            .IsUnique();
            roleBuilder.Property(p => p.Designation)
            .IsRequired()
            .HasMaxLength(64);
            roleBuilder.Property(p => p.Description)
            .HasMaxLength(256);
            ConfigureEntityType(roleBuilder);
            var userBuilder = modelBuilder.Entity<Entities.Persistence.Account.User>();
            userBuilder.ToTable("User", "Account")
            .HasKey("Id");
            modelBuilder.Entity<Entities.Persistence.Account.User>().Property(p => p.RowVersion).IsRowVersion();
            userBuilder
            .HasIndex(c => c.IdentityId)
            .IsUnique();
            userBuilder.Property(p => p.Firstname)
            .HasMaxLength(64);
            userBuilder.Property(p => p.Lastname)
            .HasMaxLength(64);
            ConfigureEntityType(userBuilder);
        }
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.MasterData.AvailableLanguage> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.MasterData.Restaurant> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Food.Menu> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Food.MenuItem> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Food.MenuSection> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.Access> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.ActionLog> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.Identity> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.IdentityXRole> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.LoginSession> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.Role> entityTypeBuilder);
        static partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.User> entityTypeBuilder);
    }
}
