using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Reflection;

namespace LinqSqlTest
{
    [Database(Name="Northwind")]
    public partial class Northwind:DataContext
    {
        public Northwind(): base("Data Source=C0010490087\\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True;")
        {

        }
        public Table<Urun> Urunler
        {
            get
            {
                return this.GetTable<Urun>();
            }
        }
        public Table<Kategori> Kategoriler
        {
            get
            {
                return this.GetTable<Kategori>();
            }
        }
        [Function(Name = "dbo.EnUzunSatistakiUrun")]
        public ISingleResult<Urun> EnUzunSatistakiUrun()
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
            return ((ISingleResult<Urun>)(result.ReturnValue));
        }
    }
    [Table(Name ="dbo.Table_Urun")]
    public partial class Urun
    {
        private int _UrunId;
        private string _UrunAdi;
        private System.Nullable<decimal> _Fiyat;
        private System.Nullable<int> _KategoriId;
        private System.Nullable<DateTime> _SatisBaslangicTarihi;
        private System.Nullable<DateTime> _SatisBitisTarihi;

        public Urun()
        {

        }

        [Column(Storage ="_UrunId",DbType ="Int NOT NULL",IsPrimaryKey =true)]
        public int UrunId
        {
            get { return this._UrunId; }
            set { this._UrunId = value; }
        }

        [Column(Storage ="_UrunAdi",DbType ="NVarChar(50)")]
        public string UrunAdi
        {
            get { return this._UrunAdi; }
            set { this._UrunAdi = value; }
        }

        [Column(Storage = "_Fiyat", DbType = "Decimal(18,0)")]
        public System.Nullable<decimal> Fiyat
        {
            get { return this._Fiyat; }
            set { this._Fiyat = value; }
        }

        [Column(Storage = "_KategoriId", DbType = "Int")]
        public System.Nullable<int> KategoriId
        {
            get { return this._KategoriId; }
            set { this._KategoriId = value; }
        }

        [Column(Storage = "_SatisBaslangicTarihi", DbType = "DateTime")]
        public System.Nullable<System.DateTime> SatisBaslangicTarihi
        {
            get { return this._SatisBaslangicTarihi; }
            set { this._SatisBaslangicTarihi = value; }
        }

        [Column(Storage = "_SatisBitisTarihi", DbType = "DateTime")]
        public System.Nullable<System.DateTime> SatisBitisTarihi
        {
            get { return this._SatisBitisTarihi; }
            set { this._SatisBitisTarihi = value; }
        }
    }

    [Table(Name ="dbo.Table_Kategori")]
    public partial class Kategori
    {
        private System.Nullable<int> _KategoriId;
        private string _KategoriAdi;

        public Kategori()
        {

        }

        [Column(Storage ="_KategoriId", DbType ="Int NOT NULL", IsPrimaryKey =true)]
        public System.Nullable<int> KategoriId
        {
            get { return this._KategoriId; }
            set { this._KategoriId = value; }
        }

        [Column(Storage = "_KategoriAdi", DbType = "NVarChar(50)")]
        public string KategoriAdi
        {
            get { return this._KategoriAdi; }
            set { this._KategoriAdi = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Northwind db = new Northwind();

            //var urunler = from p in db.Urunler
            //              where p.Fiyat > 100
            //              select p;

            //var urunler = from u in db.Urunler
            //              join k in db.Kategoriler
            //              on u.KategoriId equals k.KategoriId
            //              select new { u.UrunAdi, k.KategoriAdi, u.Fiyat };

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine(urun.UrunAdi + " " + urun.KategoriAdi + " " + urun.Fiyat);
            //}

            //var kategoriler = (from k in db.Kategoriler select k.KategoriId)
            //    .Except((from u in db.Urunler select u.KategoriId).Distinct());

            //foreach (var item in kategoriler)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //var urunler2 = from u in db.Urunler
            //               where u.UrunAdi.Contains("A")
            //               select u.UrunAdi;

            //foreach (var urun in urunler2)
            //{
            //    Console.WriteLine(urun);
            //}

            //yeni kayıt ekle örneği
            //Kategori yeniKategori = new Kategori();
            //yeniKategori.KategoriId = 9;
            //yeniKategori.KategoriAdi = "Hediyelik Eşya";

            //db.Kategoriler.InsertOnSubmit(yeniKategori);
            //db.SubmitChanges();

            ////tüm fiyatlara 5 ekle örneği

            //var urunler = from u in db.Urunler
            //              select u;

            //foreach (var item in urunler)
            //{
            //    item.Fiyat += 5;
            //}

            //db.SubmitChanges();

            ////kayıt silme örneği

            //var silinecek = (from u in db.Urunler
            //                 where u.UrunId == 8
            //                 select u).Single();

            //db.Urunler.DeleteOnSubmit(silinecek);
            //db.SubmitChanges();

            //stored procedure örneği

            string urunAdi = db.EnUzunSatistakiUrun().Single().UrunAdi;
            Console.WriteLine(urunAdi);
        }
    }
}
