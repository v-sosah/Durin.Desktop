using System;

using AppKit;
using Foundation;

namespace DurinMedia
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        partial void btnSubmit(Foundation.NSObject sender) {
            txtFullName.StringValue = DurinMedia.Common.Common.GetFullName(txtFirstname.StringValue,txtLastname.StringValue);
            
        }
    }
}
