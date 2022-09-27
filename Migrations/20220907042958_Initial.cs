using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiPageContactsMeis.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PhoneNum = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "PhoneNum" },
                values: new object[] { 1, "6411 Northwest Dr", "Mom", "Mom (Margaret Meis) cell", "515-897-8596" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "PhoneNum" },
                values: new object[] { 2, "1655 SE Waters Edge Dr", "Dad", "Dad (Jamie Meis) cell", "515-202-5665" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "PhoneNum" },
                values: new object[] { 3, "6411 Northwest Dr", "Alexis", "Alexis cell", "515-802-0409" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
