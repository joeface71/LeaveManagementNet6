using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa5cf795-f4c2-4c12-8430-0e4d1cabea0a",
                column: "ConcurrencyStamp",
                value: "64ac1614-6d1d-4b5b-b267-925cfcfbd5ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5cf795-f1c2-4c12-843d-0e4d1cabba0a",
                column: "ConcurrencyStamp",
                value: "a83e9900-b636-42e3-95de-ed83d0da6399");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf791-f4c2-1ca2-8430-0e2d1cafea01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21b055be-dc00-4861-98bd-eb8b86d9eeae", "AQAAAAEAACcQAAAAEIxpeP+tO1ytl4il7/VYRSSmwBAtjKi5kKcZ0fZK4dHu5czBoNThLKLKsrmkLvpNKA==", "5a556810-b3b6-4dbf-bef4-9b33cffcdb85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa5bf7aa-f4c2-14e2-8430-0e2d1fffea01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b96aafe7-ee1e-4d31-9274-c5dbc5f9261b", "AQAAAAEAACcQAAAAELkfpyDpac4CSYewQe8oUEoa/eZAS+2Ift5iVASQNcedNKqlnHx+UPlR3HT8SuETHA==", "44797bec-fbf9-4038-bdd0-fd27ffd76f26" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
