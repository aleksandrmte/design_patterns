using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class Command: ICommand
    {
        protected ProfilePage ProfilePage;
        protected TextBox Input;
        protected string Backup;

        protected Command(ProfilePage profilePage, TextBox input)
        {
            ProfilePage = profilePage;
            Input = input;
        }

        public void SaveBackup()
        {
            Backup = Input.Text;
        }

        public void Undo()
        {
            Input.Text = Backup;
        }

        public abstract bool Execute();

    }
}
