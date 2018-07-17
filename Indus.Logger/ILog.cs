using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elmas.Logger
{
    public interface ILog
    {
        void WriteErrorLog(string message);
    }
}
