using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;


namespace TheatreTicketing
{
    public class DockContentFormFactory : IDockContentFormFactory
    {
        public DockContent Create(string name, DockState showHint, Color backColour)
        {
            DockContent content = new DockContent();
            content.Name = name;
            content.TabText = name;
            content.Text = name;
            content.ShowHint = showHint;
            content.BackColor = backColour;
            return content;
        }
    }
}
