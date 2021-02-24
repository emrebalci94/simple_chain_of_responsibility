namespace simple_chain_of_responsibility
{
    public class RentARoomModel : ITransportObject
    {
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public int PersonCount { get; set; }
        /*...*/
    }
}