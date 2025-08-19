## Проблемы
1. Призводительность
   - Мы знаем точный размер (hashSet.Count). Можно сразу создать список с нужной ёмкость. Когда список new List<T>() заполнится,
    появится новый список с размером в два раза больше, а все элементы перекопируются в него. Если сразу создать список с нужной ёмкость, то можно избежать перекопирования.
2. Я бы добавил "проверку на глупость" (что хэш-сет не пустой)

## Моя реализация
```csharp
public static class HashSetExtensions
{
    public static IReadOnlyList<T> ConvertToList<T>(this HashSet<T> hashSet)
    {
        if (hashSet == null)
            throw new ArgumentNullException(nameof(hashSet));

        // Список с заранее известным размером
        var result = new List<T>(hashSet.Count);

        foreach (var item in hashSet)
        {
            result.Add(item);
        }

        return result;
    }
}
```
