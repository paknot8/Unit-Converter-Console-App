namespace UnitConverter
{
    // Derived from UnitParent
    class Length : UnitParent
    {
        public static void LengthConverter()
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
                "1) Centimeter to Inch" + "\n" +
                "2) Meter to Feet" + "\n" +
                "3) Kilometer to Mile" + "\n"
            );
        }

        private static void QuestionImperialToMetric()
        {
            Console.WriteLine(
                "0) Exit" + "\n" +
                "1) Inch to Centimeter" + "\n" +
                "2) Feet to Meter" + "\n" +
                "3) Mile to Kilometer" + "\n"
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
                    result = Convert.ToDouble(inputNumber) * 0.0394;
                    Console.WriteLine("The result is " + inputNumber + " centimeters converted to " + Math.Round(result, 2) + " inches.");
                    break;
                case "2":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 2.281;
                    Console.WriteLine("The result is " + inputNumber + " meter converted to " + Math.Round(result, 2) + " feet.");
                    break;
                case "3":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 0.621;
                    Console.WriteLine("The result is " + inputNumber + " kilometer converted to " + Math.Round(result, 2) + " mile.");
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
                    result = Convert.ToDouble(inputNumber) * 2.54;
                    Console.WriteLine("The result is " + inputNumber + " inches converted to " + Math.Round(result, 2) + " centimeter.");
                    break;
                case "2":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 0.3048;
                    Console.WriteLine("The result is " + inputNumber + " feet converted to " + Math.Round(result, 2) + " meter.");
                    break;
                case "3":
                    InputNumber();
                    result = Convert.ToDouble(inputNumber) * 1.60934;
                    Console.WriteLine("The result is " + inputNumber + " mile converted to " + Math.Round(result, 2) + " kilometer.");
                    break;
                default:
                    break;
            }
        }
    }
}