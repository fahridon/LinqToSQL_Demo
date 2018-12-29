using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace LinqSqlTest
{
    [Database(Name="Northwind")]
    public partial class Northwind:DataContext
    {
        public Northwind(): base("Data Source=.; Initial Catalog=Northwind; Integrated Security=True;")
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
            //Northwind db = new Northwind();

            //var urunler = from p in db.Urunler
            //              select p;

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine(urun.UrunAdi);
            //}
        }
    }
}
