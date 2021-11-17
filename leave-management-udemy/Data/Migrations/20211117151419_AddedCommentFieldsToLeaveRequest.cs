using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management_udemy.Data.Migrations
{
    public partial class AddedCommentFieldsToLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApproverComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreationComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreationComment",
                table: "CreateLeaveRequestVM",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApproverComment",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "CreationComment",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "CreationComment",
                table: "CreateLeaveRequestVM");
        }
    }
}
