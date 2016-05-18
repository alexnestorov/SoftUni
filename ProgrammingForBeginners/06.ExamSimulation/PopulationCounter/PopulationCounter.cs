using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PopulationCounter
{
    static void Main()
    {
        Dictionary<string, long> populationPerCountry = new Dictionary<string, long>();
        Dictionary<string, long> populationPerCity = new Dictionary<string, long>();
        List<string> cityInCountries = new List<string>();

        string input = Console.ReadLine();
        while (input != "report")
        {
            string city, country;
            long population;
            GetValuesFromInput(input, out city, out country, out population);
            AddCityAndPopulation(populationPerCity, city, population);
            AddCountryAndPopulation(populationPerCountry, country, population);

            // Add city and country to list. The list is used to check each city is in ordered country.
            cityInCountries.Add(country + " " + city);

            input = Console.ReadLine();
        }

        // Order cities by population in descending order.
        var listCities = from pair in populationPerCity
                    orderby pair.Value descending
                    select pair;
        
        // Order countries by population in descending.
        var listCountries = from pair in populationPerCountry
                         orderby pair.Value descending
                         select pair;

        // Output. Print result in this order foreach country - total population -> each city - total population
        foreach (var country in listCountries)
        {
            string tempCountry = country.Key;
            Console.WriteLine("{0} (total population: {1})", country.Key, country.Value);
            PrintCitiesForeachCountry(cityInCountries, listCities, tempCountry);
        }

    }

    static void AddCountryAndPopulation(Dictionary<string, long> populationPerCountry, string country, long population)
    {
        if (populationPerCountry.ContainsKey(country))
        {
            populationPerCountry[country] += population;
        }
        else
        {
            populationPerCountry.Add(country, population);
        }
    }

    static void AddCityAndPopulation(Dictionary<string, long> populationPerCity, string city, long population)
    {
        if (populationPerCity.ContainsKey(city))
        {
            populationPerCity[city] += population;
        }
        else
        {
            populationPerCity.Add(city, population);
        }
    }

    static void GetValuesFromInput(string input, out string city, out string country, out long population)
    {
        string[] peopleInfo = input.Split('|').ToArray();
        city = peopleInfo[0];
        country = peopleInfo[1];
        population = long.Parse(peopleInfo[2]);
    }

    static void PrintCitiesForeachCountry(List<string> cityInCountries, IOrderedEnumerable<KeyValuePair<string, long>> listCities, string tempCountry)
    {
        foreach (var city in listCities)
        {
            string tempCity = city.Key;
            for (int i = 0; i < cityInCountries.Count; i++)
            {

                if (cityInCountries[i].Contains(tempCity) && cityInCountries[i].Contains(tempCountry))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
