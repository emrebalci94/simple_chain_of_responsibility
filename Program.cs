using System;
using simple_chain_of_responsibility.Handlers;

namespace simple_chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Halkarın tanımlamasını gerçekleştiriyoruz
            var memberControlHandler = new MemberControlHandler();
            var pandemicControlHandler = new PandemicControlHandler();
            var roomControlHandler = new RoomControlHandler();
            var rentARoomHandler = new RentARoomHandler();

            // TODO: İş Akışımızı belirliyoruz.
            memberControlHandler.SetNext(roomControlHandler).SetNext(pandemicControlHandler).SetNext(rentARoomHandler);

            // TODO: Tüm halkamızı çalıştırıyoruz.
            var result = memberControlHandler.Handle(new RentARoomModel
            {
                Name = "Emre",
                PersonCount = 4,
                RoomNumber = 1
            });
            
            Console.ReadKey();
        }
    }
}