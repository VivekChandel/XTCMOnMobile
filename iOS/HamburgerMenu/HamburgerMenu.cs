using System;

using UIKit;
using System.Collections.Generic;
using CoreGraphics;
using XTCMOnMobile.iOS;

namespace XTCMOnMobile.iOS
{
	public partial class HamburgerMenu : UIViewController
	{

		public List<string> TableItem{ get; set;}
		public UIImage CustomerLogoImage { get; set;}
		public UIImage UserImage { get; set;}
		public string  UserType  { get; set;}
		public string  Username  { get; set;}

		CGRect screenRect = UIScreen.MainScreen.Bounds; 

		public HamburgerMenu () : base ("HamburgerMenu", null)
		{
		}
		public HamburgerMenu (CGRect frame) : base ("HamburgerMenu", null)
		{
			
			this.View.Frame = frame;
			this.View.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public void prepareHamburgerMenuView ()
		{
 
			this.UserImageView.Image = this.UserImage;
			this.CustomerLogoImageView.Image = this.CustomerLogoImage;
			this.Usernamelabel.Text = this.Username;
			this.Usertypelabel.Text = this.UserType;
			this.MenuTable.Source = new TableSource (TableItem.ToArray ());
			 

			CGRect rect = this.View.Frame;
	
			rect.X = screenRect.Size.Width ;
			 
			this.View.Frame = rect;

		}

		public void showWithDuration (double duration)
		{
			 
			UIView.Animate (duration, () => {

				CGRect frame = this.View.Frame;
				frame.X =screenRect.Size.Width -242;
				this.View.Frame = frame;


			});

		}

		public void hideWithDuration (double duration)
		{

			UIView.Animate (duration, () => {

				CGRect frame = this.View.Frame;
				frame.X =screenRect.Size.Width;
				this.View.Frame = frame;


			});

		}

		partial void CloseBtn_TouchUpInside (UIButton sender)
		{
			//throw new NotImplementedException ();
			UIView.Animate (0.5, () => {

				CGRect frame = this.View.Frame;
				frame.X =screenRect.Size.Width;
				this.View.Frame = frame;


			});
		}
	}





}


