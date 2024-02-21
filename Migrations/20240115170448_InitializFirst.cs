using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suq_com.Migrations
{
    /// <inheritdoc />
    public partial class InitializFirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departements",
                columns: table => new
                {
                    depoNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depoName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    depoimage=table.Column<string>(type:"nvarchar(max)",nullable:false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departements", x => x.depoNo);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    empid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empPhone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.empid);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    memberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Bdate = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    phone = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    questionsecurte = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.memberId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarrantyPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CountryMake = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    BrandNamberdepoNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_departements_BrandNamberdepoNo",
                        column: x => x.BrandNamberdepoNo,
                        principalTable: "departements",
                        principalColumn: "depoNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    orderid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderDate = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    orderTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    memberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    empid1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.orderid);
                    table.ForeignKey(
                        name: "FK_orders_employees_empid1",
                        column: x => x.empid1,
                        principalTable: "employees",
                        principalColumn: "empid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_members_memberId",
                        column: x => x.memberId,
                        principalTable: "members",
                        principalColumn: "memberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderDetials",
                columns: table => new
                {
                    orderdetialsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    itemnumberId = table.Column<int>(type: "int", nullable: false),
                    orderid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderdetialsID", x => x.orderdetialsID);
                    table.ForeignKey(
                        name: "FK_orderDetials_orders_orderid",
                        column: x => x.orderid,
                        principalTable: "orders",
                        principalColumn: "orderid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderDetials_products_itemnumberId",
                        column: x => x.itemnumberId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderDetials_itemnumberId",
                table: "orderDetials",
                column: "itemnumberId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetials_orderid",
                table: "orderDetials",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_empid1",
                table: "orders",
                column: "empid1");

            migrationBuilder.CreateIndex(
                name: "IX_orders_memberId",
                table: "orders",
                column: "memberId");

            migrationBuilder.CreateIndex(
                name: "IX_products_BrandNamberdepoNo",
                table: "products",
                column: "BrandNamberdepoNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderDetials");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "members");

            migrationBuilder.DropTable(
                name: "departements");
        }
    }
}
