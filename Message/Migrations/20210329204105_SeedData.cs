using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Message.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BMessages",
                columns: new[] { "BMessageId", "Message", "Posted" },
                values: new object[,]
                {
                    { 1, "Matilda", new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9264) },
                    { 2, "Rexie", new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9554) },
                    { 3, "Matilda", new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9564) },
                    { 4, "Pip", new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9566) },
                    { 5, "Bartholomew", new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9569) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 5);
        }
    }
}
