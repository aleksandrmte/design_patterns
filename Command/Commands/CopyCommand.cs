using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class CopyCommand: Command
    {
        public CopyCommand(ProfilePage profilePage, TextBox input) : base(profilePage, input)
        {
        }

        public override bool Execute()
        {
            ProfilePage.Clipboard = Input.GetSelection();
            return false;
        }
    }
}
