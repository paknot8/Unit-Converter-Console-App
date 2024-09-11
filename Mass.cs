namespace UnitConverter
{
    // Derived from UnitParent
    class Mass : UnitParent
    {
        public static void MassConverter()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("---| Length Converter |---");
            Console.WriteLine("--------------------------");
            Console.WriteLine(
                "0) Exit" + "\n" +
                "1) Metric to Imperial" + "\n" +
                "2) Imperial to metric" + "\n"
            );
            input = Console.ReadLine();
            ConverterChoice();
        }

        private static void ConverterChoice()
        {
            switch (input)
            {
                case "0":
                    ExitConsoleApp();
                    break;
                case "1":
                    MetricToImperial();
                    break;
                case "2":
                    ImperialToMetric();
                    break;
                default:
                    GoBackToMainMenu();
                    break;
            }
        }

        private static void MetricToImperial()
        {
            QuestionMetricToImperial();
            input = Console.ReadLine();
            MetricToImperialCalculation();
            GoBackToMainMenu();
        }

        private static void ImperialToMetric()
        {
            QuestionImperialToMetric();
            input = Console.ReadLine();
            ImperialToMetricCalculation();
            GoBackToMainMenu();
        }

        private static void QuestionMetricToImperial()
        {
            Console.WriteLine(
                "0) Exit" + "\n" +
                "1) Gram to Ounce" + "\n" +
                "2) Kilogram to Pounds" + "\n" +
                "3) Milimeter to Fluid Ounce" + "\n" +
                "4) Liter to Gallon" + "\n"
            );
        }

        private static void QuestionImperialToMetric()
        {
            Console.WriteLine(
                "0) Exit" + "\n" +
                "1) Ounce to Gram" + "\n" +
                "2) Pounds to Kilogram" + "\n" +
                "3) Fluid Ounce to Milimeter" + "\n" +
                "4) Gallon to Liter" + "\n"
            );
        }

        private static void MetricToImperialCalculation()
        {
            switch (input)
            {
                case "0":
                    ExitConsoleApp();
                    break;
                case "1":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 0.035;
                    Console.WriteLine("The result is " + inputNumber + " Gram converted to " + Math.Round(result, 2) + " Ounce.");
                    break;
                case "2":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 2.205;
                    Console.WriteLine("The result is " + inputNumber + " Kilogram converted to " + Math.Round(result, 2) + " Pounds.");
                    break;
                case "3":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 0.034;
                    Console.WriteLine("The result is " + inputNumber + " Milimeter converted to " + Math.Round(result, 2) + " Fluid Ounce.");
                    break;
                case "4":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 0.026;
                    Console.WriteLine("The result is " + inputNumber + " Liter converted to " + Math.Round(result, 2) + " Gallon.");
                    break;
                default:
                    break;
            }
        }

        private static void ImperialToMetricCalculation()
        {
            switch (input)
            {
                case "0":
                    ExitConsoleApp();
                    break;
                case "1":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 28.3495;
                    Console.WriteLine("The result is " + inputNumber + " Ounce converted to " + Math.Round(result, 2) + " Gram.");
                    break;
                case "2":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 453.592;
                    Console.WriteLine("The result is " + inputNumber + " Pounds converted to " + Math.Round(result, 2) + " Kilogram.");
                    break;
                case "3":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 29573.5;
                    Console.WriteLine("The result is " + inputNumber + " Fluid Ounce converted to " + Math.Round(result, 2) + " Milimeter.");
                    break;
                case "4":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 3.78541;
                    Console.WriteLine("The result is " + inputNumber + " Gallon converted to " + Math.Round(result, 2) + " Liter.");
                    break;
                default:
                    break;
            }
        }
    }
}