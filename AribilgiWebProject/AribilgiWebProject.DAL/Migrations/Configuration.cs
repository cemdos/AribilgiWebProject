namespace AribilgiWebProject.DAL.Migrations
{
    using AribilgiWebProject.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AribilgiWebProject.DAL.NinicoDbEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AribilgiWebProject.DAL.NinicoDbEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            #region İller tablosu dolduruldu
            context.City.AddOrUpdate(new City { CityName = "ADANA" });
            context.City.AddOrUpdate(new City { CityName = "ADIYAMAN" });
            context.City.AddOrUpdate(new City { CityName = "AFYONKARAHİSAR" });
            context.City.AddOrUpdate(new City { CityName = "AĞRI" });
            context.City.AddOrUpdate(new City { CityName = "AMASYA" });
            context.City.AddOrUpdate(new City { CityName = "ANKARA" });
            context.City.AddOrUpdate(new City { CityName = "ANTALYA" });
            context.City.AddOrUpdate(new City { CityName = "ARTVİN" });
            context.City.AddOrUpdate(new City { CityName = "AYDIN" });
            context.City.AddOrUpdate(new City { CityName = "BALIKESİR" });
            context.City.AddOrUpdate(new City { CityName = "BİLECİK" });
            context.City.AddOrUpdate(new City { CityName = "BİNGÖL" });
            context.City.AddOrUpdate(new City { CityName = "BİTLİS" });
            context.City.AddOrUpdate(new City { CityName = "BOLU" });
            context.City.AddOrUpdate(new City { CityName = "BURDUR" });
            context.City.AddOrUpdate(new City { CityName = "BURSA" });
            context.City.AddOrUpdate(new City { CityName = "ÇANAKKALE" });
            context.City.AddOrUpdate(new City { CityName = "ÇANKIRI" });
            context.City.AddOrUpdate(new City { CityName = "ÇORUM" });
            context.City.AddOrUpdate(new City { CityName = "DENİZLİ" });
            context.City.AddOrUpdate(new City { CityName = "DİYARBAKIR" });
            context.City.AddOrUpdate(new City { CityName = "EDİRNE" });
            context.City.AddOrUpdate(new City { CityName = "ELAZIĞ" });
            context.City.AddOrUpdate(new City { CityName = "ERZİNCAN" });
            context.City.AddOrUpdate(new City { CityName = "ERZURUM" });
            context.City.AddOrUpdate(new City { CityName = "ESKİŞEHİR" });
            context.City.AddOrUpdate(new City { CityName = "GAZİANTEP" });
            context.City.AddOrUpdate(new City { CityName = "GİRESUN" });
            context.City.AddOrUpdate(new City { CityName = "GÜMÜŞHANE" });
            context.City.AddOrUpdate(new City { CityName = "HAKKARİ" });
            context.City.AddOrUpdate(new City { CityName = "HATAY" });
            context.City.AddOrUpdate(new City { CityName = "ISPARTA" });
            context.City.AddOrUpdate(new City { CityName = "MERSİN" });
            context.City.AddOrUpdate(new City { CityName = "İSTANBUL" });
            context.City.AddOrUpdate(new City { CityName = "İZMİR" });
            context.City.AddOrUpdate(new City { CityName = "KARS" });
            context.City.AddOrUpdate(new City { CityName = "KASTAMONU" });
            context.City.AddOrUpdate(new City { CityName = "KAYSERİ" });
            context.City.AddOrUpdate(new City { CityName = "KIRKLARELİ" });
            context.City.AddOrUpdate(new City { CityName = "KIRŞEHİR" });
            context.City.AddOrUpdate(new City { CityName = "KOCAELİ" });
            context.City.AddOrUpdate(new City { CityName = "KONYA" });
            context.City.AddOrUpdate(new City { CityName = "KÜTAHYA" });
            context.City.AddOrUpdate(new City { CityName = "MALATYA" });
            context.City.AddOrUpdate(new City { CityName = "MANİSA" });
            context.City.AddOrUpdate(new City { CityName = "KAHRAMANMARAŞ" });
            context.City.AddOrUpdate(new City { CityName = "MARDİN" });
            context.City.AddOrUpdate(new City { CityName = "MUĞLA" });
            context.City.AddOrUpdate(new City { CityName = "MUŞ" });
            context.City.AddOrUpdate(new City { CityName = "NEVŞEHİR" });
            context.City.AddOrUpdate(new City { CityName = "NİĞDE" });
            context.City.AddOrUpdate(new City { CityName = "ORDU" });
            context.City.AddOrUpdate(new City { CityName = "RİZE" });
            context.City.AddOrUpdate(new City { CityName = "SAKARYA" });
            context.City.AddOrUpdate(new City { CityName = "SAMSUN" });
            context.City.AddOrUpdate(new City { CityName = "SİİRT" });
            context.City.AddOrUpdate(new City { CityName = "SİNOP" });
            context.City.AddOrUpdate(new City { CityName = "SİVAS" });
            context.City.AddOrUpdate(new City { CityName = "TEKİRDAĞ" });
            context.City.AddOrUpdate(new City { CityName = "TOKAT" });
            context.City.AddOrUpdate(new City { CityName = "TRABZON" });
            context.City.AddOrUpdate(new City { CityName = "TUNCELİ" });
            context.City.AddOrUpdate(new City { CityName = "ŞANLIURFA" });
            context.City.AddOrUpdate(new City { CityName = "UŞAK" });
            context.City.AddOrUpdate(new City { CityName = "VAN" });
            context.City.AddOrUpdate(new City { CityName = "YOZGAT" });
            context.City.AddOrUpdate(new City { CityName = "ZONGULDAK" });
            context.City.AddOrUpdate(new City { CityName = "AKSARAY" });
            context.City.AddOrUpdate(new City { CityName = "BAYBURT" });
            context.City.AddOrUpdate(new City { CityName = "KARAMAN" });
            context.City.AddOrUpdate(new City { CityName = "KIRIKKALE" });
            context.City.AddOrUpdate(new City { CityName = "BATMAN" });
            context.City.AddOrUpdate(new City { CityName = "ŞIRNAK" });
            context.City.AddOrUpdate(new City { CityName = "BARTIN" });
            context.City.AddOrUpdate(new City { CityName = "ARDAHAN" });
            context.City.AddOrUpdate(new City { CityName = "IĞDIR" });
            context.City.AddOrUpdate(new City { CityName = "YALOVA" });
            context.City.AddOrUpdate(new City { CityName = "KARABÜK" });
            context.City.AddOrUpdate(new City { CityName = "KİLİS" });
            context.City.AddOrUpdate(new City { CityName = "OSMANİYE" });
            context.City.AddOrUpdate(new City { CityName = "DÜZCE" });
            #endregion

        }
    }
}
