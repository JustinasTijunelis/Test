using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    public interface ICanRun
    {
        void Run();
        string GetRunnerName(string name);
    }
}
