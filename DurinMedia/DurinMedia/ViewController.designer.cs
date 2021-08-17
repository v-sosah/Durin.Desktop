// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DurinMedia
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField txtFirstname { get; set; }

		[Outlet]
		AppKit.NSTextField txtFullName { get; set; }

		[Outlet]
		AppKit.NSTextField txtLastname { get; set; }

		[Action ("btnSubmit:")]
		partial void btnSubmit (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtFullName != null) {
				txtFullName.Dispose ();
				txtFullName = null;
			}

			if (txtLastname != null) {
				txtLastname.Dispose ();
				txtLastname = null;
			}

			if (txtFirstname != null) {
				txtFirstname.Dispose ();
				txtFirstname = null;
			}
		}
	}
}
