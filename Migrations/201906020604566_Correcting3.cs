namespace DotNet_05.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Correcting3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
        }
    }
}
