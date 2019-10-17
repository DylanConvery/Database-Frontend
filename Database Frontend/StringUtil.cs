namespace Utilities{
	public static class StringUtil {
		///checks whether the provided string contains a number
		public static bool HasNumber(this string s) {
			foreach (char c in s) {
				if (char.IsDigit(c)) {
					return true;
				}
			}
			return false;
		}

		///checks whether the provided string contains a letter
		public static bool HasAlpha(this string s) {
			foreach (char c in s) {
				if (char.IsLetter(c)) {
					return true;
				}
			}
			return false;
		}
	}
}
