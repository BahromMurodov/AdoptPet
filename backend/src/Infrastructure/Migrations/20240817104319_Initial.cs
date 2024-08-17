using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "volunteer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    full_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    experience = table.Column<int>(type: "integer", nullable: false),
                    number_pet_find_home = table.Column<int>(type: "integer", nullable: false),
                    number_pet_search_home = table.Column<int>(type: "integer", nullable: false),
                    number_pet_healing = table.Column<int>(type: "integer", nullable: false),
                    phone = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    Details = table.Column<string>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_volunteer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pets",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nick_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    type = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    breed = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    color = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    health = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    address_located = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    weight = table.Column<double>(type: "double precision", nullable: false),
                    height = table.Column<double>(type: "double precision", nullable: false),
                    phone_number = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    is_neutered = table.Column<bool>(type: "boolean", nullable: false),
                    date_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    is_vaccinated = table.Column<bool>(type: "boolean", nullable: false),
                    status_help = table.Column<int>(type: "integer", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    volunteer_id = table.Column<Guid>(type: "uuid", nullable: true),
                    Details = table.Column<string>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pets", x => x.id);
                    table.ForeignKey(
                        name: "fk_pets_volunteer_volunteer_id",
                        column: x => x.volunteer_id,
                        principalTable: "volunteer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pet_photo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    path = table.Column<string>(type: "text", nullable: false),
                    is_main = table.Column<bool>(type: "boolean", nullable: false),
                    pet_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pet_photo", x => x.id);
                    table.ForeignKey(
                        name: "fk_pet_photo_pets_pet_id",
                        column: x => x.pet_id,
                        principalTable: "pets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_pet_photo_pet_id",
                table: "pet_photo",
                column: "pet_id");

            migrationBuilder.CreateIndex(
                name: "ix_pets_volunteer_id",
                table: "pets",
                column: "volunteer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pet_photo");

            migrationBuilder.DropTable(
                name: "pets");

            migrationBuilder.DropTable(
                name: "volunteer");
        }
    }
}
