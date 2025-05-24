using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

namespace LinQ;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
 class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Terrirtory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[6]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
    
        //Query 1
        Console.WriteLine("Query 1");
        //

        //

        var datafromiran = File.ReadAllLines("data.csv")

            .Skip(1)


        .Select(l => Data.Parse(l))
        
        .Where(d => d.Country.ToLower()=="afghanistan")
        .Select(d => (Counter: d.Country, When: d.LEType, Gen: d.DataGender, Val: d.Value))
        .OrderBy(t => t.Val)
        .ToList();



        datafromiran.ForEach(t => Console.WriteLine($"{t.Counter}, {t.When}, {t.Gen}, {t.Val}"));
        Console.WriteLine($"Total records: {datafromiran.Count()}");
        Console.WriteLine();

        //Query 2
        Console.WriteLine("Query 2");
        //
        //
        datafromiran.Max(d => d.Val);
        datafromiran.Min(d => d.Val);
        Console.WriteLine(datafromiran.Max(d => d.Val) - datafromiran.Min(d => d.Val));
        Console.WriteLine();

        //Query 3
        Console.WriteLine("Query 3");
        //
        //
        int k = 1;
        var data2 = File.ReadAllLines("data.csv")
            .Skip(1)
            .Select(l => Data.Parse(l))
            .Where(d => d.DataGender == DataGender.Both && d.LEType == LifeExpectancyType.AtBirth)
            .GroupBy(d => d.Country)
            // .Select(g =>

            // {
            //     var MinofGroup = g.OrderBy(d => d.Value).First().Value;
            //     var MaxofGroup = g.OrderByDescending(d => d.Value).First().Value;
            //     return (count: g.Key, Minn: MinofGroup, Max: MaxofGroup, Diff: MaxofGroup - MinofGroup);



            // }

            // )
            .Select(g => (Country: g.Key, Minn: g.OrderBy(d => d.Value).First().Value, Max: g.OrderByDescending(d => d.Value).First().Value, Diff: g.OrderByDescending(d => d.Value).First().Value - g.OrderBy(d => d.Value).First().Value))
            .OrderByDescending(t => t.Diff)
            .ToList();
        data2.ForEach(t => Console.WriteLine(k++ +": "+t.ToString()));
            
        
           
        

        Console.WriteLine();

        //Query 4
        Console.WriteLine("Query 4");
        //
        //
        int u = 1;
        var data3 =File.ReadAllLines("data.csv")
            .Skip(1)
            .Select(l => Data.Parse(l))
            .Where(C => C.DataGender == DataGender.Male && C.LEType == LifeExpectancyType.AtBirth)
            .Select(C => (Countr: C.Country, Year: C.Year, When: C.LEType, Gender: C.DataGender,Val:C.Value))
            .ToList();
            

        

        var data4 =File.ReadAllLines("data.csv")
            .Skip(1)
            .Select(l => Data.Parse(l))
            .Where(C => C.DataGender == DataGender.Female && C.LEType == LifeExpectancyType.AtBirth)
            .Select(C => (Countr: C.Country, Year: C.Year, When: C.LEType, Gender: C.DataGender,Val:C.Value))
            .ToList();
        data4.Join(data3,
        d1 => (d1.Countr, d1.When, d1.Year),
        d2 => (d2.Countr, d2.When, d2.Year),
        (d1, d2) => (Country: d1.Countr, Whatage: d1.When, Whatyear: d1.Year, FemaleVal: d1.Val, MaleVal: d2.Val, Diff: Math.Abs(d1.Val - d2.Val))

        )
        .GroupBy(t => t.Country)
      .Select(g =>
      {
          var Maxofdiff = g.OrderByDescending(d => d.Diff).First();
          return (Country: Maxofdiff.Country, Year: Maxofdiff.Whatyear, Whatage: Maxofdiff.Whatage, Diff: Maxofdiff.Diff);

      })
      .OrderByDescending(t => t.Diff)
      .ToList()
      .ForEach(t => Console.WriteLine(u++ +": "+t.ToString()));

        
        
        
       

        Console.WriteLine();

    }
}
