using System;
using System.Collections.Generic;
using System.Text;

class Helpers{
    Random key;
    public Helpers(Random key){
        this.key = key;
    }

    public int getRandomNr(int min, int max){
        return key.Next(min,max);
    }

    public string getProjectName()
    {
        List<string> data = new List<string>(new string[]{"A", "B", "C", "D", "E", "F", "G"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getStreet()
    {
        List<string> data = new List<string>(new string[]{"Straat A", "Straat B", "Straat C", "Straat D", "Straat E", "Straat F", "Straat G"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getPC()
    {
        List<string> data = new List<string>(new string[]{"3022AA", "1234AB", "9320AC", "1238AD", "1292AA", "9872QW", "3022XD"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getCity()
    {
        List<string> data = new List<string>(new string[]{"City A", "City B", "City C", "City D", "City E", "City F", "City G"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getCountry()
    {
        List<string> data = new List<string>(new string[]{"Country A", "Country B", "Country C", "Country D", "Country E", "Country F", "Country G"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getHQ()
    {
        List<string> data = new List<string>(new string[]{"Building 1", "Building 2", "Building 3", "Building 4", "Building 5", "Building 6", "Building 7" });
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getFirstName()
    {
        List<string> data = new List<string>(new string[]{"Henk", "Andy", "Johan", "Andy nogmaals", "Ginny", "Harry", "Hermelien"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getLastName()
    {
        List<string> data = new List<string>(new string[]{"Bhadai", "Potter", "Balkenende", "Trump", "Vergeten", "Kat", "Poes"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getCourse()
    {
        List<string> data = new List<string>(new string[]{"Cursus een", "Cursus twee", "Cursus drie", "Cursus vier", "Cursus vijf", "Cursus zes", "Cursus zeven"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getSchool()
    {
        List<string> data = new List<string>(new string[]{"HRO", "ergens", "Zadkine", "Nee beter he", "GLR", "LPM", "CC", "XD"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getLevel()
    {
        List<string> data = new List<string>(new string[]{"1", "2", "3", "4", "5", "16", "39"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getPositionName()
    {
        List<string> data = new List<string>(new string[]{"Positie 1", "Positie 2", "Positie drie", "Positie vier", "Positie 5", "Positie 6", "Verveelt zich"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getPositionDescription()
    {
        List<string> data = new List<string>(new string[]{"Doet iets", "Doet niks", "Doet een beetje", "Doet heel veel", "Ja nee", "Nee beter he", "Nee."});
        int index = key.Next(data.Count);
        return data[index];
    }

}
