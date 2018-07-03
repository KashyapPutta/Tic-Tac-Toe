namespace WinStatus.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserPasswords",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.WinClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserWins = c.Int(nullable: false),
                        MachineWins = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WinClasses");
            DropTable("dbo.UserPasswords");
        }
    }
}
