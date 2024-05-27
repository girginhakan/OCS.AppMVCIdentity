using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AdminuserandAdminRoleInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "DailyFreeItemCount", "Email", "EmailConfirmed", "Gender", "IsSubscriber", "LastFreeItemDate", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionEndDate", "SubscriptionStartDate", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, new DateOnly(2024, 5, 25), "642bd1e4-3af5-46d9-83c1-64762f8e1eed", 5, "admin@mail.com", true, 0, false, null, false, null, "adminName", "ADMIN@MAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEKxwgIIwSsRaLut406RfBa8f+EEAuOa4juR7ckwmEOQB6BayRoe8mf2vVZuMEtBD1Q==", "-", true, "3a822079-f33f-41dc-a036-966f1102ed2b", null, null, "adminSurname", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
