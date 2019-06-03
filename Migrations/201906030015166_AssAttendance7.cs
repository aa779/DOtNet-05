namespace DotNet_05.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AssAttendance7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance2",
                c => new
                {
                    GigId = c.Int(nullable: false),
                    AttendeeId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.GigId, t.AttendeeId } )
                .ForeignKey("dbo.Gigs", t => t.GigId)
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeId)
                .Index(t => t.GigId)
                .Index(t => t.AttendeeId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Attendance2", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Attendance2", "AttendeeId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendance2", new[] { "GigId" });
            DropIndex("dbo.Attendance2", new[] { "AttendeeId" });
            DropTable("dbo.Attendance2");
        }
    }
}
