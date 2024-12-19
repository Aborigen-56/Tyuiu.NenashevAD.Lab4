namespace ConversionCalc.Lib
{
    public class ConversionCalcLib
    {
        private static readonly Dictionary<(string from, string to), double> ConversionFactors = new()
        {
            // Вес
            { ("kg", "lbs") , 2.20462 },
            { ("kg", "oz") , 35.274 },
            { ("kg", "tons") , 0.001 },
            { ("kg", "g") , 1000 },

            { ("lbs", "kg") , 1 / 2.20462 },
            { ("lbs", "g") , 453.592 },
            { ("lbs", "tons") , 0.000453592 },
            { ("lbs", "oz") , 16 },

            { ("oz", "kg") , 0.0283495 },
            { ("oz", "g") , 28.35 },
            { ("oz", "tons") , 2.835e-5 },
            { ("oz", "lbs") , 0.0625 },

            { ("g", "lbs") , 1 / 453.6 },
            { ("g", "oz") , 1 / 28.35 },
            { ("g", "kg") , 0.001 },
            { ("g", "tons") , 1e-6 },

            { ("tons", "kg") , 1000 },
            { ("tons", "g") , 1e6 },
            { ("tons", "oz") , 35274 },
            { ("tons", "lbs") , 2204.62 },

            // Длина
            { ("m", "cm") , 100 },
            { ("m", "mm") , 1000 },
            { ("m", "km") , 0.001 },
            { ("m", "ft") , 3.28084 },
            { ("m", "in") , 39.3701 },

            { ("cm", "m") , 0.01 },
            { ("cm", "mm") , 10 },
            { ("cm", "km") , 1e-5 },
            { ("cm", "ft") , 0.0328084 },
            { ("cm", "in") , 0.393701 },

            { ("mm", "m") , 0.001 },
            { ("mm", "cm") , 0.1 },
            { ("mm", "km") , 1e-6 },
            { ("mm", "ft") , 0.00328084 },
            { ("mm", "in") , 0.0393701 },

            { ("km", "m") , 1000 },
            { ("km", "cm") , 100000 },
            { ("km", "mm") , 1e6 },
            { ("km", "ft") , 3280.84 },
            { ("km", "in") , 39370.1 },

            { ("ft", "m") , 0.3048 },
            { ("ft", "cm") , 30.48 },
            { ("ft", "mm") , 304.8 },
            { ("ft", "km") , 0.0003048 },
            { ("ft", "in") , 12 },

            { ("in", "m") , 0.0254 },
            { ("in", "cm") , 2.54 },
            { ("in", "mm") , 25.4 },
            { ("in", "km") , 2.54e-5 },
            { ("in", "ft") , 0.0833333 },

            // Объем
            { ("l", "ml") , 1000 },
            { ("l", "gal") , 0.264172 },
            { ("l", "m3") , 0.001 },

            { ("ml", "l") , 0.001 },
            { ("ml", "gal") , 0.000264172 },
            { ("ml", "m3") , 1e-6 },

            { ("gal", "l") , 3.78541 },
            { ("gal", "ml") , 3785.41 },
            { ("gal", "m3") , 0.00378541 },


            { ("m3", "l") , 1000 },
            { ("m3", "ml") , 1e6 },
            { ("m3", "gal") , 264.172 },
        };

        // Метод для преобразования
        public double Convert(double value, string fromUnit, string toUnit)
        {
            if (ConversionFactors.TryGetValue((fromUnit, toUnit), out var factor))
            {
                return value * factor;
            }
            throw new ArgumentException($"Преобразовние из {fromUnit} в {toUnit} не поддерживается.");
        }
    }
}
