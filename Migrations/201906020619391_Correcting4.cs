namespace DotNet_05.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Correcting4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AspNetUsers", name: "Name", newName: "ArtistName");
        }

        public override void Down()
        {
        }
    }
}
