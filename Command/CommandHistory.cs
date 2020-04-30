using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CommandHistory
    {
        private readonly IList<ICommand> _commands = new List<ICommand>();

        public void Push(ICommand command)
        {
            _commands.Add(command);
        }

        public ICommand Pop()
        {
            return _commands.LastOrDefault();
        }
    }
}
