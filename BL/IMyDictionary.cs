namespace BL
{
    public interface IMyDictionary<in TKey, TValue>
    {

        TValue this[TKey key] { get; set; }
        int Count { get; }

        bool IsEmpty();
        void Clear();
        void Add(TKey key, TValue value);
        void Remove(TKey key);
        bool ContainsKey(TKey key);
    }
}