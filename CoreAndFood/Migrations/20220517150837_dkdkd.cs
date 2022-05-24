using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAndFood.Migrations
{
    public partial class dkdkd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "Description",
                value: "Amasya Elması");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "Description",
                value: "Antalya Portakalı");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "Description",
                value: "Kıpkırmızı Domastesler");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "Description",
                value: "Buz gibi gider");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "Description",
                value: "Osmancık pirinci");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "Description",
                value: "Kızartmalık patates");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "Description",
                value: "Soğuk içiniz");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "Description",
                value: "Tatlıların tatlısı");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "Description",
                value: "Atıştırma vakti");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "Description",
                value: "Çayın ortağı");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 11,
                column: "Description",
                value: "Tatlı krizine son");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 11,
                column: "Description",
                value: "");
        }
    }
}
