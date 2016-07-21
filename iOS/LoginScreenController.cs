using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XTCMOnMobile.iOS
{
	partial class LoginScreenController : UIViewController
	{

		 
		bool IsLoginSucessful{ get; set;} =true;
		static bool IsNotFirstTimeLogin{ get; set;}
		UILabel floatinglabel { get; set;}
		public LoginScreenController (IntPtr handle) : base (handle)
		{
			floatinglabel = new UILabel ();
			NavigationController.NavigationBarHidden = true; 
		}
		public LoginScreenController (string nibName,NSBundle bundle) :base(nibName,bundle)
		{

			NavigationController.NavigationBarHidden = true; 
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			//UserNameTextField.ResignFirstResponder ();
			//LoginResponseView.Hidden = true;

			//Localization Check
			var lang = NSLocale.PreferredLanguages [0];

			Console.WriteLine (lang+ "  vsc");

			if (IsNotFirstTimeLogin) {
				
				AccessCodeTextField.Text = "123623862";//Remove this hardCoding 
			}


			floatinglabel.Text= "Username";

			//UserNameTextField.EditingChanged+= (sender, e) => { Console.WriteLine(e.ToString());};
			 
		}
			
		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);
			//if(touches.)
			ResignKeyBoardResponder();
		}

		partial void LoginBtn_TouchUpInside (UIButton sender)
		{
			//PasswordTextField.SecureTextEntry = false;
			//LanguageChange();
			//Localization();
			 
			if(String.IsNullOrEmpty(UserNameTextField.Text)|| String.IsNullOrEmpty(PasswordTextField.Text) 
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


		void ResignKeyBoardResponder()
		{
			PasswordTextField.ResignFirstResponder ();
			AccessCodeTextField.ResignFirstResponder ();
			UserNameTextField.ResignFirstResponder ();

		}

		void Localization()
		{
			
			UserNameTextField.Placeholder = NSBundle.MainBundle.LocalizedString (Constants.mAccessCodePlaceHolderText, "optional");
			PasswordTextField.Placeholder = NSBundle.MainBundle.LocalizedString (Constants.mPasswordPlaceHolderText, "optional");
			AccessCodeTextField.Placeholder = NSBundle.MainBundle.LocalizedString (Constants.mAccessCodePlaceHolderText, "optional");

			//Console.WriteLine (localizedString+ "  vsc");
		}
		void LanguageChange()
		{
			NSUserDefaults obj = NSUserDefaults.StandardUserDefaults;
			var currentLanguage = new NSMutableArray (1);
			currentLanguage.Add (new NSString ("es"));
			var key = new NSString ("AppleLanguages");
			obj.SetValueForKey (currentLanguage, key);
			obj.Synchronize ();
		}
	}
}
