using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonApp.DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DeletedDate", "Email", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4706), new DateTime(1993, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "mehmet.yilmaz@deneme.com", "Mehmet", "Yılmaz", 1, null },
                    { 2, new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4719), new DateTime(1986, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ahmet.erdogan@deneme.com", "Ahmet", "Erdoğan", 1, null },
                    { 3, new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4721), new DateTime(1960, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "sevinc.tamer@deneme.com", "Sevinç", "Tamer", 1, null },
                    { 4, new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4723), new DateTime(2000, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "fatih.ozturk@deneme.com", "Fatih", "Öztürk", 1, null },
                    { 5, new DateTime(2024, 7, 6, 12, 15, 42, 72, DateTimeKind.Local).AddTicks(4724), new DateTime(2004, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "merve.dogan@deneme.com", "Merve", "Doğan", 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
