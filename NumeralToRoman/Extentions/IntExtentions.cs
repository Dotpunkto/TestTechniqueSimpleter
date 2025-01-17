namespace NumeralToRoman.Extentions;

public static class IntExtentions
{
    public static readonly Dictionary<string, int> romanNumeralsKeyValue = new()
    {
        {"M", 1000},
        {"CM", 900},
        {"D", 500},
        {"CD", 400},
        {"C", 100},
        {"XC", 90},
        {"L", 50},
        {"XL", 40},
        {"X", 10},
        {"IX", 9},
        {"V", 5},
        {"IV", 4},
        {"I", 1}
    };

    public static string ToRoman(this int num)
    {
        var result = string.Empty;

        foreach (var romanNumeral in romanNumeralsKeyValue)
        {
            var numberOfRepetitions = num / romanNumeral.Value; // Nombre de fois que le chiffre romain sera répété
            result += string.Concat(Enumerable.Repeat(romanNumeral.Key, numberOfRepetitions)); // Création de la séquence
            num %= romanNumeral.Value; // Récupération du modulo pour la suite de la conversion
        }

        return result;
    }
}
