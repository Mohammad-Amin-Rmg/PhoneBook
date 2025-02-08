using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneBook.Infrastructures.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDbSetNameOfTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonTags_Tas_TagId",
                table: "PersonTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tas",
                table: "Tas");

            migrationBuilder.RenameTable(
                name: "Tas",
                newName: "Tag");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonTags_Tag_TagId",
                table: "PersonTags",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonTags_Tag_TagId",
                table: "PersonTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tas",
                table: "Tas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonTags_Tas_TagId",
                table: "PersonTags",
                column: "TagId",
                principalTable: "Tas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
