using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Message.Migrations
{
    public partial class Something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 1,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 16, 25, 35, 952, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 2,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 16, 25, 35, 952, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 3,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 16, 25, 35, 952, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 4,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 16, 25, 35, 952, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 5,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 16, 25, 35, 952, DateTimeKind.Local).AddTicks(5339));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 1,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 2,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 3,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 4,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "BMessages",
                keyColumn: "BMessageId",
                keyValue: 5,
                column: "Posted",
                value: new DateTime(2021, 3, 29, 15, 41, 5, 665, DateTimeKind.Local).AddTicks(9569));
        }
    }
}
