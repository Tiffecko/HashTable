using System;
using System.Collections.Generic;

/// <summary>
/// Частичный класс HashTableChaining<T> с методами для вставки, поиска и удаления элементов методом цепочек.
/// </summary>
public partial class HashTableChaining<T>
{
    // Дополнительные методы, если они необходимы...

    /// <summary>
    /// Вставить элемент в хеш-таблицу методом цепочек.
    /// </summary>
    /// <param name="key">Ключ элемента.</param>
    /// <param name="value">Значение элемента.</param>
    public void Insert(string key, T value)
    {
        int hash = CalculateHash(key);
        LinkedList<KeyValuePair<string, T>> chain = table[hash];

        // Проверка наличия цепочки для данного хеша
        if (chain == null)
        {
            chain = new LinkedList<KeyValuePair<string, T>>();
            table[hash] = chain;
        }

        // Проверка наличия ключа в цепочке
        foreach (var pair in chain)
        {
            if (pair.Key.Equals(key))
            {
                // Ключ уже существует, можно обновить значение
                chain.Remove(pair);
                chain.AddLast(new KeyValuePair<string, T>(key, value));
                return;
            }
        }

        // Ключ не найден, добавляем новую пару в цепочку
        chain.AddLast(new KeyValuePair<string, T>(key, value));
    }

    // Остальные методы здесь...

    /// <summary>
    /// Поиск элемента в хеш-таблице методом цепочек.
    /// </summary>
    /// <param name="key">Ключ элемента.</param>
    /// <returns>Значение элемента или значение по умолчанию, если элемент не найден.</returns>
    public T Search(string key)
    {
        int hash = CalculateHash(key);
        LinkedList<KeyValuePair<string, T>> chain = table[hash];

        if (chain != null)
        {
            foreach (var pair in chain)
            {
                if (pair.Key.Equals(key))
                {
                    // Элемент найден
                    return pair.Value;
                }
            }
        }

        // Элемент не найден
        return default(T);
    }

    /// <summary>
    /// Удаление элемента из хеш-таблицы методом цепочек.
    /// </summary>
    /// <param name="key">Ключ элемента.</param>
    public void Delete(string key)
    {
        int hash = CalculateHash(key);
        LinkedList<KeyValuePair<string, T>> chain = table[hash];

        if (chain != null)
        {
            foreach (var pair in chain)
            {
                if (pair.Key.Equals(key))
                {
                    // Удаляем элемент из цепочки
                    chain.Remove(pair);
                    return;
                }
            }
        }
    }
}
