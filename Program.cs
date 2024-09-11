namespace UnitConverter
{
    public class Program
    {
        public static void Main()
        {
            ShowStartingMenu();
        }

        private static void ShowStartingMenu()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("---| Unit Converter |---");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Type the number of choice, then press enter to continue: ");
            Console.WriteLine(
                "0) Exit" + "\n" +
                "1) Length Converter" + "\n" +
                "2) Mass (Weight) Converter" + "\n" +
                "3) Temperature Converter" + "\n"
            );
            HandelUserChoices();
        }

        private static void HandelUserChoices()
        {
            Length.input = Console.ReadLine();
            switch (Length.input)
            {
                case "0":
                    Length.ExitConsoleApp();
                    break;
                case "1":
                    Length.LengthConverter();
                    break;
                case "2":
                    Mass.MassConverter();
                    break;
                case "3":
                    Temperature.TemperatureConverter();
                    break;
                default:
                    Console.WriteLine("number of choice does not exist, restarting console application");
                    Main();
                    break;
            }
        }
    }
}