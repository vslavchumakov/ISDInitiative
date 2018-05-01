namespace Task_3
{
    interface IMyDictionary<TKey,TValue>
    {
        // Method Add
        void Add(TKey key, TValue value);

        // An indexer
        TValue this[TKey index] { get;}

        // A read-only property
        int Count { get; }
    }
}
