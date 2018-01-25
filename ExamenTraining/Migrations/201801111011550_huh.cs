namespace ExamenTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class huh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Name_Id)
                .Index(t => t.Name_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Name_Id", "dbo.Products");
            DropIndex("dbo.Categories", new[] { "Name_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
