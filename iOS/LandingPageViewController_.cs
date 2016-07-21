using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;

namespace XTCMOnMobile.iOS
{
	partial class LandingPageViewController : UIViewController
	{
		public LandingPageViewController (IntPtr handle) : base (handle)
		{
            
		}
		public LandingPageViewController()
		{
			
		}

		partial void HamBurgerBtn_TouchUpInside (UIButton sender)
		{
			var ham = new HamburgerMenu(new CGRect(0,0,242,View.Bounds.Height));
			ham.TableItem = new List<string>{"Home","Recent Documents","Search","My Work","Watch List","Reports","Messages","Settings","Help","Logout","Logout","Logout","Logout","Logout","Logout","Logout","Logout"};
				ham.Username = "Sachin";
				ham.UserType= "Admin";
			    ham.UserImage = UIImage.FromBundle("HamburgerMenu/Images/user.png");
			    ham.CustomerLogoImage = UIImage.FromBundle("Images/xeroxlogo.png");
				ham.prepareHamburgerMenuView();

			View.AddSubview(ham.View);
			ham.showWithDuration(0.5);

		}
	}
}
