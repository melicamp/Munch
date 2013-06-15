namespace MunchProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MunchModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        LifeCount = c.Int(nullable: false),
                        RightHand_Id = c.Int(),
                        LeftHand_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WeaponModels", t => t.RightHand_Id)
                .ForeignKey("dbo.WeaponModels", t => t.LeftHand_Id)
                .Index(t => t.RightHand_Id)
                .Index(t => t.LeftHand_Id);
            
            CreateTable(
                "dbo.WeaponModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.MunchModels", new[] { "LeftHand_Id" });
            DropIndex("dbo.MunchModels", new[] { "RightHand_Id" });
            DropForeignKey("dbo.MunchModels", "LeftHand_Id", "dbo.WeaponModels");
            DropForeignKey("dbo.MunchModels", "RightHand_Id", "dbo.WeaponModels");
            DropTable("dbo.WeaponModels");
            DropTable("dbo.MunchModels");
        }
    }
}
