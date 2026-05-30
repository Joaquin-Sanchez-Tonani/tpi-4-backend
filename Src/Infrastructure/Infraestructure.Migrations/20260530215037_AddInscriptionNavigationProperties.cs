using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInscriptionNavigationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_ClassId",
                table: "Inscriptions",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_UserId",
                table: "Inscriptions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Classes_ClassId",
                table: "Inscriptions",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Users_UserId",
                table: "Inscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Classes_ClassId",
                table: "Inscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Users_UserId",
                table: "Inscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Inscriptions_ClassId",
                table: "Inscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Inscriptions_UserId",
                table: "Inscriptions");
        }
    }
}
