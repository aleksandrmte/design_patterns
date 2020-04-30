using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        bool Execute();
        void SaveBackup();
        void Undo();
    }
}
