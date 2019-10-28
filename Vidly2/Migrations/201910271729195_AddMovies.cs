namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies VALUES ('Shooter')");
            Sql("INSERT INTO Movies VALUES ('The Dark Knight')");
            Sql("INSERT INTO Movies VALUES ('The Equalizer')");
            Sql("INSERT INTO Movies VALUES ('John Wick')");
            Sql("INSERT INTO Movies VALUES ('Lone Survivor')");
            Sql("INSERT INTO Movies VALUES ('13 Hours')");
            Sql("INSERT INTO Movies VALUES ('Black Hawk Down')");
            Sql("INSERT INTO Movies VALUES ('Pearl Harbor')");


        }

        public override void Down()
        {
        }
    }
}
