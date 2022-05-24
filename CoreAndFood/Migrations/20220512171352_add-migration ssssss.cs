using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAndFood.Migrations
{
    public partial class addmigrationssssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "ImageURL",
                value: "https://iaftm.tmgrup.com.tr/71e064/1200/627/41/0/999/500?u=https://iftm.tmgrup.com.tr/2021/11/11/elmada-hangi-vitaminler-var-elmanin-faydalari-nelerdir-1636620796310.jpeg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "ImageURL",
                value: "https://thumbs.dreamstime.com/b/orange-fruit-green-leaves-isolated-white-background-clipping-path-full-depth-field-fresh-186720104.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "ImageURL",
                value: "https://media.istockphoto.com/photos/tomato-with-slice-isolated-with-clipping-path-picture-id941825878?k=20&m=941825878&s=612x612&w=0&h=Qx5wYoEKsig3BGfhHAb2ZUqRBrhi6k64ZbXp3_zhj4o=");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "ImageURL",
                value: "https://tasomarket.com/files/products/nigde-gazozu-6-li-200-ml.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "ImageURL",
                value: "https://st.depositphotos.com/1056373/1930/i/450/depositphotos_19303341-stock-photo-long-grain-rice-in-a.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "ImageURL",
                value: "https://img.memurlar.net/galeri/11588/headline.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "ImageURL",
                value: "https://media.istockphoto.com/photos/glass-of-apple-juice-with-apples-picture-id173828042?b=1&k=20&m=173828042&s=170667a&w=0&h=nK1wnvH8MYUxGzS3wqS_kUTzdmJ1i7I1BEd90-gJ0jY=");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "ImageURL",
                value: "https://icdn.tgrthaber.com.tr/static/haberler/2019_10/buyuk/profiterol-tarifi-ve-profiterol-nasil-yapilir-kolay-profiterol-yapimi-ve-tarifi-1572505399.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "ImageURL",
                value: "https://galeri13.uludagsozluk.com/722/canin-cips-cekmesi_1756041_m.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "ImageURL",
                value: "https://e7.pngegg.com/pngimages/740/778/png-clipart-apple-apple-fruit.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "ImageURL",
                value: "https://img2.pngindir.com/20180920/kv/kisspng-orange-juice-orange-juice-citrus-sinensis-food-th-sweet-melody-1-bio-certifi-ecocert-sp-5ba39c39e57a95.18511885153744901794.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "ImageURL",
                value: "https://img2.pngindir.com/20180306/jve/kisspng-roma-tomato-food-beefsteak-tomato-clip-art-tomato-5a9e89af05cba3.5844826615203393750238.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "ImageURL",
                value: "https://img2.pngindir.com/20180713/gtb/kisspng-fizzy-drinks-uluda-gazoz-iced-tea-uluda-gazoz-gazoz-5b48ba36176547.5424333815314929180958.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "ImageURL",
                value: "https://e7.pngegg.com/pngimages/1/530/png-clipart-rice-rice-thumbnail.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "ImageURL",
                value: "https://e7.pngegg.com/pngimages/540/261/png-clipart-potato-potato.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "ImageURL",
                value: "https://img2.pngindir.com/20180702/rej/kisspng-apple-juice-apple-cider-orange-juice-smoothie-5b3aa3360fbe52.7272249515305695260645.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "ImageURL",
                value: "https://e7.pngegg.com/pngimages/975/423/png-clipart-chocolate-dessert-profiteroles-food-french-pastries.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "ImageURL",
                value: "https://w7.pngwing.com/pngs/325/140/png-transparent-chips-screenshot-french-fries-fish-and-chips-potato-chip-junk-food-chips-pic-food-baking-fruit.png");
        }
    }
}
