using System;
using System.Collections.Generic;

/// <summary>
/// Частичный класс HashTableChaining<T> с определением конструктора и методов для вставки, поиска и удаления элементов методом цепочек.
/// </summary>
public partial class HashTableChaining<T>
{
    private readonly int Capacity;
    private LinkedList<KeyValuePair<string, T>>[] table;

    /// <summary>
    /// Конструктор хеш-таблицы методом цепочек.
    /// </summary>
    /// <param name="capacity">Ёмкость (размер) таблицы.</param>
    public HashTableChaining(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity must be a positive integer.");
        }

        Capacity = capacity;
        table = new LinkedList<KeyValuePair<string, T>>[Capacity];
    }

    // Остальные части класса HashTableChaining<T> здесь...

    /// <summary>
    /// Метод вычисления хэша по ключу.
    /// </summary>
    /// <param name="key">Ключ элемента.</param>
    /// <returns>Вычисленное значение хэша.</returns>
    private int CalculateHash(string key)
    {
        // Реализация вашего метода вычисления хэша
        // Можете использовать встроенные хэш-функции, например, GetHashCode()
        // Пример:
        return Math.Abs(key.GetHashCode()) % Capacity;
    }
}
