//variables
enum Symbols { sym1, sym2, sym3, sym4, sym5, sym6, sym7, sym8 }

class Program
{
    //bands
    static int[] band1 = new int[] { (int)Symbols.sym2, (int)Symbols.sym7,
                                     (int)Symbols.sym7, (int)Symbols.sym1,
                                     (int)Symbols.sym1, (int)Symbols.sym5,
                                     (int)Symbols.sym1, (int)Symbols.sym4,
                                     (int)Symbols.sym5, (int)Symbols.sym3,
                                     (int)Symbols.sym2, (int)Symbols.sym3,
                                     (int)Symbols.sym8, (int)Symbols.sym4,
                                     (int)Symbols.sym5, (int)Symbols.sym2,
                                     (int)Symbols.sym8, (int)Symbols.sym5,
                                     (int)Symbols.sym7, (int)Symbols.sym2 };
    static int[] band2 = new int[] { (int)Symbols.sym1, (int)Symbols.sym6,
                                     (int)Symbols.sym7, (int)Symbols.sym6,
                                     (int)Symbols.sym5, (int)Symbols.sym5,
                                     (int)Symbols.sym8, (int)Symbols.sym5,
                                     (int)Symbols.sym5, (int)Symbols.sym4,
                                     (int)Symbols.sym7, (int)Symbols.sym2,
                                     (int)Symbols.sym5, (int)Symbols.sym7,
                                     (int)Symbols.sym1, (int)Symbols.sym5,
                                     (int)Symbols.sym6, (int)Symbols.sym8,
                                     (int)Symbols.sym7, (int)Symbols.sym6,
                                     (int)Symbols.sym3, (int)Symbols.sym3,
                                     (int)Symbols.sym6, (int)Symbols.sym7,
                                     (int)Symbols.sym3 };
    static int[] band3 = new int[] { (int)Symbols.sym5, (int)Symbols.sym2,
                                     (int)Symbols.sym7, (int)Symbols.sym8,
                                     (int)Symbols.sym3, (int)Symbols.sym2,
                                     (int)Symbols.sym6, (int)Symbols.sym2,
                                     (int)Symbols.sym2, (int)Symbols.sym5,
                                     (int)Symbols.sym3, (int)Symbols.sym5,
                                     (int)Symbols.sym1, (int)Symbols.sym6,
                                     (int)Symbols.sym3, (int)Symbols.sym2,
                                     (int)Symbols.sym4, (int)Symbols.sym1,
                                     (int)Symbols.sym6, (int)Symbols.sym8,
                                     (int)Symbols.sym6, (int)Symbols.sym3,
                                     (int)Symbols.sym4, (int)Symbols.sym4,
                                     (int)Symbols.sym8, (int)Symbols.sym1,
                                     (int)Symbols.sym7, (int)Symbols.sym6,
                                     (int)Symbols.sym1, (int)Symbols.sym6 };
    static int[] band4 = new int[] { (int)Symbols.sym2, (int)Symbols.sym6,
                                     (int)Symbols.sym3, (int)Symbols.sym6,
                                     (int)Symbols.sym8, (int)Symbols.sym8,
                                     (int)Symbols.sym3, (int)Symbols.sym6,
                                     (int)Symbols.sym8, (int)Symbols.sym1,
                                     (int)Symbols.sym5, (int)Symbols.sym1,
                                     (int)Symbols.sym6, (int)Symbols.sym3,
                                     (int)Symbols.sym6, (int)Symbols.sym7,
                                     (int)Symbols.sym2, (int)Symbols.sym5,
                                     (int)Symbols.sym3, (int)Symbols.sym6,
                                     (int)Symbols.sym8, (int)Symbols.sym4,
                                     (int)Symbols.sym1, (int)Symbols.sym5,
                                     (int)Symbols.sym7 };
    static int[] band5 = new int[] { (int)Symbols.sym7, (int)Symbols.sym8,
                                     (int)Symbols.sym2, (int)Symbols.sym3,
                                     (int)Symbols.sym4, (int)Symbols.sym1,
                                     (int)Symbols.sym3, (int)Symbols.sym2,
                                     (int)Symbols.sym2, (int)Symbols.sym4,
                                     (int)Symbols.sym4, (int)Symbols.sym2,
                                     (int)Symbols.sym6, (int)Symbols.sym4,
                                     (int)Symbols.sym1, (int)Symbols.sym6,
                                     (int)Symbols.sym1, (int)Symbols.sym6,
                                     (int)Symbols.sym4, (int)Symbols.sym8 };
    
    //symbols
    static string symbSelected1 = "", symbSelected1Bottom1 = "", symbSelected1Bottom2 = "";
    static string symbSelected2 = "", symbSelected2Bottom1 = "", symbSelected2Bottom2 = "";
    static string symbSelected3 = "", symbSelected3Bottom1 = "", symbSelected3Bottom2 = "";
    static string symbSelected4 = "", symbSelected4Bottom1 = "", symbSelected4Bottom2 = "";
    static string symbSelected5 = "", symbSelected5Bottom1 = "", symbSelected5Bottom2 = "";

    static int colNumber = 5;
    static int rowNumber = 3;
    static int[,] symbGrid = new int[rowNumber, colNumber];
    static Dictionary<Symbols, int[]> payTable = new Dictionary<Symbols, int[]>()
    {
        { Symbols.sym1, new int[]{0,0,1,2,3} },
        { Symbols.sym2, new int[]{0,0,1,2,3} },
        { Symbols.sym3, new int[]{0,0,1,2,5} },
        { Symbols.sym4, new int[]{0,0,2,5,10} },
        { Symbols.sym5, new int[]{0,0,5,10,15} },
        { Symbols.sym6, new int[]{0,0,5,10,15} },
        { Symbols.sym7, new int[]{0,0,5,10,20} },
        { Symbols.sym8, new int[]{0,0,10,20,50} }
    };

    static int getRandomIndex(int[] band)
    {
        Random random = new Random();
        return random.Next(0, band.Length);
    }

    static List<List<int>> FindCombinations(List<List<int>> sequences)
    {
        List<List<int>> results = new List<List<int>>();

            void Recurse(int index, List<int> currentComb)
            {
                //Check full combination
                if (index == sequences.Count)
                {
                    results.Add(new List<int>(currentComb));
                    return;
                }

                foreach (int item in sequences[index])
                {
                    currentComb.Add(item);
                    Recurse(index + 1, currentComb);
                    currentComb.RemoveAt(currentComb.Count - 1);
                }
            }

            Recurse(0, new List<int>());
        return results;
    }

    static void Main(string[] args)
    {
        int index1 = getRandomIndex(band1);
        int index2 = getRandomIndex(band2);
        int index3 = getRandomIndex(band3);
        int index4 = getRandomIndex(band4);
        int index5 = getRandomIndex(band5);

        symbGrid[0, 0] = band1[index1];
        symbGrid[0, 1] = band2[index2];
        symbGrid[0, 2] = band3[index3];
        symbGrid[0, 3] = band4[index4];
        symbGrid[0, 4] = band5[index5];

        symbGrid[1, 0] = band1[(index1 + 1) % band1.Length];
        symbGrid[1, 1] = band2[(index2 + 1) % band2.Length];
        symbGrid[1, 2] = band3[(index3 + 1) % band3.Length];
        symbGrid[1, 3] = band4[(index4 + 1) % band4.Length];
        symbGrid[1, 4] = band5[(index5 + 1) % band5.Length];

        symbGrid[2, 0] = band1[(index1 + 2) % band1.Length];
        symbGrid[2, 1] = band2[(index2 + 2) % band2.Length];
        symbGrid[2, 2] = band3[(index3 + 2) % band3.Length];
        symbGrid[2, 3] = band4[(index4 + 2) % band4.Length];
        symbGrid[2, 4] = band5[(index5 + 2) % band5.Length];

        symbSelected1 = ((Symbols)symbGrid[0, 0]).ToString();
        symbSelected1Bottom1 = ((Symbols)symbGrid[1, 0]).ToString();
        symbSelected1Bottom2 = ((Symbols)symbGrid[2, 0]).ToString();

        symbSelected2 = ((Symbols)symbGrid[0, 1]).ToString();
        symbSelected2Bottom1 = ((Symbols)symbGrid[1, 1]).ToString();
        symbSelected2Bottom2 = ((Symbols)symbGrid[2, 1]).ToString();

        symbSelected3 = ((Symbols)symbGrid[0, 2]).ToString();
        symbSelected3Bottom1 = ((Symbols)symbGrid[1, 2]).ToString();
        symbSelected3Bottom2 = ((Symbols)symbGrid[2, 2]).ToString();


        symbSelected4 = ((Symbols)symbGrid[0, 3]).ToString();
        symbSelected4Bottom1 = ((Symbols)symbGrid[1, 3]).ToString();
        symbSelected4Bottom2 = ((Symbols)symbGrid[2, 3]).ToString();

        symbSelected5 = ((Symbols)symbGrid[0, 4]).ToString();
        symbSelected5Bottom1 = ((Symbols)symbGrid[1, 4]).ToString();
        symbSelected5Bottom2 = ((Symbols)symbGrid[2, 4]).ToString();

        Console.WriteLine($"Stop Positions: {index1}, {index2}, {index3}, {index4}, {index5}");
        Console.WriteLine($"{symbSelected1} {symbSelected2} {symbSelected3} {symbSelected4} {symbSelected5}");
        Console.WriteLine($"{symbSelected1Bottom1} {symbSelected2Bottom1} {symbSelected3Bottom1} {symbSelected4Bottom1} {symbSelected5Bottom1}");
        Console.WriteLine($"{symbSelected1Bottom2} {symbSelected2Bottom2} {symbSelected3Bottom2} {symbSelected4Bottom2} {symbSelected5Bottom2}");

        int totalWin = 0;
        List<string> winDetails = new List<string>();

        for (int row = 0; row < rowNumber; row++)
        {
            int symbolId = symbGrid[row, 0];
            Symbols sym = (Symbols)symbolId;

            //Store matching rows per column
            List<List<int>> waysPositions = new List<List<int>>();
            waysPositions.Add(new List<int> { row });

            int consecutiveCols = 1;

            for (int col = 1; col < colNumber; col++)
            {
                List<int> matchingRows = new List<int>();
                for (int r = 0; r < rowNumber; r++)
                {
                    if (symbGrid[r, col] == symbolId)
                        matchingRows.Add(r);
                }

                if (matchingRows.Count == 0)
                    break;

                waysPositions.Add(matchingRows);
                consecutiveCols++;
            }

            if (consecutiveCols >= 3)
            {
                int payout = payTable[sym][consecutiveCols];

                List<List<int>> allCombinations = FindCombinations(waysPositions);

                foreach (List<int> combo in allCombinations)
                {
                    List<int> positions = new List<int>();
                    for (int c = 0; c < combo.Count; c++)
                    {
                        positions.Add(combo[c] * colNumber + c);
                    }

                    winDetails.Add($"- Ways win {string.Join("-", positions)}, {sym} x {consecutiveCols}, {payout}");
                    totalWin += payout;
                }
            }
        }

        Console.WriteLine("Total wins: " + totalWin);
        foreach (string w in winDetails)
            Console.WriteLine(w);
    }
}