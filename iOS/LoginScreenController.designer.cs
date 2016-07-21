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
	[Register ("LoginScreenController")]
	partial class LoginScreenController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel AccessCodeFloatingLbl { get; set; }

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
		UIImageView LogoImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel PasswordFloatingLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField PasswordTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel UsernameFloatingLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField UsernameTextField { get; set; }

		[Action ("LoginBtn_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void LoginBtn_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (AccessCodeFloatingLbl != null) {
				AccessCodeFloatingLbl.Dispose ();
				AccessCodeFloatingLbl = null;
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
			if (LogoImageView != null) {
				LogoImageView.Dispose ();
				LogoImageView = null;
			}
			if (PasswordFloatingLbl != null) {
				PasswordFloatingLbl.Dispose ();
				PasswordFloatingLbl = null;
			}
			if (PasswordTextField != null) {
				PasswordTextField.Dispose ();
				PasswordTextField = null;
			}
			if (UsernameFloatingLbl != null) {
				UsernameFloatingLbl.Dispose ();
				UsernameFloatingLbl = null;
			}
			if (UsernameTextField != null) {
				UsernameTextField.Dispose ();
				UsernameTextField = null;
			}
		}
	}
}
