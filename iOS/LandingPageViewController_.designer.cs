// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XTCMOnMobile.iOS
{
	[Register ("LandingPageViewController")]
	partial class LandingPageViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton HamBurgerBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView TitleView { get; set; }

		[Action ("HamBurgerBtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HamBurgerBtn_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (HamBurgerBtn != null) {
				HamBurgerBtn.Dispose ();
				HamBurgerBtn = null;
			}
			if (TitleView != null) {
				TitleView.Dispose ();
				TitleView = null;
			}
		}
	}
}
