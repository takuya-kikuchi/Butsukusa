using System;
using AppKit;
using Foundation;

namespace Butsukusa
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            
        }

        public override void ViewDidAppear()
        {
            base.ViewDidAppear();

            this.View.Window.TitleVisibility = NSWindowTitleVisibility.Hidden;
            this.View.Window.TitlebarAppearsTransparent = true;
        }

        public override NSObject RepresentedObject
        {
            get { return base.RepresentedObject; }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}