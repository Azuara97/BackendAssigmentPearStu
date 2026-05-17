//variables
enum Symbols { sym1, sym2, sym3, sym4, sym5, sym6, sym7, sym8 }

class Program
{
    //bands
    static string[] band1 = new string[] { Symbols.sym2.ToString(),Symbols.sym7.ToString(),
                                    Symbols.sym7.ToString(), Symbols.sym1.ToString(),
                                    Symbols.sym1.ToString(), Symbols.sym5.ToString(),
                                    Symbols.sym1.ToString(), Symbols.sym4.ToString(),
                                    Symbols.sym5.ToString(), Symbols.sym3.ToString(),
                                    Symbols.sym2.ToString(), Symbols.sym3.ToString(),
                                    Symbols.sym8.ToString(), Symbols.sym4.ToString(),
                                    Symbols.sym5.ToString(), Symbols.sym2.ToString(),
                                    Symbols.sym8.ToString(), Symbols.sym5.ToString(),
                                    Symbols.sym7.ToString(), Symbols.sym2.ToString() };
    static string[] band2 = new string[] { Symbols.sym1.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym7.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym5.ToString(), Symbols.sym5.ToString(),
                                           Symbols.sym8.ToString(), Symbols.sym5.ToString(),
                                           Symbols.sym5.ToString(), Symbols.sym4.ToString(),
                                           Symbols.sym7.ToString(), Symbols.sym2.ToString(),
                                           Symbols.sym5.ToString(), Symbols.sym7.ToString(),
                                           Symbols.sym1.ToString(), Symbols.sym5.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym8.ToString(),
                                           Symbols.sym7.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym3.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym7.ToString(),
                                           Symbols.sym3.ToString() };
    static string[] band3 = new string[] { Symbols.sym5.ToString(), Symbols.sym2.ToString(),
                                           Symbols.sym7.ToString(), Symbols.sym8.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym2.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym2.ToString(),
                                           Symbols.sym2.ToString(), Symbols.sym5.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym5.ToString(),
                                           Symbols.sym1.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym2.ToString(),
                                           Symbols.sym4.ToString(), Symbols.sym1.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym8.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym3.ToString(),
                                           Symbols.sym4.ToString(), Symbols.sym4.ToString(),
                                           Symbols.sym8.ToString(), Symbols.sym1.ToString(),
                                           Symbols.sym7.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym1.ToString(), Symbols.sym6.ToString() };
    static string[] band4 = new string[] { Symbols.sym2.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym8.ToString(), Symbols.sym8.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym8.ToString(), Symbols.sym1.ToString(),
                                           Symbols.sym5.ToString(), Symbols.sym1.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym3.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym7.ToString(),
                                           Symbols.sym2.ToString(), Symbols.sym5.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym8.ToString(), Symbols.sym4.ToString(),
                                           Symbols.sym1.ToString(), Symbols.sym5.ToString(),
                                           Symbols.sym7.ToString() };
    static string[] band5 = new string[] { Symbols.sym7.ToString(), Symbols.sym8.ToString(),
                                           Symbols.sym2.ToString(), Symbols.sym3.ToString(),
                                           Symbols.sym4.ToString(), Symbols.sym1.ToString(),
                                           Symbols.sym3.ToString(), Symbols.sym2.ToString(),
                                           Symbols.sym2.ToString(), Symbols.sym4.ToString(),
                                           Symbols.sym4.ToString(), Symbols.sym2.ToString(),
                                           Symbols.sym6.ToString(), Symbols.sym4.ToString(),
                                           Symbols.sym1.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym1.ToString(), Symbols.sym6.ToString(),
                                           Symbols.sym4.ToString(), Symbols.sym8.ToString() };
    
    //symbols
    static string symbSelected1 = "", symbSelected1Bottom1 = "", symbSelected1Bottom2 = "";
    static string symbSelected2 = "", symbSelected2Bottom1 = "", symbSelected2Bottom2 = "";
    static string symbSelected3 = "", symbSelected3Bottom1 = "", symbSelected3Bottom2 = "";
    static string symbSelected4 = "", symbSelected4Bottom1 = "", symbSelected4Bottom2 = "";
    static string symbSelected5 = "", symbSelected5Bottom1 = "", symbSelected5Bottom2 = "";

    static int getRandomIndex(string[] band)
    {
        Random random = new Random();
        return random.Next(0, band.Length);
    }

    static void Main(string[] args)
    {
        int index1 = getRandomIndex(band1);
        int index2 = getRandomIndex(band2);
        int index3 = getRandomIndex(band3);
        int index4 = getRandomIndex(band4);
        int index5 = getRandomIndex(band5);

        symbSelected1 = band1[index1];
        symbSelected1Bottom1 = band1[(index1 + 1) % band1.Length];
        symbSelected1Bottom2 = band1[(index1 + 2) % band1.Length];

        symbSelected2 = band2[index2];
        symbSelected2Bottom1 = band2[(index2 + 1) % band2.Length];
        symbSelected2Bottom2 = band2[(index2 + 2) % band2.Length];

        symbSelected3 = band3[index3];
        symbSelected3Bottom1 = band3[(index3 + 1) % band3.Length];
        symbSelected3Bottom2 = band3[(index3 + 2) % band3.Length];

        symbSelected4 = band4[index4];
        symbSelected4Bottom1 = band4[(index4 + 1) % band4.Length];
        symbSelected4Bottom2 = band4[(index4 + 2) % band4.Length];

        symbSelected5 = band5[index5];
        symbSelected5Bottom1 = band5[(index5 + 1) % band5.Length];
        symbSelected5Bottom2 = band5[(index5 + 2) % band5.Length];

        Console.WriteLine("Stop Positions: " + index1 + ", " + index2 + ", " + index3 + ", " + index4 + ", " + index5);
        Console.WriteLine(symbSelected1 + " " + symbSelected2 + " " + symbSelected3 + " " + symbSelected4 + " " + symbSelected5);
        Console.WriteLine(symbSelected1Bottom1 + " " + symbSelected2Bottom1 + " " + symbSelected3Bottom1 + " " + symbSelected4Bottom1 + " " + symbSelected5Bottom1);
        Console.WriteLine(symbSelected1Bottom2 + " " + symbSelected2Bottom2 + " " + symbSelected3Bottom2 + " " + symbSelected4Bottom2 + " " + symbSelected5Bottom2);
    }
}