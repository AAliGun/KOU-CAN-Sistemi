using System;

namespace KOUCan
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Kullanıcıdan Öğrenci Sayısını Girip Dizi Oluşturuyoruz.
            int OgrenciSayisi;
            string OgrenciSayisiSTR ,NotSTR;
            Console.Write("Öğrenci Sayısını giriniz : ");
            OgrenciSayisiSTR = Console.ReadLine();
            OgrenciSayisi = Convert.ToInt32(OgrenciSayisiSTR);
            int[] Notlar = new int[OgrenciSayisi];
            Double[] Tnotu = new Double[OgrenciSayisi];

            // Kullanıcıdan Öğrenci Notlarını Girmesini İstiyoruz.
            Random rastgele = new Random();
            for (int a = 0; a < OgrenciSayisi; a++)
            {
                Console.Write(a + 1 + ". Öğrenci notu : ");
                NotSTR = Console.ReadLine();
                //Notlar[a] = rastgele.Next(100);
                Notlar[a] = Convert.ToInt32(NotSTR);
                

            }

            //Girilen Notlardan 15'ten Büyük Olanların Ortalama Değşikenine Ekleyip Sayac Değişkeni İle Bunları Sayıyoruz.
            Double Ortalama = 0;
            int Sayac = 0;
            for (int b = 0; b < OgrenciSayisi; b++)
            {
                if (Notlar[b] > 15)
                {
                    Ortalama = Ortalama + Notlar[b];
                    Sayac++;
                }
            }
            // Toplanan Değişkenleri Sayaca Bölüp Ekrana Yazdırıyoruz.
            Ortalama = Ortalama / Sayac;
            Console.WriteLine("Sınıfta 15 üstü not alanlar : " + Sayac + "\nSınıfın Ortalaması : " + Ortalama);

            //Sınıf Ortalaması 80 Üstünde İse Tablo-1'e Göre Çıktı veriyoruz.
            string harfnotu;
            int AA = 90, BA = 80, BB = 75, CB = 70, CC = 60, DC = 50, DD = 40, FD = 30;
            // Hangi Harf Notundan Kaç Tane Olduğunu Saymak İçin DEğişken Tanımlıyoruz.
            int AAS = 0, BAS = 0, BBS = 0, CBS = 0, CCS = 0, DCS = 0, DDS = 0, FDS = 0, FFS = 0;
            if (Ortalama > 80)
            {
                for (int c = 0; c < Sayac; c++)
                {
                    
                    if (Notlar[c] >= AA)
                    {
                        harfnotu = "AA";
                        AAS++;
                    }
                    else if (Notlar[c] >= BA)
                    {
                        harfnotu = "BA";
                        BAS++;
                    }
                    else if (Notlar[c] >= BB)
                    {
                        harfnotu = "BB";
                        BBS++;
                    }
                    else if (Notlar[c] >= CB)
                    {
                        harfnotu = "CB";
                        CBS++;
                    }
                    else if (Notlar[c] >= CC)
                    {
                        harfnotu = "CC";
                        CCS++;
                    }
                    else if (Notlar[c] >= DC)
                    {
                        harfnotu = "DC";
                        DCS++;
                    }
                    else if (Notlar[c] >= DD)
                    {
                        harfnotu = "DD";
                        DDS++;
                    }
                    else if (Notlar[c] >= FD)
                    {
                        harfnotu = "FD";
                        FDS++;
                    }
                    else
                    {
                        harfnotu = "FF";
                        FFS++;
                    }
                    Console.WriteLine(c + ". Öğrenci notu" + Notlar[c] + "Harf Notu" + harfnotu);
                    Console.WriteLine("AA : " + AA + " " + "BA : " + BA + " " + "BB : " + BB + " " + "CB : " + CB + " " + "CC : " + CC + " " + "DC : " + DC + " " + "DD : " + DD + " " + "FD : " + FD + " ");
                    Console.WriteLine("AAS : " + AAS + " " + "BAS : " + BAS + " " + "BBS : " + BBS + " " + "CBS : " + CB + " " + "CCS : " + CCS + " " + "DCS : " + DCS + " " + "DDS : " + DDS + " " + "FDS : " + FDS + " " + "FFS : " + FFS + " ");

                }
            }

            else
            {
                // Sınıfın Standart Sapmasını Buluyoruz.
                Double fark, karesi, karetop = 0, karekok;
                for (int d = 0; d < OgrenciSayisi; d++)
                {
                    if (Notlar[d] > 15)
                    {
                        fark = Ortalama - Notlar[d];
                        karesi = fark * fark;
                        karetop = karetop + karesi;  
                    }
                }
                karetop = karetop / (OgrenciSayisi - 1);
                karekok = Math.Sqrt(karetop);
                // Sınıfın Standart Sapmasını Kontrol için Yazdırıyoruz.
                Console.WriteLine("Sınıfın Standart Sapması : " + karekok);

                // Sınıf Ortalamasına Göre Tnotundaki Harfnotlarının Alt Sınıflarını Değişkene Atıyoruz.
                if (Ortalama > 70)
                {
                    AA = 59;
                    BA = 54;
                    BB = 49;
                    CB = 44;
                    CC = 39;
                    DC = 34;
                    DD = 29;
                    FD = 24;
                }
                else if (Ortalama > 62.5)
                {
                    AA = 61;
                    BA = 56;
                    BB = 51;
                    CB = 46;
                    CC = 41;
                    DC = 36;
                    DD = 31;
                    FD = 26;
                }
                else if (Ortalama > 57.5)
                {
                    AA = 61 + 2;
                    BA = 56 + 2;
                    BB = 51 + 2;
                    CB = 46 + 2;
                    CC = 41 + 2;
                    DC = 36 + 2;
                    DD = 31 + 2;
                    FD = 26 + 2;
                }
                else if (Ortalama > 52.5)
                {
                    AA = 61 + 4;
                    BA = 56 + 4;
                    BB = 51 + 4;
                    CB = 46 + 4;
                    CC = 41 + 4;
                    DC = 36 + 4;
                    DD = 31 + 4;
                    FD = 26 + 4;
                }
                else if (Ortalama > 47.5)
                {
                    AA = 61 + 6;
                    BA = 56 + 6;
                    BB = 51 + 6;
                    CB = 46 + 6;
                    CC = 41 + 6;
                    DC = 36 + 6;
                    DD = 31 + 6;
                    FD = 26 + 6;
                }
                else if (Ortalama > 42.5)
                {
                    AA = 61 + 8;
                    BA = 56 + 8;
                    BB = 51 + 8;
                    CB = 46 + 8;
                    CC = 41 + 8;
                    DC = 36 + 8;
                    DD = 31 + 8;
                    FD = 26 + 8;
                }
                else
                {
                    AA = 61 + 10;
                    BA = 56 + 10;
                    BB = 51 + 10;
                    CB = 46 + 10;
                    CC = 41 + 10;
                    DC = 36 + 10;
                    DD = 31 + 10;
                    FD = 26 + 10;
                }
                for (int e = 0; e < OgrenciSayisi; e++)
                {
                    Tnotu[e] = ((Notlar[e] - Ortalama) / karekok) * 10 + 50;
                    if (Tnotu[e] >= AA)
                    {
                        harfnotu = "AA";
                        AAS++;
                    }
                    else if (Tnotu[e] >= BA)
                    {
                        harfnotu = "BA";
                        BAS++;
                    }
                    else if (Tnotu[e] >= BB)
                    {
                        harfnotu = "BB";
                        BBS++;
                    }
                    else if (Tnotu[e] >= CB)
                    {
                        harfnotu = "CB";
                        CBS++;
                    }
                    else if (Tnotu[e] >= CC)
                    {
                        harfnotu = "CC";
                        CCS++;
                    }
                    else if (Tnotu[e] >= DC)
                    {
                        harfnotu = "DC";
                        DCS++;
                    }
                    else if (Tnotu[e] >= DD)
                    {
                        harfnotu = "DD";
                        DDS++;
                    }
                    else if (Tnotu[e] >= FD)
                    {
                        harfnotu = "FD";
                        FDS++;
                    }
                    else
                    {
                        harfnotu = "FF";
                        FFS++;
                    }
                    Console.WriteLine(e + ". Öğrenci notu : " + Notlar[e] + " Öğrenci Tnotu : " + Tnotu[e] + " Harf Notu : " + harfnotu);
                }
                
                Console.WriteLine("Tnot olarak AA : " + AA + " " + "BA : " + BA + " " + "BB : " + BB + " " + "CB : " + CB + " " + "CC : " + CC + " " + "DC : " + DC + " " + "DD : " + DD + " " + "FD : " + FD + " ");
                Console.WriteLine("AAS : " + AAS + " " + "BAS : " + BAS + " " + "BBS : " + BBS + " " + "CBS : " + CB + " " + "CCS : " + CCS + " " + "DCS : " + DCS + " " + "DDS : " + DDS + " " + "FDS : " + FDS + " " + "FFS : " + FFS + " ");
            }
        }

       
        
    }
}
