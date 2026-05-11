using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Strategy
{
    public class NoStrategy : ITaskStrategy
    {
        public string Process(string input)
        {
            return input;
        }
    }
}
