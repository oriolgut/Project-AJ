namespace AJ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AJModel",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        KW = c.Int(nullable: false),
                        Montag = c.String(),
                        Dienstag = c.String(),
                        Mittwoch = c.String(),
                        Donnerstag = c.String(),
                        Freitag = c.String(),
                        Wochenrückblick = c.String(),
                        Lupe_der_Woche = c.String(),
                        Reflexion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AJModel");
        }
    }
}
