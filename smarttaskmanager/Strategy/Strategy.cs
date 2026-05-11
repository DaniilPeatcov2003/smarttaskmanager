using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Strategy
{
    public interface ITaskStrategy
    {
        string Process(string input);
    }
}
