using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Management_Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_Pass = table.Column<string>(nullable: true),
                    U_FirstName = table.Column<string>(nullable: true),
                    U_LastName = table.Column<string>(nullable: true),
                    U_Address = table.Column<string>(nullable: true),
                    U_Country = table.Column<string>(nullable: true),
                    U_Zipcode = table.Column<int>(nullable: false),
                    U_Phone = table.Column<string>(nullable: true),
                    U_Email = table.Column<string>(nullable: true),
                    U_Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
