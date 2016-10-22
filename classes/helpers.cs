using System;
using System.Collections.Generic;
using System.Text;

class Helpers{
    private static Random random = new Random((int)DateTime.Now.Ticks);
    public static string generateString(int length)
    {
        StringBuilder builder = new StringBuilder();
        char ch;
        for (int i = 0; i < length; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));                 
            builder.Append(ch);
        }

        return builder.ToString();
    }

    public static int generateNumber(int length){

        int returnedVal = 0;

        if(length == 1){
            returnedVal = random.Next(1,9);
        }
        if(length == 2){
            returnedVal = random.Next(1,99);
        }
        if(length == 3){
            returnedVal = random.Next(1,999);
        }

        return returnedVal;
    }

    public static string generatePC()
    {
        int nrs = random.Next(1000,9999);
        string nrsTxt = nrs.ToString();

        nrsTxt += generateString(2);
        return nrsTxt;
    }

    public static int generateSalary()
    {
        return random.Next(2000,6000);
    }

    public static string generateDegree()
    {
        List<string> degrees = new List<string>();
        degrees.Add("PHD");
        degrees.Add("Bachelor");
        degrees.Add("Genius");

        int index = random.Next(degrees.Count - 1);
        string degree = degrees[index];

        return degree;
    }

    public static int generateRent()
    {
        return random.Next(3000, 7000);
    }
}
