using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment2.Migrations
{
    public partial class CreateCustomerDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Cid = table.Column<string>(maxLength: 5, nullable: false),
                    Cname = table.Column<string>(maxLength: 50, nullable: false),
                    EmailId = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(maxLength: 13, nullable: false),
                    city = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Cid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
