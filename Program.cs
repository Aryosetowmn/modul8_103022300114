using System.Diagnostics.SymbolStore;
using modul8_103022300114;

class Program 
{
    public static void Main(String[] args) {
        BankTransferConfig config = new BankTransferConfig();
        BankTransferConfig test = config.ReadConfigFile();

        //poin1
        if (test.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
        }
        else if (test.lang == "id")
        {
            Console.WriteLine("Silahkan masukkan jumlah uang yang akan ditransfer:");
        }

        //poin2
        int money = Convert.ToInt32(Console.ReadLine());    
        if (money <= test.transfer.threshold)
        {
            Console.WriteLine("Please select the transfer method:");
            for (int i = 0; i < test.methods.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {test.methods[i]}");
            }
            int method = Convert.ToInt32(Console.ReadLine());
            if (method == 1)
            {
                Console.WriteLine($"The transfer fee is {test.transfer.low_fee}");
            }
            else if (method == 2)
            {
                Console.WriteLine($"The transfer fee is {test.transfer.high_fee}");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }

        //poin3


    }
}