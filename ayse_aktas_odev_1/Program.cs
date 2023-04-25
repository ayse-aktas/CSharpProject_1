namespace ayse_aktas_odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlamalar

            Nokta nokta1 = new Nokta(5, 5);
            Nokta nokta2 = new Nokta(25, 5);
            Nokta nokta3 = new Nokta(5, 6);
            Nokta nokta4 = new Nokta(3, 1);
            Nokta nokta5 = new Nokta(7, 4, 8);

            Cember cember1 = new Cember(4, 8, 3);
            Cember cember2 = new Cember(2, 3, 2);
            Cember cember3 = new Cember(0, 0, 3);
            Cember cember4 = new Cember(3, 0, 2);
            Cember cember5 = new Cember(0, 0, 5);
            Cember cember6 = new Cember(2, 3, 4);

            Dikdortgen d1 = new Dikdortgen(5, 10, 10, 5);
            Dikdortgen d2 = new Dikdortgen(4, 10, 5, 5);
            Dikdortgen d3 = new Dikdortgen(3, 4, 7, 2);
            Dikdortgen d4 = new Dikdortgen(4, 3, 7, 0);
            Dikdortgen d5 = new Dikdortgen(5, 10, 10, 20);
            Dikdortgen d6 = new Dikdortgen(30, 7, 10, 20);
            Dikdortgen d7 = new Dikdortgen(10, 10, 2, 2);
            Dikdortgen d8 = new Dikdortgen(3, 2, 5, 3);

            Kure k1 = new Kure(4, 5, 7, 3);
            Kure k2 = new Kure(2, 3, 4, 5);
            Kure k3 = new Kure(10, 12, 17, 3);
            Kure k4 = new Kure(15, 8, 2, 4);

            DikdortgenPrizma dp1 = new DikdortgenPrizma(7, 5, 5, 3, 4, 10);
            DikdortgenPrizma dp2 = new DikdortgenPrizma(7, 7, 3, 4, 6, 5);
            DikdortgenPrizma dp3 = new DikdortgenPrizma(10, 7, 3, 2, 6, 5);

            Silindir s1 = new Silindir(5, 5, 5, 6, 10);
            Silindir s2 = new Silindir(4, 3, 6, 5, 8);
            Silindir s3 = new Silindir(10, 20, 18, 4, 5);

            Yuzey y1 = new Yuzey(6, "X");
            Yuzey y2 = new Yuzey(7, "Z");
            Yuzey y3 = new Yuzey(8, "Y");
            #endregion

            #region Öğrenci Bilgileri
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**\t\t\t\tSAKARYA ÜNİVERSİTESİ");
            Console.WriteLine("**\t\t\tBİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ");
            Console.WriteLine("**\t\t\t   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ");
            Console.WriteLine("**\t\t\t   NESNEYE DAYALI PROGRAMLAMA DERSİ");
            Console.WriteLine("**");
            Console.WriteLine("**\t\t\t\tÖDEV NUMARASI:1");
            Console.WriteLine("**\t\t\t\tÖĞRENCİ ADI:Ayşe Aktaş");
            Console.WriteLine("**\t\t\t\tÖĞRENCİ NUMARASI:B221210036");
            Console.WriteLine("**\t\t\t\tDERS GRUBU:1-B");
            Console.WriteLine("**************************************************************************************");
            #endregion

            #region Çarpışma Denetim Örnekleri
            Console.WriteLine();
            Console.WriteLine("--------------------------------Cisim Gösterimleri------------------------------------");
            Console.WriteLine("Nokta                :   (X,Y,Z)");
            Console.WriteLine("Dikdörtgen           :   (X,Y,Yükseklik,En)");
            Console.WriteLine("Çember               :   (X,Y,Yarıçap)");
            Console.WriteLine("Küre                 :   (X,Y,Z,Yarıçap)");
            Console.WriteLine("Dikdörtgen Prizma    :   (X,Y,Z,En,Yükseklik,Derinlik)");
            Console.WriteLine("Silindir             :   (X,Y,Z,Yaricap,Yükseklik)");
            Console.WriteLine("Yüzey                :   (Kesişim Noktası,Düzlemi 90 derece kesen eksen)");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("Cisim1                             Cisim2                             Çarpışma Durumu");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            //a) Nokta, Dörtgen çarpışma denetimi
            CarpismaDenetimi.NoktaDortgen(nokta2, d6);
            CarpismaDenetimi.NoktaDortgen(nokta1, d5);
            Console.WriteLine();

            //b) Nokta, çember çarpışma denetimi
            CarpismaDenetimi.NoktaCember(nokta3, cember1);
            CarpismaDenetimi.NoktaCember(nokta1, cember1);
            Console.WriteLine();

            //c) Dikdörtgen, dikdörtgen çarpışma denetimi
            CarpismaDenetimi.DikdortgenDikdortgen(d1, d2);
            CarpismaDenetimi.DikdortgenDikdortgen(d3, d4);
            Console.WriteLine();

            //d) Dikdörtgen, çember çarpışma denetimi
            CarpismaDenetimi.DikdortgenCember(d8, cember6);
            CarpismaDenetimi.DikdortgenCember(d7, cember5);
            Console.WriteLine();

            // e) Çember, çember çarpışma denetimi
            CarpismaDenetimi.CemberCember(cember3, cember4);
            CarpismaDenetimi.CemberCember(cember1, cember2);
            Console.WriteLine();

            //f) Nokta, Küre çarpışma denetimi
            CarpismaDenetimi.NoktaKure(k2, nokta4);
            CarpismaDenetimi.NoktaKure(k1, nokta1);
            Console.WriteLine();

            //g)Nokta, dikdörtgen prizma çarpışma denetimi  
            CarpismaDenetimi.NoktaDikdortgenPrizma(dp1, nokta5);
            CarpismaDenetimi.NoktaDikdortgenPrizma(dp1, nokta4);
            Console.WriteLine();

            //h) Nokta, Silindir çarpışma denetimi
            CarpismaDenetimi.NoktaSilindir(s2, nokta5);
            CarpismaDenetimi.NoktaSilindir(s1, nokta4);
            Console.WriteLine();

            //i) Silindir, silindir çarpışma denetimi
            CarpismaDenetimi.SilindirSilindir(s1, s2);
            CarpismaDenetimi.SilindirSilindir(s2, s3);
            Console.WriteLine();

            //j) Küre, küre çarpışma denetimi
            CarpismaDenetimi.KureKure(k1, k2);
            CarpismaDenetimi.KureKure(k1, k3);
            Console.WriteLine();

            //k) Küre silindir çarpışma denetimi
            CarpismaDenetimi.KureSilindir(k1, s1);
            CarpismaDenetimi.KureSilindir(k4, s2);
            Console.WriteLine();

            //l) Yüzey, küre çarpışma denetimi
            CarpismaDenetimi.YuzeyKure(y1, k1);
            CarpismaDenetimi.YuzeyKure(y2, k3);
            Console.WriteLine();

            //m) Yüzey, dikdörtgen prizma çarpışma denetimi
            CarpismaDenetimi.YuzeyDikdortgenP(y1, dp2);
            CarpismaDenetimi.YuzeyDikdortgenP(y2, dp3);
            Console.WriteLine();

            //n) Yüzey silindir çarpışma denetimi
            CarpismaDenetimi.YuzeySilindir(y1, s1);
            CarpismaDenetimi.YuzeySilindir(y3, s2);
            Console.WriteLine();

            //o) Küre, dikdörtgen prizma çarpışma denetimi
            CarpismaDenetimi.KureDikdortgenP(k1, dp2);
            CarpismaDenetimi.KureDikdortgenP(k1, dp3);
            Console.WriteLine();

            //p) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi
            CarpismaDenetimi.DikdortgenPDikdortgenP(dp1, dp2);
            CarpismaDenetimi.DikdortgenPDikdortgenP(dp2, dp3);
            Console.WriteLine();
            #endregion

            #region Deneme Alanı
            char karar;
            do
            {
                Console.WriteLine();
                Console.WriteLine("**************************************************************************************");
                Console.WriteLine("1)\tNokta, dörtgen çarpışma denetimi");
                Console.WriteLine("2)\tNokta, çember çarpışma denetimi");
                Console.WriteLine("3)\tDikdörtgen, dikdörtgen çarpışma denetimi");
                Console.WriteLine("4)\tDikdörtgen, çember çarpışma denetimi");
                Console.WriteLine("5)\tÇember, çember çarpışma denetimi");
                Console.WriteLine("6)\tNokta, küre çarpışma denetimi");
                Console.WriteLine("7)\tNokta, dikdörtgen prizma çarpışma denetimi");
                Console.WriteLine("8)\tNokta, silindir çarpışma denetimi");
                Console.WriteLine("9)\tSilindir, silindir çarpışma denetimi");
                Console.WriteLine("10)\tKüre, küre çarpışma denetimi");
                Console.WriteLine("11)\tKüre silindir çarpışma denetimi");
                Console.WriteLine("12)\tYüzey, küre çarpışma denetimi");
                Console.WriteLine("13)\tYüzey, dikdörtgen prizma çarpışma denetimi");
                Console.WriteLine("14)\tYüzey silindir çarpışma denetimi");
                Console.WriteLine("15)\tKüre, dikdörtgen prizma çarpışma denetimi");
                Console.WriteLine("16)\tDikdörtgen prizma, dikdörtgen prizma çarpışma denetimi");
                Console.WriteLine();
                Console.WriteLine("**************************************************************************************");
                Console.WriteLine("Hangi çarpışmayı kontrol etmek istersiniz ?");
                int secenek = TamSayiGiris();
                if (secenek == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("---Nokta, dörtgen çarpışma denetimi---");
                    Nokta n = NoktaOlustur();
                    Dikdortgen d = DikdortgenOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.NoktaDortgen(n, d);
                }
                else if (secenek == 2)
                {
                    Console.WriteLine("---Nokta, çember çarpışma denetimi---");
                    Nokta n = NoktaOlustur();
                    Cember c = CemberOlustur();
                    CarpismaDenetimi.NoktaCember(n, c);
                }
                else if (secenek == 3)
                {
                    Console.WriteLine("---Dikdörtgen, dikdörtgen çarpışma denetimi---");
                    Dikdortgen da = DikdortgenOlustur();
                    Dikdortgen db = DikdortgenOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.DikdortgenDikdortgen(da, db);
                }
                else if (secenek == 4)
                {
                    Console.WriteLine("---Dikdörtgen, çember çarpışma denetimi---");
                    Dikdortgen d = DikdortgenOlustur();
                    Cember c = CemberOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.DikdortgenCember(d, c);
                }
                else if (secenek == 5)
                {
                    Console.WriteLine("---Çember, çember çarpışma denetimi---");
                    Cember c1 = CemberOlustur();
                    Cember c2 = CemberOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.CemberCember(c1, c2);
                }
                else if (secenek == 6)
                {
                    Console.WriteLine("---Nokta, Küre çarpışma denetimi---");
                    Nokta n = NoktaOlustur();
                    Kure k = KureOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.NoktaKure(k, n);
                }
                else if (secenek == 7)
                {
                    Console.WriteLine("---Nokta, dikdörtgen prizma çarpışma denetimi---");
                    Nokta n = NoktaOlustur();
                    DikdortgenPrizma dp = DikdortgenPrizmaOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.NoktaDikdortgenPrizma(dp, n);
                }
                else if (secenek == 8)
                {
                    Console.WriteLine("---Nokta, Silindir çarpışma denetimi---");
                    Nokta n = NoktaOlustur();
                    Silindir s = SilindirOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.NoktaSilindir(s, n);
                }
                else if (secenek == 9)
                {
                    Console.WriteLine("---Silindir, silindir çarpışma denetimi---");
                    Silindir sa = SilindirOlustur();
                    Silindir sb = SilindirOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.SilindirSilindir(sa, sb);
                }
                else if (secenek == 10)
                {
                    Console.WriteLine("---Küre, küre çarpışma denetimi---");
                    Kure ka = KureOlustur();
                    Kure kb = KureOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.KureKure(ka, kb);
                }
                else if (secenek == 11)
                {
                    Console.WriteLine("---Küre silindir çarpışma denetimi---");
                    Kure k = KureOlustur();
                    Silindir s = SilindirOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.KureSilindir(k, s);
                }
                else if (secenek == 12)
                {
                    Console.WriteLine("---Yüzey, küre çarpışma denetimi---");
                    Yuzey y = YuzeyOlustur();
                    Kure k = KureOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.YuzeyKure(y, k);
                }
                else if (secenek == 13)
                {
                    Console.WriteLine("---Yüzey, dikdörtgen prizma çarpışma denetimi---");
                    Yuzey y = YuzeyOlustur();
                    DikdortgenPrizma dp = DikdortgenPrizmaOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.YuzeyDikdortgenP(y, dp);
                }
                else if (secenek == 14)
                {
                    Console.WriteLine("---Yüzey silindir çarpışma denetimi---");
                    Yuzey y = YuzeyOlustur();
                    Silindir s = SilindirOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.YuzeySilindir(y, s);

                }
                else if (secenek == 15)
                {
                    Console.WriteLine("---Küre, dikdörtgen prizma çarpışma denetimi---");
                    Kure k = KureOlustur();
                    DikdortgenPrizma dp = DikdortgenPrizmaOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.KureDikdortgenP(k, dp);
                }
                else if (secenek == 16)
                {
                    Console.WriteLine("---Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi---");
                    DikdortgenPrizma dpa = DikdortgenPrizmaOlustur();
                    DikdortgenPrizma dpb = DikdortgenPrizmaOlustur();
                    Console.WriteLine();
                    CarpismaDenetimi.DikdortgenPDikdortgenP(dpa, dpb);
                }
                else
                {
                    Console.WriteLine("---Hatalı giriş yaptınız!!!---");
                    Console.WriteLine("---Lütfen 1-16 arasında bir sayı girişi yapınız.---");
                    Console.WriteLine();
                }
                Console.Write("Başka bir kontrol yapmak için 'e' tuşuna, çıkış yapmak için farklı bir tuşa basınız :");
                karar = Console.ReadKey().KeyChar;
                karar = Char.ToLower(karar);
                Console.WriteLine();
                Console.WriteLine("**************************************************************************************");
            } while (karar == 'e');
            #endregion

        }
        public static int TamSayiGiris()
        {
            int sayi;
            while (true)
            {
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen sadece tam sayı giriniz.");
                }
            }
            return sayi;
        }
        public static Nokta NoktaOlustur()
        {
            Console.WriteLine("**Nokta**");
            Console.Write("X değerini giriniz: ");
            int X = TamSayiGiris();
            Console.Write("Y değerini giriniz: ");
            int Y = TamSayiGiris();
            return new Nokta(X, Y);
        }
        public static Dikdortgen DikdortgenOlustur()
        {
            Console.WriteLine("**Dikdörtgen**");
            Console.Write("Merkez X değerini giriniz :");
            int merkezX = TamSayiGiris();
            Console.Write("Merkez Y değerini giriniz :");
            int merkezY = TamSayiGiris();
            Console.Write("Yükseklik değerini giriniz :");
            int Yukseklik = TamSayiGiris();
            Console.Write("En değerini giriniz :");
            int En = TamSayiGiris();
            return new Dikdortgen(merkezX, merkezY, Yukseklik, En);
        }
        public static Cember CemberOlustur()
        {
            Console.WriteLine("**Çember**");
            Console.Write("X değerini giriniz: ");
            int merkezX = TamSayiGiris();
            Console.Write("Y değerini giriniz: ");
            int merkezY = TamSayiGiris();
            Console.Write("Yarıçap değerini giriniz: ");
            int Yaricap = TamSayiGiris();
            return new Cember(merkezX, merkezY, Yaricap);
        }
        public static Kure KureOlustur()
        {
            Console.WriteLine("**Küre**");
            Console.Write("X değerini giriniz: ");
            int kX = TamSayiGiris();
            Console.Write("Y değerini giriniz: ");
            int kY = TamSayiGiris();
            Console.Write("Z değerini giriniz: ");
            int kZ = TamSayiGiris();
            Console.Write("Yarıçap değerini giriniz: ");
            int kYaricap = TamSayiGiris();
            return new Kure(kX, kY, kZ, kYaricap);
        }
        public static DikdortgenPrizma DikdortgenPrizmaOlustur()
        {
            Console.WriteLine("**Dikdörtgen Prizma**");
            Console.Write("X değerini giriniz: ");
            int dpX = TamSayiGiris();
            Console.Write("Y değerini giriniz: ");
            int dpY = TamSayiGiris();
            Console.Write("Z değerini giriniz: ");
            int dpZ = TamSayiGiris();
            Console.Write("En değerini giriniz: ");
            int dpEn = TamSayiGiris();
            Console.Write("Yükseklik değerini giriniz: ");
            int dpYukseklik = TamSayiGiris();
            Console.Write("Derinlik değerini giriniz: ");
            int dpDerinlik = TamSayiGiris();
            return new DikdortgenPrizma(dpX, dpY, dpZ, dpEn, dpYukseklik, dpDerinlik);
        }
        public static Silindir SilindirOlustur()
        {
            Console.WriteLine("**Silindir**");
            Console.Write("X değerini giriniz: ");
            int sX = TamSayiGiris();
            Console.Write("Y değerini giriniz: ");
            int sY = TamSayiGiris();
            Console.Write("Z değerini giriniz: ");
            int sZ = TamSayiGiris();
            Console.Write("Yarıçap değerini giriniz: ");
            int sYaricap = TamSayiGiris();
            Console.Write("Yükseklik değerini giriniz: ");
            int sYukseklik = TamSayiGiris();
            return new Silindir(sX, sY, sZ, sYaricap, sYukseklik);
        }
        public static Yuzey YuzeyOlustur()
        {
            Console.WriteLine("**Yüzey**");
            Console.Write("Noktanın bulunacağı sayıyı giriniz :");
            int sayi = TamSayiGiris();
            Console.WriteLine("Noktanın bulunacağı eksen giriniz('X'','Y','Z') :");
            string NoktaEksen = Console.ReadLine();
            return new Yuzey(sayi, NoktaEksen);
        }
    }
}

