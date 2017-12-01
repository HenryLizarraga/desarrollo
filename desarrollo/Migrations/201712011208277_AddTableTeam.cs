namespace desarrollo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableTeam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.team",
                c => new
                    {
                        IdTeam = c.Int(nullable: false, identity: true),
                        TeamNaME = c.String(),
                    })
                .PrimaryKey(t => t.IdTeam);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.team");
        }
    }
}
