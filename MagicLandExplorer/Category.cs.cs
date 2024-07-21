using MagicLandExplorer;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.IO;

public class Category
{
    [JsonProperty("category")]
    public string CategoryName { get; set; }

    [JsonProperty("destinations")]
    public List<Destination> Destinations { get; set; }

    public Category(string categoryName)
    {
        CategoryName = categoryName;
        Destinations = new List<Destination>();
    }

    public static List<Category> getData()
    {
        
        string json = File.ReadAllText("C:\\Users\\LTUC\\source\\repos\\MagicLandExplorer\\MagicLandExplorer\\data\\data (1).json");
        List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

        foreach (var category in categories)
        {
            Console.WriteLine($"Category: {category.CategoryName}");
            foreach (var destination in category.Destinations)
            {
                Console.WriteLine($"  Name: {destination.Name}");
                Console.WriteLine($"  Type: {destination.Type}");
                Console.WriteLine($"  Location: {destination.Location}");
                if (!string.IsNullOrEmpty(destination.Duration))
                {
                    destination.Duration = destination.Duration.Replace(" minutes", "");
                    Console.WriteLine($"Duration: {destination.Duration}");
                }
                Console.WriteLine($"  Description: {destination.Description}");
                Console.WriteLine();
            }
        }


        return categories;

    }
}
