using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Helper
{
    public static class CommandOrDot
    {
        public static double commandOrDot(string val)
        {
            if(val==null)
            {
                return 0;
            }
            double number = 0;
            double value = (double)10 / 3;
            var commaOrDot = value.ToString()[1];



            if (commaOrDot == '.')
            {
                number = double.Parse(val.Replace(',', '.'));
            }
            else if (commaOrDot == ',')
            {
                number = double.Parse(val.Replace('.', ','));
            }
            return number;
        }
    }
}
