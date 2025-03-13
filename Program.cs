using System;

public class KodeProduk {
    public static String getKodeProduk(String produk) {
        String[] Prod = { "laptop", "smartphone", "tablet", "headset", "keyboard", "mouse", "printer", "monitor", "smartwatch", "kamera" };
        String[] kodPro = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

        int max = Prod.Length - 1;

        String hasilPen = "kosong";
        int index = 0;

        while (hasilPen == "kosong" && index < max) {
            if (produk == Prod[index]) { 
                hasilPen = kodPro[index];
            }
           index++;
        }
        return hasilPen;
    }
}

public class Program {
    public static void Main() {
        Console.WriteLine("masukkan nama produk");
        String penc = Console.ReadLine();

        String output = KodeProduk.getKodeProduk(penc);
        Console.WriteLine("Kode Produk: " + output);
    }
}