namespace VisionQuestMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recuerdoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TituloRecuerdo = c.String(nullable: false),
                        TipoRecuerdo = c.String(nullable: false),
                        Claridad = c.Int(nullable: false),
                        SintezoideId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sintezoides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                        NivelIA = c.Int(nullable: false),
                        FuenteEnergia = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SintezoideRecuerdoes",
                c => new
                    {
                        Sintezoide_Id = c.Int(nullable: false),
                        Recuerdo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sintezoide_Id, t.Recuerdo_Id })
                .ForeignKey("dbo.Sintezoides", t => t.Sintezoide_Id, cascadeDelete: true)
                .ForeignKey("dbo.Recuerdoes", t => t.Recuerdo_Id, cascadeDelete: true)
                .Index(t => t.Sintezoide_Id)
                .Index(t => t.Recuerdo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SintezoideRecuerdoes", "Recuerdo_Id", "dbo.Recuerdoes");
            DropForeignKey("dbo.SintezoideRecuerdoes", "Sintezoide_Id", "dbo.Sintezoides");
            DropIndex("dbo.SintezoideRecuerdoes", new[] { "Recuerdo_Id" });
            DropIndex("dbo.SintezoideRecuerdoes", new[] { "Sintezoide_Id" });
            DropTable("dbo.SintezoideRecuerdoes");
            DropTable("dbo.Sintezoides");
            DropTable("dbo.Recuerdoes");
        }
    }
}
