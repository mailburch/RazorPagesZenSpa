using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorPagesZenSpaCh7.Migrations
{
    /// <inheritdoc />
    public partial class ClientAndAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClientService",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    ServicesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientService", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClientService_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientService_Services_ServicesID",
                        column: x => x.ServicesID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ID", "Address", "City", "Country", "Email", "FirstName", "LastName", "Password", "Phone", "PostalCode", "State", "Username" },
                values: new object[,]
                {
                    { 1, "", "", "", "flo@schmoe.net", "Flo", "Schmoe", "FloSchmoe1234*", "", "", "", "Flo" },
                    { 2, "", "", "", "jojo@schmoe.net", "Jo", "Schmoe", "JoJoSchmoe1234?", "", "", "", "JoJo" },
                    { 3, "", "", "", "truly@schmoe.net", "Truly", "Schmoe", "Truly9876**", "", "", "", "Truly" }
                });

            migrationBuilder.InsertData(
                table: "ClientService",
                columns: new[] { "ID", "ClientID", "ServicesID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 7 },
                    { 3, 1, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientService_ClientID",
                table: "ClientService",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientService_ServicesID",
                table: "ClientService",
                column: "ServicesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientService");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
