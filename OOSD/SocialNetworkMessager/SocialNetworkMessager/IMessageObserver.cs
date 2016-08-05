using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkMessager
{
    public interface IMessageObserver
    {
        void Update(Status newStatus);
        String Display();

    }
}
