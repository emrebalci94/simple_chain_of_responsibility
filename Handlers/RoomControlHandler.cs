using System;

namespace simple_chain_of_responsibility.Handlers
{
    public class RoomControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var rentARoomModel = (RentARoomModel) transportObject;

            /*
             * İlgili iş parçacığı.
             */
            
            Console.WriteLine($"Oda Kontrol Edildi: {rentARoomModel.RoomNumber}");
            return NextChain(rentARoomModel);
        }
    }
}