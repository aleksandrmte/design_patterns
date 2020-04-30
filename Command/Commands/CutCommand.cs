using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class CutCommand : Command
    {
        public CutCommand(ProfilePage profilePage, TextBox input) : base(profilePage, input)
        {
        }

        public override bool Execute()
        {
            SaveBackup();
            ProfilePage.Clipboard = Input.GetSelection();
            Input.DeleteSelectionText(ProfilePage.Clipboard);
            return true;
        }
    }
}
