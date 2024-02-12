using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Library
{
    public static class Utility
    {
       

        public static string EnglishUpperCase(string Str)
        {
            if (Str != null)
            {
                Str = Str.ToUpper().Replace("&", " ").Replace("/", " ").Replace("'", " ").Replace("(", " ").Replace(")", " ").Replace("%", " ").Replace("*", " ");

                Str = Str.Replace("Ü", "U").Replace("Ö", "O").Replace("Ç", "C").Replace("Ş", "S").Replace("İ", "I").Replace("Ğ", "G");
                Str = Str.Replace("ü", "U").Replace("ö", "O").Replace("ç", "C").Replace("ş", "S").Replace("i", "I").Replace("ğ", "G");
            }
            return Str;
        }


        public static string EnglishLowerCase(string Str)
        {

            Str = Str.ToUpper().Replace("&", " ").Replace("/", " ").Replace("'", " ").Replace("(", " ").Replace(")", " ").Replace("%", " ").Replace("*", " "); ;

            Str = Str.Replace("Ü", "U").Replace("Ö", "O").Replace("Ç", "C").Replace("Ş", "S").Replace("İ", "I").Replace("Ğ", "G");
            Str = Str.Replace("ü", "U").Replace("ö", "O").Replace("ç", "C").Replace("ş", "S").Replace("i", "I").Replace("ğ", "G");
            Str = Str.Replace("U", "u").Replace("O", "o").Replace("C", "c").Replace("S", "s").Replace("I", "i").Replace("Ğ", "g");

            return Str;
        }

        public static string TurkishtoEnglish(string Str)
        {

            Str = Str.Replace("&", " ").Replace("'", " ").Replace("<", " ").Replace(">", " ");

            Str = Str.Replace("Ü", "U");
            Str = Str.Replace("Ö", "O");
            Str = Str.Replace("Ç", "C");
            Str = Str.Replace("Ş", "C");
            Str = Str.Replace("İ", "I");
            Str = Str.Replace("Ğ", "G");

            Str = Str.Replace("ü", "u");
            Str = Str.Replace("ö", "o");
            Str = Str.Replace("ç", "c");
            Str = Str.Replace("ş", "s");
            Str = Str.Replace("ğ", "g");
            Str = Str.Replace("U", "u");

            return Str;
        }


        public static string GsmPrefixControl(string Gsm)
        {
            string _Gsm = "";
            if (Gsm != "")
            {
                Gsm = Gsm.Replace(" ", "").Replace("+", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace("/", "");
                if (Gsm.Length == 10)
                    _Gsm = "90" + Gsm;
                else if (Gsm.Length == 11)
                    _Gsm = "9" + Gsm;
                else
                    _Gsm = Gsm;
            }

            return _Gsm;
        }

        public static String GetLanIPAddress()
        {
            //The X-Forwarded-For (XFF) HTTP header field is a de facto standard for identifying the originating IP address of a 
            //client connecting to a web server through an HTTP proxy or load balancer
            String ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ip))
            {
                ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            return ip;
        }

        public static string StringToFileName(string fname)
        {
            return fname.ToLower().Replace(" ", "_").Replace("ş", "s").Replace("ö", "o").Replace("ü", "u").Replace("ğ", "g");
        }
        public static int MonthDifference(this DateTime lValue, DateTime rValue)
        {
            return (lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year);
        }

        public static decimal AgeCalculate(DateTime StartDate, DateTime BirthDate)
        {
            TimeSpan fark;
            fark = StartDate.Subtract(BirthDate);
            return Convert.ToDecimal(fark.TotalDays) / 365;


        }


         
        public static int GetDifferenceInYearsAndDays(DateTime birth, DateTime today)
        {
            if (birth > today)
                throw new InvalidOperationException();

            var thisYearBirthday = new DateTime(today.Year, birth.Month, birth.Day);
            var lastBirthday =
                thisYearBirthday <= today ? thisYearBirthday : thisYearBirthday.AddYears(-1);

            int years = lastBirthday.Year - birth.Year;
            int days = (today - lastBirthday).Days;

            return years;
        }

        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        public static string NumberToText(decimal tNumber)
        {

            string sTutar = tNumber.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için             
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı 
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BİR", "İKİ", "Üç", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir. 

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.) 
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız. 

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.             

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor. 
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                 

                if (grupDegeri == "BİRYÜZ") //biryüz düzeltiliyor. 
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar 

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                 

                if (grupDegeri != "") //binler 
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN") //birbin düzeltiliyor. 
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar 
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler 
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "SIFIR Kr.";

            return yazi;
        }


         


    }
}
