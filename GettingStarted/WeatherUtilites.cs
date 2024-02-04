using System;

namespace MyUtilites
{
    class WeatherUtilites
    {
        public static float FahrenheitToCelecius(float temperaturFahrenhrit)
        {
            return ((temperaturFahrenhrit - 32) / 1.8f);
        }

        public static float CleciusToFahrenheit(float temperatureCelsius)
        {
            return (float)(temperatureCelsius * 1.8f + 32);

        }
        private static float ComfortIndex(float temperaturFahrenhrit, float humidityPercent)
        {
            return (float)((temperaturFahrenhrit + humidityPercent) / 4);

        }

        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperaturFahrenhrit = CleciusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Comfort Index for {location} : {ComfortIndex(temperaturFahrenhrit, humidity)}");
        }
    }
}
