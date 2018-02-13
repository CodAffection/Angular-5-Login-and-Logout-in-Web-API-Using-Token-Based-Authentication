namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDefaultTableNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetRoles", newName: "Role");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "UserRole");
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClaim");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "UserLogin");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserLogin", newName: "AspNetUserLogins");
            RenameTable(name: "dbo.UserClaim", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
            RenameTable(name: "dbo.UserRole", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.Role", newName: "AspNetRoles");
        }
    }
}
