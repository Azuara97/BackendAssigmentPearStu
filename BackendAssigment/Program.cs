using BackendAssigment;

class Program
{
    static SlotMachine? slotMachine;

    static void Main(string[] args)
    {
        slotMachine = new SlotMachine();

        while (true)
        {
            Console.WriteLine("Press Enter to spin the slot machine or type 'exit' to quit:");
            string input = Console.ReadLine();

            if (input?.ToLower() == "exit")
                break;
            
            slotMachine.SpinGrid();
            slotMachine.CalculateWin();
        }
    }
}