namespace desarrollo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablePlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        IdPlayer = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Position = c.String(),
                        IdTeam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPlayer)
                .ForeignKey("dbo.team", t => t.IdTeam, cascadeDelete: true)
                .Index(t => t.IdTeam);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Player", "IdTeam", "dbo.team");
            DropIndex("dbo.Player", new[] { "IdTeam" });
            DropTable("dbo.Player");
        }
    }
}
