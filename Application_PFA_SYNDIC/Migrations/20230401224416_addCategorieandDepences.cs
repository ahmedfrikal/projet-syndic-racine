using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_PFA_SYNDIC.Migrations
{
    /// <inheritdoc />
    public partial class addCategorieandDepences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategorieDepenses_coproprietes_coproprieteId",
                table: "CategorieDepenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Depense_CategorieDepenses_categorieDepensesId",
                table: "Depense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorieDepenses",
                table: "CategorieDepenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Depense",
                table: "Depense");

            migrationBuilder.RenameTable(
                name: "CategorieDepenses",
                newName: "categorieDepenses");

            migrationBuilder.RenameTable(
                name: "Depense",
                newName: "depenses");

            migrationBuilder.RenameIndex(
                name: "IX_CategorieDepenses_coproprieteId",
                table: "categorieDepenses",
                newName: "IX_categorieDepenses_coproprieteId");

            migrationBuilder.RenameIndex(
                name: "IX_Depense_categorieDepensesId",
                table: "depenses",
                newName: "IX_depenses_categorieDepensesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categorieDepenses",
                table: "categorieDepenses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_depenses",
                table: "depenses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_categorieDepenses_coproprietes_coproprieteId",
                table: "categorieDepenses",
                column: "coproprieteId",
                principalTable: "coproprietes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_depenses_categorieDepenses_categorieDepensesId",
                table: "depenses",
                column: "categorieDepensesId",
                principalTable: "categorieDepenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categorieDepenses_coproprietes_coproprieteId",
                table: "categorieDepenses");

            migrationBuilder.DropForeignKey(
                name: "FK_depenses_categorieDepenses_categorieDepensesId",
                table: "depenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categorieDepenses",
                table: "categorieDepenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_depenses",
                table: "depenses");

            migrationBuilder.RenameTable(
                name: "categorieDepenses",
                newName: "CategorieDepenses");

            migrationBuilder.RenameTable(
                name: "depenses",
                newName: "Depense");

            migrationBuilder.RenameIndex(
                name: "IX_categorieDepenses_coproprieteId",
                table: "CategorieDepenses",
                newName: "IX_CategorieDepenses_coproprieteId");

            migrationBuilder.RenameIndex(
                name: "IX_depenses_categorieDepensesId",
                table: "Depense",
                newName: "IX_Depense_categorieDepensesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorieDepenses",
                table: "CategorieDepenses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depense",
                table: "Depense",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategorieDepenses_coproprietes_coproprieteId",
                table: "CategorieDepenses",
                column: "coproprieteId",
                principalTable: "coproprietes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Depense_CategorieDepenses_categorieDepensesId",
                table: "Depense",
                column: "categorieDepensesId",
                principalTable: "CategorieDepenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
