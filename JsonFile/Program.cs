using Newtonsoft.Json;

namespace JsonFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string jsonFilePath = "../../../../data.json";
          string jsonData = File.ReadAllText(jsonFilePath);
          var rootObject = JsonConvert.DeserializeObject<Root>(jsonData);
            IEnumerable<string> neighborhoods = rootObject.features.Select(f => f.properties.neighborhood);
           
            Console.WriteLine("All neighborhoods:");
            Console.WriteLine(string.Join(",", neighborhoods));
            Console.WriteLine("Final Total: " + neighborhoods.Count() + " neighborhoods");

            var namedNeighborhoods = neighborhoods.Where(n => !string.IsNullOrEmpty(n));
            Console.WriteLine("\nNamed neighborhoods:");
            Console.WriteLine(string.Join(", ", namedNeighborhoods));
            Console.WriteLine("Final Total: " + namedNeighborhoods.Count() + " neighborhoods");

            var distinctNeighborhoods = namedNeighborhoods.Distinct();
            Console.WriteLine("\nDistinct neighborhoods:");
            Console.WriteLine(string.Join(", ", distinctNeighborhoods));
            Console.WriteLine("Final Total: " + distinctNeighborhoods.Count() + " neighborhoods");

            var datedNeighborhoods = rootObject.features
                .Select(f => f.properties.neighborhood)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct();
            Console.WriteLine("\nConsolidated neighborhoods:");
            Console.WriteLine(string.Join(", ", datedNeighborhoods));
            Console.WriteLine("Final Total: " + datedNeighborhoods.Count() + " neighborhoods");

            
            var datedNeighborhoodsQuery = (from f in rootObject.features
                                                        let n = f.properties.neighborhood
                                                        where !string.IsNullOrEmpty(n)
                                                        select n).Distinct();
            Console.WriteLine("\nConsolidated neighborhoods (using query syntax):");
            Console.WriteLine(string.Join(", ", datedNeighborhoodsQuery));

            Console.WriteLine("Final Total: " + datedNeighborhoodsQuery.Count() + " neighborhoods");
            

        }
    }
}
public class Feature
{
    public string type { get; set; }
    public Geometry geometry { get; set; }
    public Properties properties { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public List<double> coordinates { get; set; }
}

public class Properties
{
    public string zip { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string address { get; set; }
    public string borough { get; set; }
    public string neighborhood { get; set; }
    public string county { get; set; }
}

public class Root
{
    public string type { get; set; }
    public List<Feature> features { get; set; }
}