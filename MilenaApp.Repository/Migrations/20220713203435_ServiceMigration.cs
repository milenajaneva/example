using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MilenaApp.Repository.Migrations
{
    public partial class ServiceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "TicketInShoppingCarts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "TicketInOrder",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "TicketInShoppingCarts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TicketInOrder");
        }
    }
}
