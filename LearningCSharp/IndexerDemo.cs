using System;

public class IndexerDemo
{
    int eNo;
    string eName, job, dName, location;
    double salary;

    public IndexerDemo(int eNo, string eName, string job, string dName, string location, double salary)
    {
        this.eNo = eNo;
        this.eName = eName;
        this.job = job;
        this.dName = dName;
        this.location = location;
        this.salary = salary;
    }

    public object this[int index]
    {
        get
        {
            if (index == 1)
                return eNo;
            else if (index == 2)
                return eName;
            else if (index == 3)
                return job;
            else if (index == 4)
                return dName;
            else if (index == 5)
                return location;
            else if (index == 6)
                return salary;
            else
                return "ArgumentOutOfRangeException";
        }
        set
        {
            if (index == 1)
                eNo = (int)value;
            else if (index == 2)
                eName = (string)value;
            else if (index == 3)
                job = (string)value;
            else if (index == 4)
                dName = (string)value;
            else if (index == 5)
                location = (string)value;
            else if (index == 6)
                salary = (double)value;
            else;
        }
    }

    static void Main(string[] args)
    {
        IndexerDemo i = new IndexerDemo(1001, "Shashwat", "Zenoti", "Software Engineer", "Delhi", 40000.00);
        Console.WriteLine(i[1]);
        i[1] = 1002;
        Console.WriteLine(i[1]);
    }
}
