using System;
using System.Collections.Generic;
using System.Text;

class Helpers{
    Random key;
    public Helpers(Random key){
        this.key = key;
    }

    public string getProjectName()
    {
        List<string> data = new List<string>(new string[]{"A", "B", "C", "D", "E", "F", "G"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public int getBudget()
    {
        return key.Next(1000, 6000);
    }

    public int getHours()
    {
        return key.Next(10, 120);
    }

    public int getStreetNr()
    {
        return key.Next(1, 30);
    }

    public string getStreet()
    {
        List<string> data = new List<string>(new string[]{"Straat A", "Straat B", "Straat C", "Straat D", "Straat E", "Straat F", "Straat G"});
        int index = key.Next(data.Count);
        return data[index];
    }

    public string getPC()
    {
        List<string> data = new List<string>(new string[]{"PC A", "PC B", "PC C", "PC D", "PC E", "PC F", "PC G"});
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

    public int getRooms()
    {
        return key.Next(1, 10);
    }

    public int getRent()
    {
        return key.Next(1, 1000);
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

    public int getSalary()
    {
        return key.Next(50, 200);
    }

}
