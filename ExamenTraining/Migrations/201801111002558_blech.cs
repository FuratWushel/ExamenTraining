namespace ExamenTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blech : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Name_Id", "dbo.Products");
            DropIndex("dbo.Categories", new[] { "Name_Id" });
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Categories", "Name_Id");
            AddForeignKey("dbo.Categories", "Name_Id", "dbo.Products", "Id");
        }
    }
}
