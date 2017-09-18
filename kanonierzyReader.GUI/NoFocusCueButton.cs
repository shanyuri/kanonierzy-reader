using System.Windows.Forms;

namespace kanonierzyReader.GUI
{
    public class NoFocusCueButton: Button
    {
        public NoFocusCueButton(): base() {}
        protected override bool ShowFocusCues => false;
    }
}
