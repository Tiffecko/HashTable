using System;

/// <summary>
/// Главный класс с точкой входа в программу.
/// </summary>
class HashTableChainingMain
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Создаем хеш-таблицу методом цепочек с ёмкостью 1000
        HashTableChaining<int> hashTable = new HashTableChaining<int>(1000);

        // Дополнительные действия с хеш-таблицей, если необходимо...

        Console.WriteLine("Program completed successfully.");
    }
}
