using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Utilities {
	public static class FileReader {
		///outputs the provided file in a MessageBox.
		public static void Read(string path) {
			if (SupportedFileFormat(path)) {
				try {
					System.IO.StreamReader file = new System.IO.StreamReader(@path);
					StringBuilder text = new StringBuilder();
					for (string line = file.ReadLine(); line != null; line = file.ReadLine()) {
						text.AppendLine(line);
					}
					MessageBox.Show(text.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} catch (System.IO.DirectoryNotFoundException) {
					MessageBox.Show(Path.GetDirectoryName(path) + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} catch (System.IO.FileNotFoundException) {
					MessageBox.Show(path + " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} catch (Exception err){
					MessageBox.Show(err.Message);
				}
			} else {
				MessageBox.Show("'" + Path.GetExtension(path) + "' file format not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        ///checks whether a file type is supposed to be supported by Read()
		private static bool SupportedFileFormat(string s) {
			switch (Path.GetExtension(s)) {
				case ".txt":
					return true;
				case ".dat":
					return true;
				case ".doc":
					return true;
				default:
					return false;
			}
		}
	}
}
