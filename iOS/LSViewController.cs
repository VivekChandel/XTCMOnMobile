using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XTCMOnMobile.iOS
{
	partial class LSViewController : UIViewController
	{

		bool IsLoginSucessful{ get; set;} //=true;
		static bool IsNotFirstTimeLogin{ get; set;}
		NSLayoutConstraint[] MobilePortraitConstraint;
		public LSViewController (IntPtr handle) : base (handle)
		{
			
		}
		public override void ViewDidLoad ()
		{
			
			base.ViewDidLoad ();
			if (MobilePortraitConstraint == null) {

				MobilePortraitConstraint	 = View.Constraints;
				//MobilePortraitConstraint [1] = LoginView.Constraints;
			}
				
			 
			if (IsNotFirstTimeLogin) {

				AccessCodeTextField.Text = "123623862";//Remove this hardCoding 
			}


			//Initial hiddden eleent
			LoginResponseView.Hidden = true;
			UserNameFloatingLbl.Hidden = true;
			PasswordFloatingLbl.Hidden = true;
			AccessCodeFloatingTextLbl.Hidden = true;

			//Flaoting Label Logic
			UsernameTextField.EditingChanged+=displayFloatingLabel;
			PasswordTextField.EditingChanged+=displayFloatingLabel;
			AccessCodeTextField.EditingChanged+=displayFloatingLabel;

			 
			//Secure Key toggle Logic
			UILongPressGestureRecognizer gesturePass = new UILongPressGestureRecognizer();
			gesturePass.AddTarget(() => HandleDrag(gesturePass,PasswordTextField));
			PasswordEyeBtn.AddGestureRecognizer(gesturePass);

			UILongPressGestureRecognizer gesture = new UILongPressGestureRecognizer();
			gesture.AddTarget(() => HandleDrag(gesture,AccessCodeTextField));
			AccessCodeEyeBtn.AddGestureRecognizer(gesture);
			 
		}

		 

		private void HandleDrag(UILongPressGestureRecognizer recognizer ,UITextField txtfield)

		{
 
			if (recognizer.State == (UIGestureRecognizerState.Recognized ))
			{
				 
				txtfield.SecureTextEntry= false;
  
			}
			 
		}
		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);
			PasswordTextField.SecureTextEntry= true;
			AccessCodeTextField.SecureTextEntry= true;
			//if(touches.)
			ResignKeyBoardResponder();
		}


		public override void TouchesEnded (NSSet touches, UIEvent evt)
		{
			base.TouchesEnded (touches, evt);
			PasswordTextField.SecureTextEntry= true;
			AccessCodeTextField.SecureTextEntry= true;
		}

		public override void TouchesCancelled (NSSet touches, UIEvent evt)
		{
			base.TouchesCancelled (touches, evt);
			PasswordTextField.SecureTextEntry= true;
			AccessCodeTextField.SecureTextEntry= true;
		}

		public override void TouchesMoved (NSSet touches, UIEvent evt)
		{
			base.TouchesMoved (touches, evt);
			PasswordTextField.SecureTextEntry= true;
			AccessCodeTextField.SecureTextEntry= true;
		}
		public override void WillRotate (UIInterfaceOrientation toInterfaceOrientation, double duration)
		{
//			base.WillRotate (toInterfaceOrientation, duration);
//			if (toInterfaceOrientation == UIInterfaceOrientation.LandscapeLeft || toInterfaceOrientation == UIInterfaceOrientation.LandscapeRight)
//				Resize ();
//			else {
//				Resize ();
//			}
		}

		void Resize()
		{
			View.RemoveConstraints (LogoView.Constraints);
			View.RemoveConstraints (LoginView.Constraints);
			//txtfield.AddConstraint( NSLayoutConstraint.Create(View,NSLayoutAttribute.Leading,NSLayoutRelation.Equal,textfi
			//View.AddConstraint(NSLayoutConstraint.Create(txtfield,NSLayoutAttribute.Leading,NSLayoutRelation.Equal,View,NSLayoutAttribute.Leading,1,100));
			//View.AddConstraint(NSLayoutConstraint.Create(txtfield,NSLayoutAttribute.Trailing,NSLayoutRelation.Equal,View,NSLayoutAttribute.Trailing,1,10));
			View.AddConstraint (NSLayoutConstraint.Create (LogoView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1, 20));
			View.AddConstraint (NSLayoutConstraint.Create (LogoView, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, View, NSLayoutAttribute.CenterX, 1, 30));
			View.AddConstraint (NSLayoutConstraint.Create (LogoView, NSLayoutAttribute.Width, NSLayoutRelation.Equal, null, NSLayoutAttribute.Width, 1, 200));
			View.AddConstraint (NSLayoutConstraint.Create (LogoView, NSLayoutAttribute.Height, NSLayoutRelation.Equal, null, NSLayoutAttribute.Height, 1, 40));
		
		
			View.AddConstraint (NSLayoutConstraint.Create (LoginView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1, 50));
			//View.AddConstraint (NSLayoutConstraint.Create (LoginView, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, View, NSLayoutAttribute.CenterX, 1, 30));
			View.AddConstraint (NSLayoutConstraint.Create (LoginView, NSLayoutAttribute.Left, NSLayoutRelation.Equal, View, NSLayoutAttribute.Left, 1, 20));
			View.AddConstraint (NSLayoutConstraint.Create (LoginView, NSLayoutAttribute.Right, NSLayoutRelation.Equal, View, NSLayoutAttribute.Right, 1, -20));

			View.AddConstraint (NSLayoutConstraint.Create (LoginView, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, View, NSLayoutAttribute.Bottom, 1, -20));
		
		
		}


		void ResignKeyBoardResponder()
		{
			PasswordTextField.ResignFirstResponder ();
			AccessCodeTextField.ResignFirstResponder ();
			UsernameTextField.ResignFirstResponder ();

		}

		partial void LoginBtn_TouchUpInside (UIButton sender)
		{
			if(String.IsNullOrEmpty(UsernameTextField.Text)|| String.IsNullOrEmpty(PasswordTextField.Text) 
				|| String.IsNullOrEmpty(AccessCodeTextField.Text))
			{
				//add extra alert in future
			}
			else
			{
				//hit the online service url
				LandingPageViewController landingPageViewController = this.Storyboard.InstantiateViewController ("LandingPageViewController") as LandingPageViewController;

				if(IsLoginSucessful)
				{	
					this.NavigationController.PushViewController(landingPageViewController, true);
					// will Call a method for Login Authorizantion  
				}
				else 
				{
					LoginResponseView.Hidden = false;

				}

			}
		}


		void displayFloatingLabel(object sender,EventArgs e)
		{
			PasswordTextField.SecureTextEntry = true;
			AccessCodeTextField.SecureTextEntry = true;
			if (!String.IsNullOrEmpty (UsernameTextField.Text))
				UserNameFloatingLbl.Hidden = false;
			else 
				UserNameFloatingLbl.Hidden = true;
			if (!String.IsNullOrEmpty (PasswordTextField.Text))
				PasswordFloatingLbl.Hidden = false;
			else 
				PasswordFloatingLbl.Hidden = true;
			if (!String.IsNullOrEmpty (AccessCodeTextField.Text))
				AccessCodeFloatingTextLbl.Hidden = false;
			else 
				AccessCodeFloatingTextLbl.Hidden = true;

		}
	}


	 

}   
