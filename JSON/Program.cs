using System.Text.Json;
namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guys = new List<Guy>() 
            {
                new Guy() { Name = "Bob", Clothes = new Outfit() { Top = "t-shirt", Bottom = "jeans" },
                Hair = new HairStyle() { Color = HairColor.Red, Length = 3.5f }},
                new Guy() { Name = "Joe", Clothes = new Outfit() { Top = "polo", Bottom = "slacks" },
                Hair = new HairStyle() { Color = HairColor.Gray, Length = 2.7f } },
            };

            var options = new JsonSerializerOptions() { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(guys, options);   
            Console.WriteLine(jsonString);

            var dudes = JsonSerializer.Deserialize<Stack<Dude>>(jsonString);
            while (dudes.Count > 0)
            {
                var dude = dudes.Pop();
                Console.WriteLine($"Next dude: {dude.Name} with {dude.Hair} hair");
            }
        }
    }
}