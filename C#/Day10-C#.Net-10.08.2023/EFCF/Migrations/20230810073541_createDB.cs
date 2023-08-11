using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCF.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Deptno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Deptno);
                });

            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    Empno = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deptno = table.Column<int>(type: "int", nullable: false),
                    DeptnoNavDeptno = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.Empno);
                    table.ForeignKey(
                        name: "FK_Emps_Depts_DeptnoNavDeptno",
                        column: x => x.DeptnoNavDeptno,
                        principalTable: "Depts",
                        principalColumn: "Deptno");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emps_DeptnoNavDeptno",
                table: "Emps",
                column: "DeptnoNavDeptno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emps");

            migrationBuilder.DropTable(
                name: "Depts");
        }
    }
}
