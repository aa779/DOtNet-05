namespace DotNet_05.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Correcting4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AspNetUsers", name: "ArtistName", newName: "Name");
        }

        public override void Down()
        {
        }
    }
}
