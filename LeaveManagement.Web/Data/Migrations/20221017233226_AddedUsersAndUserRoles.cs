using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedUsersAndUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a",
                column: "ConcurrencyStamp",
                value: "5fac0e96-7d19-45ea-b03e-dc4083585578");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a",
                column: "ConcurrencyStamp",
                value: "387fe1f9-3573-476b-a6e1-09c966f53da0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a9ed36fd-0480-491b-ab14-0279f8e8a31e", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEVUIkLQ/0eMbOs4kGtDQN9JwByZom1RJeGaON+4r+JndMrqfJQiLiaLhZ4+HdmHeg==", "a96460c3-1de3-4a9a-83df-f47e7b1a8a2f", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d6254a23-6b9e-41e6-9c75-9f19b8ba9555", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIP8enermZ9jePnATjtewD6ydYAnlxVd50rhKbaK4LXwz5yEoFRMS2cNprPTHdDL9g==", "0cad233a-7faf-4719-b2c6-3ccd65372501", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a",
                column: "ConcurrencyStamp",
                value: "f6f83f8a-47de-44fe-9746-e6d65946e00e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a",
                column: "ConcurrencyStamp",
                value: "0629b11b-0789-4fbb-8f8b-557597bb520c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fe88716d-238c-41b7-aedb-473e1d1279d3", false, null, "AQAAAAEAACcQAAAAEJo5N3JAlaGI4xgG7ZapeVjhpA5xSjT7ONByB2wr0mwORY30Yapmehm18Ph4Xu0HrA==", "3c14fb00-a0fc-4459-bbe0-176afaa2296d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b10f9a5-b94d-4799-b272-52e21c3484d4", false, null, "AQAAAAEAACcQAAAAEHsJ1gfh0ZvMoCgb1QKer+3e5YkFLtdhUbgGjm/isXkGn701pTdHeEdSlOBMALzwUg==", "2f58ab8c-5209-4797-b53e-d2a3a8fcc5c0", null });
        }
    }
}
