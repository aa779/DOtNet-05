namespace DotNet_05.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Correcting2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Name");
        }
        
        public override void Down()
        {
        }
    }
}
