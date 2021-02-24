namespace simple_chain_of_responsibility
{
    public interface IHandler
    {
        ITransportObject Handle(ITransportObject transportObject);
        IHandler SetNext(IHandler handler);
    }

    public interface ITransportObject
    {
        public string Name { get; set; }
        public int PersonCount { get; set; }

        /* ...*/
    }
}