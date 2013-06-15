namespace MunchProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SuitModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PantsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MunchModels", "Body_Id", c => c.Int());
            AddColumn("dbo.MunchModels", "Legs_Id", c => c.Int());
            AddForeignKey("dbo.MunchModels", "Body_Id", "dbo.SuitModels", "Id");
            AddForeignKey("dbo.MunchModels", "Legs_Id", "dbo.PantsModels", "Id");
            CreateIndex("dbo.MunchModels", "Body_Id");
            CreateIndex("dbo.MunchModels", "Legs_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.MunchModels", new[] { "Legs_Id" });
            DropIndex("dbo.MunchModels", new[] { "Body_Id" });
            DropForeignKey("dbo.MunchModels", "Legs_Id", "dbo.PantsModels");
            DropForeignKey("dbo.MunchModels", "Body_Id", "dbo.SuitModels");
            DropColumn("dbo.MunchModels", "Legs_Id");
            DropColumn("dbo.MunchModels", "Body_Id");
            DropTable("dbo.PantsModels");
            DropTable("dbo.SuitModels");
        }
    }
}
