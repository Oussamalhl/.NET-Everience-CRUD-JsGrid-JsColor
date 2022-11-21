using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eve.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employes",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categorieAssurance = table.Column<int>(type: "int", nullable: false),
                    matricule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numInscAssur = table.Column<int>(type: "int", nullable: false),
                    plafondAssur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employes", x => x.empId);
                });

            migrationBuilder.CreateTable(
                name: "quittances",
                columns: table => new
                {
                    idQuittance = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    matricule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numSinistre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroQuittance = table.Column<int>(type: "int", nullable: false),
                    prenomPrestataire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qualitePrestataire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateBordeau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateSoins = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fraisEngage = table.Column<float>(type: "real", nullable: false),
                    totalFraisEngage = table.Column<float>(type: "real", nullable: false),
                    commentaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quittances", x => x.idQuittance);
                    table.ForeignKey(
                        name: "FK_quittances_employes_employeFK",
                        column: x => x.employeFK,
                        principalTable: "employes",
                        principalColumn: "empId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_quittances_employeFK",
                table: "quittances",
                column: "employeFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quittances");

            migrationBuilder.DropTable(
                name: "employes");
        }
    }
}
