using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a", "f6f83f8a-47de-44fe-9746-e6d65946e00e", "Administrator", "ADMINISTRATOR" },
                    { "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a", "0629b11b-0789-4fbb-8f8b-557597bb520c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01", 0, "fe88716d-238c-41b7-aedb-473e1d1279d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJo5N3JAlaGI4xgG7ZapeVjhpA5xSjT7ONByB2wr0mwORY30Yapmehm18Ph4Xu0HrA==", null, false, "3c14fb00-a0fc-4459-bbe0-176afaa2296d", null, false, null },
                    { "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01", 0, "3b10f9a5-b94d-4799-b272-52e21c3484d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEHsJ1gfh0ZvMoCgb1QKer+3e5YkFLtdhUbgGjm/isXkGn701pTdHeEdSlOBMALzwUg==", null, false, "2f58ab8c-5209-4797-b53e-d2a3a8fcc5c0", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a", "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a", "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a", "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a", "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01");
        }
    }
}
