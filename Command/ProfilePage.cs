using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands;

namespace Command
{
    public class ProfilePage
    {
        public Button ButtonCopy = new Button();
        public Button ButtonCut = new Button();
        public Button ButtonReplace = new Button();

        public string Clipboard { get; set; }
        public List<TextBox> Inputs = new List<TextBox>
        {
            new TextBox("Иванов"),
            new TextBox("15.02.1990")
        };
        public TextBox ActiveInput { get; set; }
        private readonly CommandHistory _history = new CommandHistory();

        public ProfilePage()
        {
            ActiveInput = Inputs[0];
        }

        public void ChangeActiveInput(TextBox input)
        {
            ActiveInput = input;
        }

        public void ShowPage()
        {
            ButtonCopy.Click(() => ExecuteCommand(new CopyCommand(this, ActiveInput)));
            ButtonCut.Click(() => ExecuteCommand(new CutCommand(this, ActiveInput)));
            ButtonReplace.Click(() => ExecuteCommand(new ReplaceCommand(this, ActiveInput)));
        }

        public void Undo()
        {
            var command = _history.Pop();
            command?.Undo();
        }

        public void ExecuteCommand(ICommand command)
        {
            if (command.Execute())
                _history.Push(command);
        }


    }
}
