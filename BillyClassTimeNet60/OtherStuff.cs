using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

internal class Lambdas
{
    public Lambdas()
    {
        //Func<string, int> parse = (string s) => int.Parse(s);
        var parse = (ref string s) => int.Parse(s);
        object parse1 = (string s) => int.Parse(s);
        Delegate parse2 = (string s) => int.Parse(s);
        LambdaExpression parse3 = (string s) => int.Parse(s);

        //Func<bool, object> choose = (bool b) => b ? 1 : "two";
        var choose = object (bool b) => b ? 1 : "two";

        //Action<string, int> dateOfMeeting = (name, day) =>
        var dateOfmetting = (string name, int day) =>
        {
            WriteLine($"The date of meeting:{name} is {day}");
        };
        var respuesta = QueryCityDataForYears("New York City", 1960,2010);
    }

    //public string QueryCityDataForYears(string name, int year1, int year2, string notas) => String.Concat(name,year1,year2);
    
    public Func<string, int, int, string> QueryCityDataForYears = (name, year1, year2) =>
    {
        int population1 = 0, population2 = 0;
        double area = 0;

        if (name == "New York City")
        {
            area = 468.48;
            if (year1 == 1960)
            {
                population1 = 7781984;
            }
            if (year2 == 2010)
            {
                population2 = 8175133;
            }
            //return (name, area, year1, population1, year2, population2);
            return name;
        }
        return String.Empty;
        //return ("", 0, 0, 0, 0, 0);
    };

}

internal class MethodGroups
{
    public MethodGroups()
    {
        //Func<int> read = Console.Read;
        var read = Console.Read;
        Action<string> write = Console.Write;
        //var write  = (string) Console.Write; Multiple delegate can't be inferred
    }
}

internal class InterpolatedStringHandlers
{
    public string BuildString(object[] args)
    {
        var sb = new StringBuilder();
        sb.Append($"Hello {args[0]}, how are you?");

        return sb.ToString();
    }

    public void DebugAssert(bool condition)
    {
        Debug.Assert(condition, $"{DateTime.Now} - {ExpensiveCalculation()}");
    }

    public string CreateInvariantString(int result)
        => string.Create(CultureInfo.InvariantCulture, $"The result is {result}");

    private static object ExpensiveCalculation()
    {
        Thread.Sleep(1000);
        return 0;
    }
}