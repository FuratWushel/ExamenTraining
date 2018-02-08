namespace ExamenTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productfoto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Filename = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "ProductPicture_Id", c => c.Int());
            CreateIndex("dbo.Products", "ProductPicture_Id");
            AddForeignKey("dbo.Products", "ProductPicture_Id", "dbo.Pictures", "Id");
            DropColumn("dbo.Products", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            DropForeignKey("dbo.Products", "ProductPicture_Id", "dbo.Pictures");
            DropIndex("dbo.Products", new[] { "ProductPicture_Id" });
            DropColumn("dbo.Products", "ProductPicture_Id");
            DropTable("dbo.Pictures");
        }
    }
}
