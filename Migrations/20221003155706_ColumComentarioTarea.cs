using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEf.Migrations
{
    public partial class ColumComentarioTarea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "Tarea",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Tarea");
        }
    }
}
