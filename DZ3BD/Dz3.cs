using System;
using System.Collections.Generic;

namespace DZ3BD;

public partial class Dz3
{
    public int? Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    // Конструктор класса, который принимает имя и возраст
    public Dz3(int? id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Id}\t{Name}\t{Age}";
    }
}
