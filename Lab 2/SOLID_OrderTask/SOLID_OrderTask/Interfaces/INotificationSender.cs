using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OrderTask.Interfaces
{
    public interface INotificationSender
    {
        void SendOrderConfirmationEmail(Order order);

    }
}
