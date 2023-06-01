using System.Drawing;

namespace MilitariaWPFGus.Helper
{
    public static class RecordColor
    {
        public static Color SetColor(string? nazwa)
        {
            Color color;
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
    }
}
