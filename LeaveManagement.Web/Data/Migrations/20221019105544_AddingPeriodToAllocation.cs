using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a",
                column: "ConcurrencyStamp",
                value: "e77a73ed-a1ec-4f63-845e-6cf9bbbe6798");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a",
                column: "ConcurrencyStamp",
                value: "99870f6c-e533-4609-8e96-13fe601545d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18ed3028-77e1-4bc2-906a-549d6e7fe242", "AQAAAAEAACcQAAAAEIU7RkqgND+rqKZforRq+F4yWk+4o1pqSVe4YpNBJanPzbGossYYTBi3kNMpihW+Fw==", "07ad5ddd-26aa-4392-a205-f791c1a67f67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e1f54c3-8f63-4dd8-8250-c0f0a2132c0b", "AQAAAAEAACcQAAAAELXK4XvNrIzDT5z5Ot5eSKhousW7pIL60cgIFFg+n1mM1hA++h7RUlJc4ntspdRskQ==", "c01cde04-2b81-4655-9748-15751d0c17a8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9ed36fd-0480-491b-ab14-0279f8e8a31e", "AQAAAAEAACcQAAAAEEVUIkLQ/0eMbOs4kGtDQN9JwByZom1RJeGaON+4r+JndMrqfJQiLiaLhZ4+HdmHeg==", "a96460c3-1de3-4a9a-83df-f47e7b1a8a2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6254a23-6b9e-41e6-9c75-9f19b8ba9555", "AQAAAAEAACcQAAAAEIP8enermZ9jePnATjtewD6ydYAnlxVd50rhKbaK4LXwz5yEoFRMS2cNprPTHdDL9g==", "0cad233a-7faf-4719-b2c6-3ccd65372501" });
        }
    }
}
