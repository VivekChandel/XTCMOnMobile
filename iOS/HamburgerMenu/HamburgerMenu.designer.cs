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
	[Register ("HamburgerMenu")]
	partial class HamburgerMenu
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CloseBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView CustomerLogoImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView MenuTable { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView UserImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Usernamelabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Usertypelabel { get; set; }

		[Action ("CloseBtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CloseBtn_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (CloseBtn != null) {
				CloseBtn.Dispose ();
				CloseBtn = null;
			}
			if (CustomerLogoImageView != null) {
				CustomerLogoImageView.Dispose ();
				CustomerLogoImageView = null;
			}
			if (MenuTable != null) {
				MenuTable.Dispose ();
				MenuTable = null;
			}
			if (UserImageView != null) {
				UserImageView.Dispose ();
				UserImageView = null;
			}
			if (Usernamelabel != null) {
				Usernamelabel.Dispose ();
				Usernamelabel = null;
			}
			if (Usertypelabel != null) {
				Usertypelabel.Dispose ();
				Usertypelabel = null;
			}
		}
	}
}
