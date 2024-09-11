namespace UnitConverter
{
    // Derived from UnitParent
    class Temperature : UnitParent
    {
        public static void TemperatureConverter()
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
                "1) Degree Celcius to Fahrenheit" + "\n"
            );
        }

        private static void QuestionImperialToMetric()
        {
            Console.WriteLine(
                "0) Exit" + "\n" +
                "1) Fahrenheit to Degree" + "\n"
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
                    result = (Convert.ToDouble(inputNumber) * 9/5) + 32;
                    Console.WriteLine("The result is " + inputNumber + " Degree Celcius converted to " + Math.Round(result, 2) + " Fahrenheit.");
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
                    result = (Convert.ToDouble(inputNumber) - 32) * 5/9;
                    Console.WriteLine("The result is " + inputNumber + " Fahrenheit converted to " + Math.Round(result, 2) + " Degree Celcius.");
                    break;
                default:
                    break;
            }
        }
    }
}