using System;
using System.Windows.Forms;

namespace FrameExtract {
	public class OwnerDisablingForm : Form {
		public OwnerDisablingForm(){
			Activated += OnActivated;
			Deactivate += OnDeactivate;
		}


		protected void OnActivated(object sender, EventArgs e) {
			if (Owner != null) {
				Owner.Enabled = false;
			}
		}

		protected void OnDeactivate(object sender, EventArgs e) {
			if (Owner != null) {
				Owner.Enabled = true;
			}
		}
	}
}
