namespace latihan3_aritmatika.Operator;

public class Perbandingan
{ 
    public static void Bandingkan()
    {
        int nilai = 80;
        bool lulus = nilai >= 75;
        bool lulus2 = nilai > 80;
        bool lulus3 = nilai <= 60;
        bool lulus4 = nilai < 81;
        bool equal = nilai == 80;
        bool notEqual = "budi" != "budi";

        Console.WriteLine($"Selamat kamu nilainya {lulus}");
        Console.WriteLine($"Kurang dari sama dengan : {lulus2}");
        Console.WriteLine($"Kurang dari sama dengan : {lulus3}");
        Console.WriteLine($"Kurang dari sama dengan : {lulus4}");
        Console.WriteLine($"Equal : {equal}");
        Console.WriteLine($"Not Equal : {notEqual}");
    }
}
