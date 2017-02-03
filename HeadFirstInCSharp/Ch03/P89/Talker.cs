using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P89
{
    public class Talker
    {
        public static int BlahBlahBlah(string sth2Say, int numOfTimes)
        {
            string finalString = string.Empty;
            for (int count = 0; count < numOfTimes; count++)
            {
                finalString += sth2Say + "\n";
            }
            System.Windows.Forms.MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
