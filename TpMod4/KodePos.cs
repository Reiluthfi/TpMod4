using System;
using System.Collections.Generic;

class KodePos
{
    private static readonly Dictionary<string, string> kodePosMap = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"A. Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    // Fungsi untuk mencari kode pos berdasarkan kelurahan
    string GetKodePos(string kelurahan)
    {
        for (int i = 0; i < kodePosArray.GetLength(0); i++)
        {
            if (kodePosArray[i, 0] == kelurahan)
    {
                return kodePosArray[i, 1];
            }
        }
        return "Kode pos tidak ditemukan";
    }
}