using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedNewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
            //migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");
            //migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make3')");

            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make1-ModelA', 
            //    (Select ID FROM Makes where Name = 'Make1'))");
            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make1-ModelB', 
            //    (Select ID FROM Makes where Name = 'Make1'))");
            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make1-ModelC', 
            //    (Select ID FROM Makes where Name = 'Make1'))");

            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make2-ModelA', 
            //    (Select ID FROM Makes where Name = 'Make2'))");
            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make2-ModelB', 
            //    (Select ID FROM Makes where Name = 'Make2'))");
            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make2-ModelC', 
            //    (Select ID FROM Makes where Name = 'Make2'))");

            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make3-ModelA', 
            //    (Select ID FROM Makes where Name = 'Make3'))");
            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make3-ModelB', 
            //    (Select ID FROM Makes where Name = 'Make3'))");
            //migrationBuilder.Sql(@"Insert into Models(Name, MakeID) VALUES ('Make3-ModelC', 
            //    (Select ID FROM Makes where Name = 'Make3'))");

            migrationBuilder.Sql(@"Insert into Features(Name) VALUES ('Feature1')");
            migrationBuilder.Sql(@"Insert into Features(Name) VALUES ('Feature2')");
            migrationBuilder.Sql(@"Insert into Features(Name) VALUES ('Feature3')");
            migrationBuilder.Sql(@"Insert into Features(Name) VALUES ('Feature4')");
            migrationBuilder.Sql(@"Insert into Features(Name) VALUES ('Feature5')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("Delete from Makes WHERE Name IN ('Make1', 'Make2', 'Make3')");
            migrationBuilder.Sql("Delete from Features WHERE Name IN ('Feature1', 'Feature2', 'Feature3', 'Feature4', 'Feature5')");
        }

    }
}
