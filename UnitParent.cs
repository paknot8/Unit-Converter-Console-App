namespace UnitConverter
{
    class UnitParent
    {
        // These variables can be used in any class aslong it is derived from UnitParent
        public static string? input; // It's nullable (string?)
        public static double inputNumber;
        public static double result;

        // This method only asks for the inputnumber you want to convert
        public static void InputNumber()
        {
            Console.WriteLine("What is the number you want to convert?");
            string? stringInputNumber = Console.ReadLine();

            // Check if the input is a number? if not exit.
            if (!double.TryParse(stringInputNumber, out double number))
            {
                Console.WriteLine("This is incorrect. Please enter a valid number.");
                ExitConsoleApp();
            }
            inputNumber = Convert.ToDouble(stringInputNumber);
        }

        // Exit the console app
        public static void ExitConsoleApp() => Environment.Exit(0);

        public static void GoBackToMainMenu()
        {
            Console.WriteLine("\n" + "---> Going Back to Main Menu..." + "\n");
            Program.Main();
        }
    }    
}