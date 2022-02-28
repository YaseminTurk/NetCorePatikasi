namespace TelefonRehberiUygulaması
{
    class Kisi
    {
        public string ad;
        public string soyad;
        public string telNo;
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string TelNo { get => telNo; set => telNo = value; }

        public Kisi(string ad, string soyad, string telNo)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.TelNo = telNo;
        }
    }
}
