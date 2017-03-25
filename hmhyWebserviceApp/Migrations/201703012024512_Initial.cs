namespace hmhyWebserviceApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainUser",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userCreds_userId = c.Int(nullable: false),
                        userCreds_userName = c.String(),
                        userCreds_password = c.String(),
                        
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MainUser");
        }
    }
}
