using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XTCMOnMobile.iOS
{
	partial class InitialNavigationController : UINavigationController
	{
		public InitialNavigationController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			 
			//LoginScreenController loginScreenController = Storyboard.InstantiateViewController ("LoginScreenController") as LoginScreenController;
			//NavigationController.PushViewController (loginScreenController, true);
		}

	}
}
