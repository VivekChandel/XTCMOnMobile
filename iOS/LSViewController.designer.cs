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
	[Register ("LSViewController")]
	partial class LSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton AccessCodeEyeBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel AccessCodeFloatingTextLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField AccessCodeTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LoginBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView LoginResponseView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView LoginView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView LogoView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PasswordEyeBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel PasswordFloatingLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField PasswordTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel UserNameFloatingLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField UsernameTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel WarningBottomLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView WarningImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel WarningTopLabel { get; set; }

		[Action ("LoginBtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void LoginBtn_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (AccessCodeEyeBtn != null) {
				AccessCodeEyeBtn.Dispose ();
				AccessCodeEyeBtn = null;
			}
			if (AccessCodeFloatingTextLbl != null) {
				AccessCodeFloatingTextLbl.Dispose ();
				AccessCodeFloatingTextLbl = null;
			}
			if (AccessCodeTextField != null) {
				AccessCodeTextField.Dispose ();
				AccessCodeTextField = null;
			}
			if (LoginBtn != null) {
				LoginBtn.Dispose ();
				LoginBtn = null;
			}
			if (LoginResponseView != null) {
				LoginResponseView.Dispose ();
				LoginResponseView = null;
			}
			if (LoginView != null) {
				LoginView.Dispose ();
				LoginView = null;
			}
			if (LogoView != null) {
				LogoView.Dispose ();
				LogoView = null;
			}
			if (PasswordEyeBtn != null) {
				PasswordEyeBtn.Dispose ();
				PasswordEyeBtn = null;
			}
			if (PasswordFloatingLbl != null) {
				PasswordFloatingLbl.Dispose ();
				PasswordFloatingLbl = null;
			}
			if (PasswordTextField != null) {
				PasswordTextField.Dispose ();
				PasswordTextField = null;
			}
			if (UserNameFloatingLbl != null) {
				UserNameFloatingLbl.Dispose ();
				UserNameFloatingLbl = null;
			}
			if (UsernameTextField != null) {
				UsernameTextField.Dispose ();
				UsernameTextField = null;
			}
			if (WarningBottomLabel != null) {
				WarningBottomLabel.Dispose ();
				WarningBottomLabel = null;
			}
			if (WarningImageView != null) {
				WarningImageView.Dispose ();
				WarningImageView = null;
			}
			if (WarningTopLabel != null) {
				WarningTopLabel.Dispose ();
				WarningTopLabel = null;
			}
		}
	}
}
