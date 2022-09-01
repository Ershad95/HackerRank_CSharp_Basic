using static ConsoleApp2.NotesStore;

public class Program
{
    public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
    {
        var dic = new Dictionary<string, int>();
        var componies = employees.Select(x => x.Company).Distinct().ToList();
        foreach (var com in componies)
        {
            var age = employees
                .Where(x => x.Company == com)
                .Average(x => x.Age);
            dic.Add(com, Convert.ToInt32(age));
        }
        return dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
    }

    public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
    {
        var dic = new Dictionary<string, int>();
        var componies = employees.Select(x => x.Company).Distinct().ToList();
        foreach (var com in componies)
        {
            var age = employees
                .Where(x => x.Company == com);
            dic.Add(com, age.Count());
        }
        return dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
    }

    public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
    {
        var dic = new Dictionary<string, Employee>();
        var componies = employees.Select(x => x.Company).Distinct().ToList();
        foreach (var com in componies)
        {
            var age = employees
                .Where(x => x.Company == com);
            var oldest = age.Max(x => x.Age);
            var emp = employees.First(x => x.Age == oldest);
            dic.Add(com, emp);
        }
        return dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

    }
    public static void Main()
    {
        
    }
}