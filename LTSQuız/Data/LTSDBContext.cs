using LTSQuız.Models;
using Microsoft.EntityFrameworkCore;

namespace LTSQuız.Data
{
    public class LTSDBContext : DbContext
    {
        public LTSDBContext(DbContextOptions<LTSDBContext> options) : base(options) { }

        public DbSet<KullanıcıTbl>Kullanıcılar { get; set; }
        public DbSet<HesapKartTbl>Kartlar { get; set; }
        public DbSet<HesapKartTipTbl>KartTipleri { get; set; }
        public DbSet<HesapKartTurTbl>KartTurleri { get; set; }
        public DbSet<HesapKartGrupTbl>KartGrupları { get; set; }
        public DbSet<HesapKartAltGrupTbl>KartAltGrupları { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<KullanıcıTbl>().HasData(
                                           new KullanıcıTbl { UserID = 1, Ad = "Fatih Serdar", Soyad="Karataş",KullaniciAdi="fatihserdarkrts",Sifre="123456",Email="fatihserdarkrts@gmail.com",TelefonNo="05300220158" },
                                           new KullanıcıTbl { UserID = 2, Ad = "Tahir", Soyad = "Karataş", KullaniciAdi = "tahirkrts", Sifre = "123456", Email = "tahirkrts@gmail.com", TelefonNo = "05300220158" },
                                           new KullanıcıTbl { UserID = 3, Ad = "Emine", Soyad = "Karataş", KullaniciAdi = "eminekrts", Sifre = "123456", Email = "eminekrts@gmail.com", TelefonNo = "05300220158" },
                                           new KullanıcıTbl { UserID = 4, Ad = "Fatma Sude", Soyad = "Karataş", KullaniciAdi = "fatmasudekrts", Sifre = "123456", Email = "fatmasudekrts@gmail.com", TelefonNo = "05300220158" },
                                           new KullanıcıTbl { UserID = 5, Ad = "Osman Efe", Soyad = "Karataş", KullaniciAdi = "osmanefekrts", Sifre = "123456", Email = "fatmasudekrts@gmail.com", TelefonNo = "05300220158" }
                                          );
            modelBuilder.Entity<HesapKartTbl>().HasData(
                new HesapKartTbl {KartID = 1,Unvan="?????",VergiDairesi="Sultangazi",VergiNo=5456464,Tc=111111111,Adres="İstanbul İkitelli" },
                new HesapKartTbl {KartID = 2,Unvan="?????",VergiDairesi="Sultangazi",VergiNo=5456464,Tc=222222222,Adres="İstanbul İkitelli" },
                new HesapKartTbl {KartID = 3,Unvan="?????",VergiDairesi="Sultangazi",VergiNo=5456464,Tc=333333333,Adres="İstanbul İkitelli" },
                new HesapKartTbl {KartID = 4,Unvan="?????",VergiDairesi="Sultangazi",VergiNo=5456464,Tc=444444444,Adres="İstanbul İkitelli" }

                );
            modelBuilder.Entity<HesapKartTipTbl>().HasData(
                new HesapKartTipTbl { TipID = 1,TipAdi="Banka Kartı"},
                new HesapKartTipTbl { TipID = 2,TipAdi="Kredi Kartı"}
               

                );
            modelBuilder.Entity<HesapKartTurTbl>().HasData(
                new HesapKartTurTbl { TurID = 1,TurAdi="Klasik Kart"},
                new HesapKartTurTbl { TurID = 2,TurAdi="Silver Kart"},
                new HesapKartTurTbl { TurID = 3,TurAdi="Gold Kart"},
                new HesapKartTurTbl { TurID = 4,TurAdi="Platin Kart"}
                
                );
            modelBuilder.Entity<HesapKartGrupTbl>().HasData(
                new HesapKartGrupTbl { GrupID = 1, GrupAdi="Grup1"},
                new HesapKartGrupTbl { GrupID = 2, GrupAdi="Grup2"}
                
                
                );
            modelBuilder.Entity<HesapKartAltGrupTbl>().HasData(
                new HesapKartAltGrupTbl { AltGrupID=1,AltGrupAdi="AltGrup1"},
                new HesapKartAltGrupTbl { AltGrupID=2,AltGrupAdi="AltGrup2"}
                
                
                );


        }
        }
}
