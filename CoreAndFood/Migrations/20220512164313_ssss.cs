using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAndFood.Migrations
{
    public partial class ssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AdminRole = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminID", "AdminRole", "Password", "UserName" },
                values: new object[] { 1, "A", "1234", "Mikdat" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "Status" },
                values: new object[,]
                {
                    { 1, "Tazeliğine güveniyoruz", "Meyveler", false },
                    { 2, "Organik mahsüller", "Sebzeler", false },
                    { 3, "Olmazsa olmazlarımız", "Bakliyat", false },
                    { 4, "E kuru kuru gitmez", "İçecekler", false },
                    { 5, "Ufak bir kaçamak vakti...", "Tatlılar", false },
                    { 6, "Eğlence ortamının vazgeçilmezleri:)", "Atıştırmalıklar", false }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "CategoryID", "Description", "ImageURL", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "", "https://e7.pngegg.com/pngimages/740/778/png-clipart-apple-apple-fruit.png", "Elma", 6.0, 100 },
                    { 2, 1, "", "https://img2.pngindir.com/20180920/kv/kisspng-orange-juice-orange-juice-citrus-sinensis-food-th-sweet-melody-1-bio-certifi-ecocert-sp-5ba39c39e57a95.18511885153744901794.jpg", "Portakal", 7.0, 140 },
                    { 3, 2, "", "https://img2.pngindir.com/20180306/jve/kisspng-roma-tomato-food-beefsteak-tomato-clip-art-tomato-5a9e89af05cba3.5844826615203393750238.jpg", "Domates", 5.0, 170 },
                    { 4, 4, "", "https://img2.pngindir.com/20180713/gtb/kisspng-fizzy-drinks-uluda-gazoz-iced-tea-uluda-gazoz-gazoz-5b48ba36176547.5424333815314929180958.jpg", "Gazoz", 7.0, 85 },
                    { 5, 3, "", "https://e7.pngegg.com/pngimages/1/530/png-clipart-rice-rice-thumbnail.png", "Pirinç", 11.0, 110 },
                    { 6, 2, "", "https://e7.pngegg.com/pngimages/540/261/png-clipart-potato-potato.png", "Patates", 4.0, 150 },
                    { 7, 4, "", "https://img2.pngindir.com/20180702/rej/kisspng-apple-juice-apple-cider-orange-juice-smoothie-5b3aa3360fbe52.7272249515305695260645.jpg", "Elma Suyu", 9.0, 180 },
                    { 8, 5, "", "https://e7.pngegg.com/pngimages/975/423/png-clipart-chocolate-dessert-profiteroles-food-french-pastries.png", "Profiterol", 16.0, 75 },
                    { 9, 6, "", "https://w7.pngwing.com/pngs/325/140/png-transparent-chips-screenshot-french-fries-fish-and-chips-potato-chip-junk-food-chips-pic-food-baking-fruit.png", "Cips", 8.0, 65 },
                    { 10, 6, "", "https://media.istockphoto.com/photos/industrial-sweet-biscuit-picture-id869217802?k=20&m=869217802&s=170667a&w=0&h=HmF5q4fyWHCUh9wYyHfYN-kuLaZO7mVLRs2wvAz5fhA=", "Bisküvi", 4.0, 140 },
                    { 11, 5, "", "https://maksatbilgi.com/wp-content/uploads/2021/08/kazandibi-tarifi-one-cikan.jpg", "Kazandibi", 12.0, 60 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
