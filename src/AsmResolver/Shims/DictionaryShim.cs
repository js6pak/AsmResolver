using System.Collections.Generic;

namespace AsmResolver.Shims;

/// <summary>
/// Provides compatibility shims for the <see cref="Dictionary{TKey, TValue}"/> class for builds that target older .NET framework versions.
/// </summary>
public static class DictionaryShim
{
    // TODO move to mm.backports?
#if !NETSTANDARD2_1_OR_GREATER || !NETCOREAPP2_1_OR_GREATER
    /// <summary>Ensures that the dictionary can hold up to a specified number of entries without any further expansion of its backing storage.</summary>
    /// <param name="capacity">The number of entries.</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than 0.</exception>
    /// <returns>The current capacity of the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
    public static int EnsureCapacity<TKey, TValue>(this Dictionary<TKey, TValue> @this, int capacity) where TKey : notnull
    {
        return -1;
    }
#endif
}
