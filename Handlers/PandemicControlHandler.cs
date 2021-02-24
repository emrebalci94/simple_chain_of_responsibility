using System;

namespace simple_chain_of_responsibility.Handlers
{
    public class PandemicControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var rentARoomModel = (RentARoomModel) transportObject;

            /*
             * İlgili iş parçacığı.
             */

            Console.WriteLine($"Oda Pandemi İçin Kontrol Edildi: {rentARoomModel.RoomNumber}");
            return NextChain(rentARoomModel);
        }
    }
}