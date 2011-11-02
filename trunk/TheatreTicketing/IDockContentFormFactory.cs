using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;


namespace TheatreTicketing
{
    public interface IDockContentFormFactory
    {
        DockContent Create(string name, DockState showHint, Color backColour);
    }
}