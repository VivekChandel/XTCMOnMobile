using System;

using Foundation;
using UIKit;

namespace XTCMOnMobile.iOS
{
	public partial class LandingPageMyWorkCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("LandingPageMyWorkCell");
		public static readonly UINib Nib;
		//bool _isItemAdedToWatchlist{ get; set;}
		static LandingPageMyWorkCell ()
		{
			Nib = UINib.FromName ("LandingPageMyWorkCell", NSBundle.MainBundle);
		}

		public LandingPageMyWorkCell (IntPtr handle) : base (handle)
		{
			ContentView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			Console.WriteLine (ContentView.Bounds.Width.ToString()+"    "+ "vsc");
		}
		public LandingPageMyWorkCell ()  
		{
			
		}
		public override void AwakeFromNib ()
		{
			Console.WriteLine(" Awoke from nib"+ "vsc");
						
		}
		public void Initializecell(string buname)
		{
			this.BUNameValue.Text = buname;
			//ClearStateOfCell ();
		}

//		partial void WatchLIstButton_TouchUpInside (UIButton sender)
//		{
//
//
////			var image = UIImage.FromBundle("Images/watchList.png");
////			watchLIstButton.SetBackgroundImage(image,UIControlState.Normal );
//			//_isItemAdedToWatchlist = true;
//			Console.WriteLine("watch list button clicked");
//			//will be calling a method to to put the 
//
//		}
		void ClearStateOfCell()
		{
			var image = UIImage.FromBundle("Images/watchlistdull.png");
			//watchLIstButton.SetBackgroundImage(image,UIControlState.Normal );
		}

		protected override void Dispose (bool disposing)
		{
			 
			base.Dispose(disposing);

		}

		partial void SideButton_TouchUpInside (UIButton sender)
		{
			var frame = TrailingView.Frame; 
				frame.Width = 400;
			TrailingView.Frame= frame;
		}
	}
}
