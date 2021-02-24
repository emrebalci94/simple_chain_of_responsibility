using System;

namespace simple_chain_of_responsibility.Handlers
{
    public class RentARoomHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var rentARoomModel = (RentARoomModel) transportObject;

              /*
              * İlgili iş parçacığı.
              */

            Console.WriteLine($"Oda Kiralandı:{transportObject.Name} - {rentARoomModel.RoomNumber}");
            return NextChain(rentARoomModel);
        }
    }
}