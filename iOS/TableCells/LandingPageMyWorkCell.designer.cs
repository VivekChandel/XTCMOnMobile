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
	[Register ("LandingPageMyWorkCell")]
	partial class LandingPageMyWorkCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel BUNameValue { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView LeadingView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton sideButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView TrailingView { get; set; }

		[Action ("SideButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SideButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (BUNameValue != null) {
				BUNameValue.Dispose ();
				BUNameValue = null;
			}
			if (LeadingView != null) {
				LeadingView.Dispose ();
				LeadingView = null;
			}
			if (sideButton != null) {
				sideButton.Dispose ();
				sideButton = null;
			}
			if (TrailingView != null) {
				TrailingView.Dispose ();
				TrailingView = null;
			}
		}
	}
}
