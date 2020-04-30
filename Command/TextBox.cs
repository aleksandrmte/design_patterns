using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TextBox
    {
        public string Text;

        public TextBox(string text)
        {
            Text = text;
        }

        public string GetSelection()
        {
            return Text; 
        }

        public void ReplaceSelectionText(string text)
        {
            Text = text;
        }

        public void DeleteSelectionText(string text)
        {
            Text = Text.Replace(text, "");
        }
    }
}
