namespace WPF_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citizens",
                c => new
                    {
                        CitizenID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                        email = c.String(),
                        Address = c.String(),
                        MobileNo = c.String(),
                        Condition = c.String(),
                    })
                .PrimaryKey(t => t.CitizenID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Citizen_CitizenID = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Citizens", t => t.Citizen_CitizenID)
                .Index(t => t.Citizen_CitizenID);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        DiseaseID = c.Int(nullable: false, identity: true),
                        DiseaseName = c.String(),
                        Symptoms = c.String(),
                        Doctor_DoctorID = c.Int(),
                    })
                .PrimaryKey(t => t.DiseaseID)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorID)
                .Index(t => t.Doctor_DoctorID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        MobileNo = c.String(),
                        Address = c.String(),
                        Specialization = c.String(),
                        email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.DoctorID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        ReservedTime = c.DateTime(nullable: false),
                        Doctor_DoctorID = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorID)
                .Index(t => t.Doctor_DoctorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Doctor_DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.Diseases", "Doctor_DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.Comments", "Citizen_CitizenID", "dbo.Citizens");
            DropIndex("dbo.Reservations", new[] { "Doctor_DoctorID" });
            DropIndex("dbo.Diseases", new[] { "Doctor_DoctorID" });
            DropIndex("dbo.Comments", new[] { "Citizen_CitizenID" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Doctors");
            DropTable("dbo.Diseases");
            DropTable("dbo.Comments");
            DropTable("dbo.Citizens");
        }
    }
}
