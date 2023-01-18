using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZeroFormatter;

    [ZeroFormattable]
public class MyClass
{
    // Index is key of serialization
    [Index(0)]
    public virtual int Age { get; set; }

    [Index(1)]
    public virtual string FirstName { get; set; }

    [Index(2)]
    public virtual string LastName { get; set; }

    // When mark IgnoreFormatAttribute, out of the serialization target
    [IgnoreFormat]
    public string FullName { get { return FirstName + LastName; } }

    [Index(3)]
    public virtual IList<int> List { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var mc = new MyClass
        {
            Age = 99,
            FirstName = "hoge",
            LastName = "huga",
            List = new List<int> { 1, 10, 100 }
        };
        
        var bytes = ZeroFormatterSerializer.Serialize(mc);
        var mc2 = ZeroFormatterSerializer.Deserialize<MyClass>(bytes);

        // ZeroFormatter.DynamicObjectSegments.MyClass
        Console.WriteLine(mc2.GetType().FullName);
    }
}
