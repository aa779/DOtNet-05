namespace DotNet_05.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddFollowingAndFollowers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendance2", "GigId", "dbo.Gigs");
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollowerId = c.String(nullable: false, maxLength: 128),
                        FolloweeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FollowerId, t.FolloweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.FollowerId)
                .ForeignKey("dbo.AspNetUsers", t => t.FolloweeId)
                .Index(t => t.FollowerId)
                .Index(t => t.FolloweeId);
            
            AddForeignKey("dbo.Attendance2", "GigId", "dbo.Gigs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendance2", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Followings", "FolloweeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "FollowerId", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "FolloweeId" });
            DropIndex("dbo.Followings", new[] { "FollowerId" });
            DropTable("dbo.Followings");
            AddForeignKey("dbo.Attendance2", "GigId", "dbo.Gigs", "Id", cascadeDelete: true);
        }
    }
}
