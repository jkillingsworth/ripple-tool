using System;
using System.Windows.Forms;

namespace RippleTool.UI
{
    public static class Events
    {
        public static void Invoke(Control control, Action handler)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(handler);
            }
            else
            {
                handler.Invoke();
            }
        }
    }
}
