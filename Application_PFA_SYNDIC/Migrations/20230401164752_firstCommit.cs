using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_PFA_SYNDIC.Migrations
{
    /// <inheritdoc />
    public partial class firstCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "amins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    civilité = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_amins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "coproprietes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codePostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateDebutExercise = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nbrLots = table.Column<int>(type: "int", nullable: false),
                    budgetAnnuel = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coproprietes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "propritaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomPerssoneCasUrgence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenomPerssoneCasUrgence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactPerssoneCasUrgence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    civilité = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propritaires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "syndics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    civilité = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_syndics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "typeLots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeLots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategorieDepenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rubrique = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    coproprieteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieDepenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategorieDepenses_coproprietes_coproprieteId",
                        column: x => x.coproprieteId,
                        principalTable: "coproprietes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reunions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateReunion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    emplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    propritaireId = table.Column<int>(type: "int", nullable: false),
                    CoproprieteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reunions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reunions_coproprietes_CoproprieteId",
                        column: x => x.CoproprieteId,
                        principalTable: "coproprietes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reunions_propritaires_propritaireId",
                        column: x => x.propritaireId,
                        principalTable: "propritaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    etage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    disponibilte = table.Column<bool>(type: "bit", nullable: false),
                    dateAquisition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prixLocation = table.Column<float>(type: "real", nullable: false),
                    prixVente = table.Column<float>(type: "real", nullable: false),
                    desciption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    superficie = table.Column<int>(type: "int", nullable: false),
                    typeLotId = table.Column<int>(type: "int", nullable: false),
                    CoproprieteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lots_coproprietes_CoproprieteId",
                        column: x => x.CoproprieteId,
                        principalTable: "coproprietes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_lots_typeLots_typeLotId",
                        column: x => x.typeLotId,
                        principalTable: "typeLots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Depense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    budget = table.Column<float>(type: "real", nullable: false),
                    dateDepense = table.Column<DateTime>(type: "datetime2", nullable: false),
                    categorieDepensesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depense_CategorieDepenses_categorieDepensesId",
                        column: x => x.categorieDepensesId,
                        principalTable: "CategorieDepenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "avis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    LotId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_avis_lots_LotId",
                        column: x => x.LotId,
                        principalTable: "lots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "imageLots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotId = table.Column<int>(type: "int", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imageLots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imageLots_lots_LotId",
                        column: x => x.LotId,
                        principalTable: "lots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "louers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montant = table.Column<float>(type: "real", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lotId = table.Column<int>(type: "int", nullable: false),
                    propritaireId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_louers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_louers_lots_lotId",
                        column: x => x.lotId,
                        principalTable: "lots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_louers_propritaires_propritaireId",
                        column: x => x.propritaireId,
                        principalTable: "propritaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rdvVistes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateRdv = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rdvVistes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rdvVistes_lots_lotId",
                        column: x => x.lotId,
                        principalTable: "lots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etatDeLieus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nbrElement = table.Column<int>(type: "int", nullable: false),
                    louerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etatDeLieus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_etatDeLieus_louers_louerId",
                        column: x => x.louerId,
                        principalTable: "louers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "paiements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateDencaisement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    montantEncaiser = table.Column<float>(type: "real", nullable: false),
                    justificative = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numerotrasaction = table.Column<int>(type: "int", nullable: false),
                    LouerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paiements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_paiements_louers_LouerId",
                        column: x => x.LouerId,
                        principalTable: "louers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImageEtatLieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    etatDeLieuId = table.Column<int>(type: "int", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageEtatLieu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageEtatLieu_etatDeLieus_etatDeLieuId",
                        column: x => x.etatDeLieuId,
                        principalTable: "etatDeLieus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_avis_LotId",
                table: "avis",
                column: "LotId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieDepenses_coproprieteId",
                table: "CategorieDepenses",
                column: "coproprieteId");

            migrationBuilder.CreateIndex(
                name: "IX_Depense_categorieDepensesId",
                table: "Depense",
                column: "categorieDepensesId");

            migrationBuilder.CreateIndex(
                name: "IX_etatDeLieus_louerId",
                table: "etatDeLieus",
                column: "louerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImageEtatLieu_etatDeLieuId",
                table: "ImageEtatLieu",
                column: "etatDeLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_imageLots_LotId",
                table: "imageLots",
                column: "LotId");

            migrationBuilder.CreateIndex(
                name: "IX_lots_CoproprieteId",
                table: "lots",
                column: "CoproprieteId");

            migrationBuilder.CreateIndex(
                name: "IX_lots_typeLotId",
                table: "lots",
                column: "typeLotId");

            migrationBuilder.CreateIndex(
                name: "IX_louers_lotId",
                table: "louers",
                column: "lotId");

            migrationBuilder.CreateIndex(
                name: "IX_louers_propritaireId",
                table: "louers",
                column: "propritaireId");

            migrationBuilder.CreateIndex(
                name: "IX_paiements_LouerId",
                table: "paiements",
                column: "LouerId");

            migrationBuilder.CreateIndex(
                name: "IX_rdvVistes_lotId",
                table: "rdvVistes",
                column: "lotId");

            migrationBuilder.CreateIndex(
                name: "IX_reunions_CoproprieteId",
                table: "reunions",
                column: "CoproprieteId");

            migrationBuilder.CreateIndex(
                name: "IX_reunions_propritaireId",
                table: "reunions",
                column: "propritaireId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "amins");

            migrationBuilder.DropTable(
                name: "avis");

            migrationBuilder.DropTable(
                name: "Depense");

            migrationBuilder.DropTable(
                name: "ImageEtatLieu");

            migrationBuilder.DropTable(
                name: "imageLots");

            migrationBuilder.DropTable(
                name: "paiements");

            migrationBuilder.DropTable(
                name: "rdvVistes");

            migrationBuilder.DropTable(
                name: "reunions");

            migrationBuilder.DropTable(
                name: "syndics");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "CategorieDepenses");

            migrationBuilder.DropTable(
                name: "etatDeLieus");

            migrationBuilder.DropTable(
                name: "louers");

            migrationBuilder.DropTable(
                name: "lots");

            migrationBuilder.DropTable(
                name: "propritaires");

            migrationBuilder.DropTable(
                name: "coproprietes");

            migrationBuilder.DropTable(
                name: "typeLots");
        }
    }
}
