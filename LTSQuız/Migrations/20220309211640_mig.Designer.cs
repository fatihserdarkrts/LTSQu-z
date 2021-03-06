// <auto-generated />
using LTSQuız.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LTSQuız.Migrations
{
    [DbContext(typeof(LTSDBContext))]
    [Migration("20220309211640_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LTSQuız.Models.HesapKartAltGrupTbl", b =>
                {
                    b.Property<int>("AltGrupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AltGrupID"), 1L, 1);

                    b.Property<string>("AltGrupAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AltGrupID");

                    b.ToTable("KartAltGrupları");

                    b.HasData(
                        new
                        {
                            AltGrupID = 1,
                            AltGrupAdi = "AltGrup1"
                        },
                        new
                        {
                            AltGrupID = 2,
                            AltGrupAdi = "AltGrup2"
                        });
                });

            modelBuilder.Entity("LTSQuız.Models.HesapKartGrupTbl", b =>
                {
                    b.Property<int>("GrupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GrupID"), 1L, 1);

                    b.Property<string>("GrupAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GrupID");

                    b.ToTable("KartGrupları");

                    b.HasData(
                        new
                        {
                            GrupID = 1,
                            GrupAdi = "Grup1"
                        },
                        new
                        {
                            GrupID = 2,
                            GrupAdi = "Grup2"
                        });
                });

            modelBuilder.Entity("LTSQuız.Models.HesapKartTbl", b =>
                {
                    b.Property<int>("KartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KartID"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("AltGrupID")
                        .HasColumnType("int");

                    b.Property<int>("GrupID")
                        .HasColumnType("int");

                    b.Property<int>("Tc")
                        .HasColumnType("int");

                    b.Property<int>("TipID")
                        .HasColumnType("int");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VergiNo")
                        .HasColumnType("int");

                    b.HasKey("KartID");

                    b.ToTable("Kartlar");

                    b.HasData(
                        new
                        {
                            KartID = 1,
                            Adres = "İstanbul İkitelli",
                            AltGrupID = 0,
                            GrupID = 0,
                            Tc = 111111111,
                            TipID = 0,
                            TurID = 0,
                            Unvan = "?????",
                            VergiDairesi = "Sultangazi",
                            VergiNo = 5456464
                        },
                        new
                        {
                            KartID = 2,
                            Adres = "İstanbul İkitelli",
                            AltGrupID = 0,
                            GrupID = 0,
                            Tc = 222222222,
                            TipID = 0,
                            TurID = 0,
                            Unvan = "?????",
                            VergiDairesi = "Sultangazi",
                            VergiNo = 5456464
                        },
                        new
                        {
                            KartID = 3,
                            Adres = "İstanbul İkitelli",
                            AltGrupID = 0,
                            GrupID = 0,
                            Tc = 333333333,
                            TipID = 0,
                            TurID = 0,
                            Unvan = "?????",
                            VergiDairesi = "Sultangazi",
                            VergiNo = 5456464
                        },
                        new
                        {
                            KartID = 4,
                            Adres = "İstanbul İkitelli",
                            AltGrupID = 0,
                            GrupID = 0,
                            Tc = 444444444,
                            TipID = 0,
                            TurID = 0,
                            Unvan = "?????",
                            VergiDairesi = "Sultangazi",
                            VergiNo = 5456464
                        });
                });

            modelBuilder.Entity("LTSQuız.Models.HesapKartTipTbl", b =>
                {
                    b.Property<int>("TipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipID"), 1L, 1);

                    b.Property<string>("TipAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipID");

                    b.ToTable("KartTipleri");

                    b.HasData(
                        new
                        {
                            TipID = 1,
                            TipAdi = "Banka Kartı"
                        },
                        new
                        {
                            TipID = 2,
                            TipAdi = "Kredi Kartı"
                        });
                });

            modelBuilder.Entity("LTSQuız.Models.HesapKartTurTbl", b =>
                {
                    b.Property<int>("TurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TurID"), 1L, 1);

                    b.Property<string>("TurAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurID");

                    b.ToTable("KartTurleri");

                    b.HasData(
                        new
                        {
                            TurID = 1,
                            TurAdi = "Klasik Kart"
                        },
                        new
                        {
                            TurID = 2,
                            TurAdi = "Silver Kart"
                        },
                        new
                        {
                            TurID = 3,
                            TurAdi = "Gold Kart"
                        },
                        new
                        {
                            TurID = 4,
                            TurAdi = "Platin Kart"
                        });
                });

            modelBuilder.Entity("LTSQuız.Models.KullanıcıTbl", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Kullanıcılar");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Ad = "Fatih Serdar",
                            Email = "fatihserdarkrts@gmail.com",
                            KullaniciAdi = "fatihserdarkrts",
                            Sifre = "123456",
                            Soyad = "Karataş",
                            TelefonNo = "05300220158"
                        },
                        new
                        {
                            UserID = 2,
                            Ad = "Tahir",
                            Email = "tahirkrts@gmail.com",
                            KullaniciAdi = "tahirkrts",
                            Sifre = "123456",
                            Soyad = "Karataş",
                            TelefonNo = "05300220158"
                        },
                        new
                        {
                            UserID = 3,
                            Ad = "Emine",
                            Email = "eminekrts@gmail.com",
                            KullaniciAdi = "eminekrts",
                            Sifre = "123456",
                            Soyad = "Karataş",
                            TelefonNo = "05300220158"
                        },
                        new
                        {
                            UserID = 4,
                            Ad = "Fatma Sude",
                            Email = "fatmasudekrts@gmail.com",
                            KullaniciAdi = "fatmasudekrts",
                            Sifre = "123456",
                            Soyad = "Karataş",
                            TelefonNo = "05300220158"
                        },
                        new
                        {
                            UserID = 5,
                            Ad = "Osman Efe",
                            Email = "fatmasudekrts@gmail.com",
                            KullaniciAdi = "osmanefekrts",
                            Sifre = "123456",
                            Soyad = "Karataş",
                            TelefonNo = "05300220158"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
