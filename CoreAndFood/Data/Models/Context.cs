using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HNE43R2;database=DbCoreFood;integrated security=true");      
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Admin> Admins{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(
                new Food {FoodID=1,Name="Elma",Description="Amasya Elması",Price=6,ImageURL= "https://iaftm.tmgrup.com.tr/71e064/1200/627/41/0/999/500?u=https://iftm.tmgrup.com.tr/2021/11/11/elmada-hangi-vitaminler-var-elmanin-faydalari-nelerdir-1636620796310.jpeg", Stock=100,CategoryID=1},
                new Food {FoodID=2,Name="Portakal",Description="Antalya Portakalı",Price=7,ImageURL= "https://thumbs.dreamstime.com/b/orange-fruit-green-leaves-isolated-white-background-clipping-path-full-depth-field-fresh-186720104.jpg", Stock=140,CategoryID=1},
                new Food {FoodID=3,Name="Domates",Description="Kıpkırmızı Domastesler",Price=5,ImageURL= "https://media.istockphoto.com/photos/tomato-with-slice-isolated-with-clipping-path-picture-id941825878?k=20&m=941825878&s=612x612&w=0&h=Qx5wYoEKsig3BGfhHAb2ZUqRBrhi6k64ZbXp3_zhj4o=", Stock=170,CategoryID=2},
                new Food {FoodID=4,Name="Gazoz",Description="Buz gibi gider",Price=7,ImageURL= "https://tasomarket.com/files/products/nigde-gazozu-6-li-200-ml.jpg", Stock=85,CategoryID=4},
                new Food {FoodID=5,Name="Pirinç",Description="Osmancık pirinci",Price=11,ImageURL= "https://st.depositphotos.com/1056373/1930/i/450/depositphotos_19303341-stock-photo-long-grain-rice-in-a.jpg", Stock=110,CategoryID=3},
                new Food {FoodID=6,Name="Patates",Description="Kızartmalık patates",Price=4,ImageURL= "https://img.memurlar.net/galeri/11588/headline.jpg", Stock=150,CategoryID=2},
                new Food {FoodID=7,Name="Elma Suyu",Description="Soğuk içiniz",Price=9,ImageURL= "https://media.istockphoto.com/photos/glass-of-apple-juice-with-apples-picture-id173828042?b=1&k=20&m=173828042&s=170667a&w=0&h=nK1wnvH8MYUxGzS3wqS_kUTzdmJ1i7I1BEd90-gJ0jY=", Stock=180,CategoryID=4},
                new Food {FoodID=8,Name="Profiterol",Description="Tatlıların tatlısı",Price=16,ImageURL= "https://icdn.tgrthaber.com.tr/static/haberler/2019_10/buyuk/profiterol-tarifi-ve-profiterol-nasil-yapilir-kolay-profiterol-yapimi-ve-tarifi-1572505399.jpg", Stock=75,CategoryID=5},
                new Food {FoodID=9,Name="Cips",Description="Atıştırma vakti",Price=8,ImageURL= "https://galeri13.uludagsozluk.com/722/canin-cips-cekmesi_1756041_m.jpg", Stock=65,CategoryID=6},
                new Food {FoodID=10,Name="Bisküvi",Description="Çayın ortağı",Price=4,ImageURL= "https://media.istockphoto.com/photos/industrial-sweet-biscuit-picture-id869217802?k=20&m=869217802&s=170667a&w=0&h=HmF5q4fyWHCUh9wYyHfYN-kuLaZO7mVLRs2wvAz5fhA=", Stock=140,CategoryID=6},
                new Food {FoodID=11,Name="Kazandibi",Description="Tatlı krizine son",Price=12,ImageURL= "https://maksatbilgi.com/wp-content/uploads/2021/08/kazandibi-tarifi-one-cikan.jpg", Stock=60,CategoryID=5}
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID=1,CategoryName="Meyveler",CategoryDescription="Tazeliğine güveniyoruz"},
                new Category { CategoryID=2,CategoryName="Sebzeler",CategoryDescription="Organik mahsüller"},
                new Category { CategoryID=3,CategoryName="Bakliyat",CategoryDescription="Olmazsa olmazlarımız"},
                new Category { CategoryID=4,CategoryName="İçecekler",CategoryDescription="E kuru kuru gitmez"},
                new Category { CategoryID=5,CategoryName="Tatlılar",CategoryDescription="Ufak bir kaçamak vakti..."},
                new Category { CategoryID=6,CategoryName="Atıştırmalıklar",CategoryDescription="Eğlence ortamının vazgeçilmezleri:)"}
                
                
                );
            modelBuilder.Entity<Admin>().HasData(
                new Admin { AdminID = 1, UserName = "Mikdat", Password = "1234", AdminRole = "A" }
                );
        }
    }
}
