using System;

public record Person(string Name, int Age);

class Program
{
    static void Main()
    {
        // Khởi tạo một đối tượng record
        var person1 = new Person("Alice", 30);
        var person2 = new Person("Alice", 30);
        var person3 = new Person("Bob", 25);

        // Hiển thị thông tin
        Console.WriteLine(person1);
    }
}