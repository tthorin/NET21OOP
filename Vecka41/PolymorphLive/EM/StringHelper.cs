namespace EM
{

    public static class StringHelper
    {
        public static int ToInt(this string text)
        {
            int.TryParse(text, out int retVal);
            return retVal;
        }
        public static double ToDouble(this string text)
        {
            double.TryParse(text, out double retVal);
            return retVal;
        }
    }


}
