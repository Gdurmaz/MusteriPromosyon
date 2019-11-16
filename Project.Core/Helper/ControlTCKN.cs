using System;

namespace Project.Core.Helper
{
    public class ControlTCKN
    {
        public static int ControlIdendity(string _tckn)
        {
            int sumofCouples = 0, sumofSingles = 0,sumofAll=0;
            if (Convert.ToInt32(_tckn.Substring(0,1))!=0)
            {
                if (_tckn.Length==11)
                {
                    int[] result = new int[11];
                    for (int i = 0; i < _tckn.Length; i++)
                    {
                        result[i] = Convert.ToInt32(_tckn.Substring(i, 1));
                    }
                    //Kural: 2. 4. 6. ve 8. hanelerin toplamı
                    sumofCouples =result[2] + result[4] + result[6] + result[8];
                    // Kural: 1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından,
                    sumofSingles = (result[1] + result[3] + result[5] + result[7] + result[9])*7;
                    if ((sumofSingles-sumofCouples)%10==result[9])
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            sumofAll += result[i];
                        }
                        if (sumofAll%10==result[10])
                        {
                            return Convert.ToInt32(TCKNError.GecerliTCKN);
                        }
                        else
                        {
                            return Convert.ToInt32(TCKNError.GecersizTCKN);
                        }
                    }
                    else
                    {
                        return Convert.ToInt32(TCKNError.GecersizTCKN);
                    }
                }
                else
                {
                    return Convert.ToInt32(TCKNError.EksikHane);
                }
            }
            else
            {
                return Convert.ToInt32(TCKNError.IlkIndexSifirOlamaz);
            }
        }
        public enum TCKNError
        {
            IlkIndexSifirOlamaz=1,
            GecersizTCKN=2,
            EksikHane=3,
            GecerliTCKN=4
        }
        public static string MesageErrorCode(int code)
        {
            if (Convert.ToInt32(TCKNError.IlkIndexSifirOlamaz)==code)
            {
                return "Girilen değerin ilk indeksi sıfır olamaz";
            }
            else if (Convert.ToInt32(TCKNError.EksikHane) == code)
            {
                return "Girilen değer 11 hane olmak zorundadır";
            }
            else if (Convert.ToInt32(TCKNError.GecerliTCKN) == code)
            {
                return "TCKN Doğrudur";
            }
            else if(Convert.ToInt32(TCKNError.GecersizTCKN) == code)
            {
                return "TCKN Yanlıştır";
            }
            else
            {
                return "Sistemsel Hata";
            }
        }
    }
}
