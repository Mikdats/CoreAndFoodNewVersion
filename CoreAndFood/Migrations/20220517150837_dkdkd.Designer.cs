﻿// <auto-generated />
using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreAndFood.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220517150837_dkdkd")]
    partial class dkdkd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoreAndFood.Data.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"), 1L, 1);

                    b.Property<string>("AdminRole")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminID = 1,
                            AdminRole = "A",
                            Password = "1234",
                            UserName = "Mikdat"
                        });
                });

            modelBuilder.Entity("CoreAndFood.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryDescription = "Tazeliğine güveniyoruz",
                            CategoryName = "Meyveler",
                            Status = false
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryDescription = "Organik mahsüller",
                            CategoryName = "Sebzeler",
                            Status = false
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryDescription = "Olmazsa olmazlarımız",
                            CategoryName = "Bakliyat",
                            Status = false
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryDescription = "E kuru kuru gitmez",
                            CategoryName = "İçecekler",
                            Status = false
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryDescription = "Ufak bir kaçamak vakti...",
                            CategoryName = "Tatlılar",
                            Status = false
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryDescription = "Eğlence ortamının vazgeçilmezleri:)",
                            CategoryName = "Atıştırmalıklar",
                            Status = false
                        });
                });

            modelBuilder.Entity("CoreAndFood.Data.Models.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("FoodID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodID = 1,
                            CategoryID = 1,
                            Description = "Amasya Elması",
                            ImageURL = "https://iaftm.tmgrup.com.tr/71e064/1200/627/41/0/999/500?u=https://iftm.tmgrup.com.tr/2021/11/11/elmada-hangi-vitaminler-var-elmanin-faydalari-nelerdir-1636620796310.jpeg",
                            Name = "Elma",
                            Price = 6.0,
                            Stock = 100
                        },
                        new
                        {
                            FoodID = 2,
                            CategoryID = 1,
                            Description = "Antalya Portakalı",
                            ImageURL = "https://thumbs.dreamstime.com/b/orange-fruit-green-leaves-isolated-white-background-clipping-path-full-depth-field-fresh-186720104.jpg",
                            Name = "Portakal",
                            Price = 7.0,
                            Stock = 140
                        },
                        new
                        {
                            FoodID = 3,
                            CategoryID = 2,
                            Description = "Kıpkırmızı Domastesler",
                            ImageURL = "https://media.istockphoto.com/photos/tomato-with-slice-isolated-with-clipping-path-picture-id941825878?k=20&m=941825878&s=612x612&w=0&h=Qx5wYoEKsig3BGfhHAb2ZUqRBrhi6k64ZbXp3_zhj4o=",
                            Name = "Domates",
                            Price = 5.0,
                            Stock = 170
                        },
                        new
                        {
                            FoodID = 4,
                            CategoryID = 4,
                            Description = "Buz gibi gider",
                            ImageURL = "https://tasomarket.com/files/products/nigde-gazozu-6-li-200-ml.jpg",
                            Name = "Gazoz",
                            Price = 7.0,
                            Stock = 85
                        },
                        new
                        {
                            FoodID = 5,
                            CategoryID = 3,
                            Description = "Osmancık pirinci",
                            ImageURL = "https://st.depositphotos.com/1056373/1930/i/450/depositphotos_19303341-stock-photo-long-grain-rice-in-a.jpg",
                            Name = "Pirinç",
                            Price = 11.0,
                            Stock = 110
                        },
                        new
                        {
                            FoodID = 6,
                            CategoryID = 2,
                            Description = "Kızartmalık patates",
                            ImageURL = "https://img.memurlar.net/galeri/11588/headline.jpg",
                            Name = "Patates",
                            Price = 4.0,
                            Stock = 150
                        },
                        new
                        {
                            FoodID = 7,
                            CategoryID = 4,
                            Description = "Soğuk içiniz",
                            ImageURL = "https://media.istockphoto.com/photos/glass-of-apple-juice-with-apples-picture-id173828042?b=1&k=20&m=173828042&s=170667a&w=0&h=nK1wnvH8MYUxGzS3wqS_kUTzdmJ1i7I1BEd90-gJ0jY=",
                            Name = "Elma Suyu",
                            Price = 9.0,
                            Stock = 180
                        },
                        new
                        {
                            FoodID = 8,
                            CategoryID = 5,
                            Description = "Tatlıların tatlısı",
                            ImageURL = "https://icdn.tgrthaber.com.tr/static/haberler/2019_10/buyuk/profiterol-tarifi-ve-profiterol-nasil-yapilir-kolay-profiterol-yapimi-ve-tarifi-1572505399.jpg",
                            Name = "Profiterol",
                            Price = 16.0,
                            Stock = 75
                        },
                        new
                        {
                            FoodID = 9,
                            CategoryID = 6,
                            Description = "Atıştırma vakti",
                            ImageURL = "https://galeri13.uludagsozluk.com/722/canin-cips-cekmesi_1756041_m.jpg",
                            Name = "Cips",
                            Price = 8.0,
                            Stock = 65
                        },
                        new
                        {
                            FoodID = 10,
                            CategoryID = 6,
                            Description = "Çayın ortağı",
                            ImageURL = "https://media.istockphoto.com/photos/industrial-sweet-biscuit-picture-id869217802?k=20&m=869217802&s=170667a&w=0&h=HmF5q4fyWHCUh9wYyHfYN-kuLaZO7mVLRs2wvAz5fhA=",
                            Name = "Bisküvi",
                            Price = 4.0,
                            Stock = 140
                        },
                        new
                        {
                            FoodID = 11,
                            CategoryID = 5,
                            Description = "Tatlı krizine son",
                            ImageURL = "https://maksatbilgi.com/wp-content/uploads/2021/08/kazandibi-tarifi-one-cikan.jpg",
                            Name = "Kazandibi",
                            Price = 12.0,
                            Stock = 60
                        });
                });

            modelBuilder.Entity("CoreAndFood.Data.Models.Food", b =>
                {
                    b.HasOne("CoreAndFood.Data.Models.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoreAndFood.Data.Models.Category", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
