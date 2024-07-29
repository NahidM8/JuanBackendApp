using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanBackendApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class bannerTableupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Banners",
                newName: "Subtitle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "Banners",
                newName: "Desc");
        }
    }
}
