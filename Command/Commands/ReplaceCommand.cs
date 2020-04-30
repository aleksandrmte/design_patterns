using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class ReplaceCommand : Command
    {
        public ReplaceCommand(ProfilePage profilePage, TextBox input) : base(profilePage, input)
        {
        }

        public override bool Execute()
        {
            SaveBackup();
            Input.ReplaceSelectionText(ProfilePage.Clipboard);
            return true;
        }
    }
}
