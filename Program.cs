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


public class FanLaptop {
    enum State { quiet, balance, performance, turbo };

    public static void Modefan() { 
        State state = State.quiet;
        String[] display = { "quite", "balance", "performance", "turbo" };
        while (state != null) {
            Console.WriteLine("fan mode berubah menjadi " + display[(int)state]);
            Console.WriteLine("masukkan mode fan: ");

            String command = Console.ReadLine();
            switch (state) { 
                case State.quiet:
                    if (command == "balance")
                    {
                        state = State.balance;
                    }
                    else if (command == "performance")
                    {
                        state = State.performance;
                    }
                    else if (command == "turbo") { 
                        state = State.turbo;
                    }

                    break;

                case State.balance:
                    if (command == "quite")
                    {
                        state = State.quiet;
                    }
                    else if (command == "performance")
                    {
                        state = State.performance;
                    }
                    else if (command == "turbo") {
                        state = State.turbo;
                    }
                    break;

                case State.performance:
                    if (command == "quite")
                    {
                        state = State.quiet;
                    }
                    else if (command == "balance")
                    {
                        state = State.balance;
                    }
                    else if (command == "turbo") {
                        state = State.turbo;
                    }
                    break;

                case State.turbo:
                    if (command == "quite")
                    {
                        state = State.quiet;
                    }
                    else if (command == "balance")
                    {
                        state = State.balance;
                    }
                    else if (command == "performance") {
                        state = State.performance;
                    }
                    break;
                    
            }
        }

        Console.WriteLine("keluar program");
    }   
}


public class Program {
    public static void Main() {

        Console.WriteLine("kode program: ");
        Console.WriteLine("1. program pencarian barang");
        Console.WriteLine("2. program fan mode");
        Console.WriteLine("masukkan pilihan program: ");
        String input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("masukkan nama produk");
            String penc = Console.ReadLine();

            String output = KodeProduk.getKodeProduk(penc);
            Console.WriteLine("Kode Produk: " + output);
        }
        else if (input == "2")
        {
            FanLaptop.Modefan();
        }
    }
}