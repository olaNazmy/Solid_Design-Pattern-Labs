using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    internal interface PaymentHandler
    {
        void process(double amount);
    }
}
