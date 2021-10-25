using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class GenericsDemo
{
	class Student: IComparable<Student>
    {
        public int sId, marks;
        public string name;
        public Student(int sId, string name, int marks)
        {
            this.sId = sId;
            this.name = name;
            this.marks = marks;
        }

        public int CompareTo(Student obj)
        {
            if (this.sId > obj.sId)
                return 1;
            else if (this.sId < obj.sId)
                return -1;
            return 0;
        }

        public static int CompareNames(Student s1, Student s2)
        {
            return s1.name.CompareTo(s2.name);
        }
    }

    class CompareByMarks : IComparer<Student>
    {
        public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            if (x.marks > y.marks)
                return -1;
            else if (x.marks < y.marks)
                return 1;
            return 0;
        }
    }

    static void Main()
    {
        Student s1 = new Student(103, "Shashwat", 343);
        Student s2 = new Student(102, "Rahul", 565);
        Student s3 = new Student(101, "John", 595);

        List<Student> li = new List<Student>(){ s1, s2, s3 };

        // Comparison<Student> obj = new Comparison<Student>(Student.CompareNames);

        li.Sort((l1, l2) => l1.name.CompareTo(l2.name));

        // CompareByMarks cbm = new CompareByMarks();

        // li.Sort(cbm);
        //li.Sort(obj);
        foreach (var item in li)
        {
            Console.WriteLine(item.sId + " " + item.name + " " + item.marks);
        }
    }
}
