using System;

namespace simple_chain_of_responsibility.Handlers
{
    public class MemberControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            /*
             * İlgili iş parçacığı.
             */
            
            Console.WriteLine($"Üye Kontrol Edildi: {transportObject.Name}");
            return NextChain(transportObject);
        }
    }
}