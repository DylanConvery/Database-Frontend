using System.Windows.Forms;

namespace Utilities {
	public static class ConfirmationBox{
		///creates a confirmation box used for confirming a decision
		public static bool Show(string message) {
			return ( MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes );
		}
	}
}
