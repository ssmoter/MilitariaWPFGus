using System.Drawing;

namespace MilitariaWPFGus.Helper
{
    public static class RecordColor
    {
        public static Color SetColor(string? nazwa)
        {
            Color color;
            switch (SelectLanguage.Current)
            {
                case "pl":
                    {
                        color = PL(nazwa, out color);
                    }
                    break;
                case "en":
                    {
                        color = EN(nazwa, out color);
                    }
                    break;
                default:
                    {
                        color = Color.White;
                    }
                    break;
            }
            return color;
        }

        private static Color PL(string? nazwa, out Color color)
        {
            switch (nazwa)
            {
                case "Temat":
                    {
                        color = Color.Green;
                    }
                    break;
                case "Zakres informacyjny":
                    {
                        color = Color.Red;
                    }
                    break;
                case "Dziedzina":
                    {
                        color = Color.Yellow;
                    }
                    break;
                default:
                    {
                        color = Color.White;
                    }
                    break;
            }
            return color;
        }
        private static Color EN(string? nazwa, out Color color)
        {
            switch (nazwa)
            {
                case "Topic":
                    {
                        color = Color.Green;
                    }
                    break;
                case "Information scope":
                    {
                        color = Color.Red;
                    }
                    break;
                case "Domain":
                    {
                        color = Color.Yellow;
                    }
                    break;
                default:
                    {
                        color = Color.White;
                    }
                    break;
            }
            return color;
        }
    }
}
