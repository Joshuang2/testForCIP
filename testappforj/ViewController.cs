using System;

using UIKit;

namespace testappforj
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.testLabel.Hidden = true;
			this.testLabel.Text = "Hello World";
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton11_TouchUpInside (UIButton sender)
		{
			this.testLabel.Text = "Hello User";
			sender.Hidden = true;
			this.testLabel.Hidden = false;
		}
	}
}

