using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra.Migrations
{
    /// <inheritdoc />
    public partial class NTNQStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTNQStudent",
                columns: table => new
                {
                    NTNQStudentID = table.Column<string>(type: "TEXT", nullable: false),
                    NTNQStudentName = table.Column<string>(type: "TEXT", nullable: false),
                    NTNQAdress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTNQStudent", x => x.NTNQStudentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTNQStudent");
        }
    }
}
