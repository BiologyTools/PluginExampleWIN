using AForge;
//For BioCore replace BioImager with BioCore.
using BioImager;
using System.Windows.Forms;//using BioCore;
namespace PluginExample
{
    //For BioCore replace BioImager with BioCore.
    public class PluginExample : BioImager.Plugin.IPlugin
    {
        public string Name => "PluginExampleWIN";
        public string MenuPath => "Tools/" + Name + ".dll";
        public bool ContextMenu => false;
        public void Execute(string[] args)
        {
            Microscope.TakeImage();
        }
        public void KeyUpEvent(object o, KeyEventArgs e)
        {

        }
        public void KeyDownEvent(object o, KeyEventArgs e)
        {

        }
        public void KeyPressEvent(object o, KeyPressEventArgs e)
        {

        }
        public void ScrollEvent(object o, MouseEventArgs args)
        {

        }
        public void Paint(object o, PaintEventArgs e)
        {

        }
        public void Render(object o, Direct2D dx)
        {

        }
        public void MouseMove(object o, PointD e, MouseEventArgs buts)
        {

        }
        public void MouseUp(object o, PointD e, MouseEventArgs buts)
        {

        }
        public void MouseDown(object o, PointD e, MouseEventArgs buts)
        {
            
        }
    }
}
