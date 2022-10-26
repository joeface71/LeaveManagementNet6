using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a",
                column: "ConcurrencyStamp",
                value: "23c37c55-e606-4361-aa50-8763a39ce090");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a",
                column: "ConcurrencyStamp",
                value: "4195b2df-5ed9-42e6-af4a-29c9ec7b6661");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f020ac96-9a24-4a7a-bdac-cd0646d98706", "AQAAAAEAACcQAAAAEB2VXkQnQ/460VzDQWpw2jmy2M/x6M+hpOvvG9kRD9sQq6XOgvlu/R+ZJ2oeMU1BrA==", "6549ee70-b426-4306-a85a-041906c97fb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a47ec848-f187-44ea-9870-97c7dd02d624", "AQAAAAEAACcQAAAAEM4bZ7Zs84izFiJJf+NHDeb0s/NVF41qUBoM3WgvpLR+H/tjy8zjuOsBa8X8SCdSrA==", "048673fd-b022-41e9-9b5b-279774add321" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
