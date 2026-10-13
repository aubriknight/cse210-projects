namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Costume World!");
        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarment = "trench coat";
        detective._lowerGarment = "slacks";
        detective._footwear = "dress shoes";
        detective._accessories = "magnifying glass";
        myCostumes.Add(detective);

        Costume snorkeler = new Costume();
        snorkeler._headwear = "goggles";
        snorkeler._upperGarment = "wet suit";
        snorkeler._lowerGarment = "wet suit";
        snorkeler._footwear = "flippers";
        snorkeler._accessories = "snorkel";
        myCostumes.Add(snorkeler);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }

        // save to file
        string filename = "costumes.csv";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Costume c in myCostumes) {
            outputFile.WriteLine($"{c._headwear}, {c._upperGarment}, {c._lowerGarment}, {c._footwear}, {c._accessories}");
            }
        }
    }
}
