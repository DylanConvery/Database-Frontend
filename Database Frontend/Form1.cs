using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using System.Data.OleDb;

namespace Database_Frontend {
	public partial class Form1 : Form {
		//used for handling the connection to the database
		private DBConnection connection;

		//better represent the modes of the application
		public enum EditMode { VIEW_MODE, NEW_MODE, EDIT_MODE, NO_CONNECTION };

		//used to keep track of the current mode for control functionality
		private EditMode mode = EditMode.NO_CONNECTION;

		//used for keeping track of the last selected item in listBoxDataBaseTable
		private int PREVIOUSLY_SELECTED_ROW = -1;

		#region Form1 Setup Functions
		public Form1() {
			InitializeComponent();
			try { //try initialize connection with location of database and necessary connection string
				connection = new DBConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\resources\\CarsDB.accdb"); //try make an initial connection with the database
				connection.Open();
            }
            catch (Exception err) {
				SwitchMode(EditMode.NO_CONNECTION);
				MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
            //if all went well and a connection was established, change mode to normal
            if (connection.ConnectionState() == ConnectionState.Open) { 
				try {
					SwitchMode(EditMode.VIEW_MODE);
					PopulateListBox();
                    labelColumns.Text = ColumnNames();
                }
                catch (Exception err) {
					SwitchMode(EditMode.NO_CONNECTION);
					MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		#endregion

		#region GUI Related Functions
		///populates listboxDataBaseTable with the rows and columns of the connected database
		private void PopulateListBox() {
			listBoxDataBaseTable.Items.Clear();
			DataTable table = null;

			try {
				table = connection.GetTable();
			} catch {
				throw new Exception("Connection to database was lost.\nPlease contact an administrator.");
			}

			//concatanates each field in a row into one string and then enters them into listboxDataBaseTable as single items
			if (table != null) {
				foreach (DataRow row in table.Rows) {
					StringBuilder DB_row = new StringBuilder();
					foreach (DataColumn column in table.Columns) {
						DB_row.Append(row[column] + "\t");
					}
					listBoxDataBaseTable.Items.Add(DB_row.ToString());
				}
			} else {
				throw new Exception("DataTable object is NULL.");
			}
		}

        private string ColumnNames() {
            DataTable table = connection.GetTable();
            StringBuilder DB_column = new StringBuilder();
            foreach (DataColumn column in table.Columns) {
                DB_column.Append(column + ", ");
            }
            return DB_column.ToString();
        }

        ///populates the input fields with the selected item. Is dependant on the input fields.
        private void FillInputBoxes() {
			if (listBoxDataBaseTable.SelectedIndex >= 0) {
				SwitchMode(EditMode.EDIT_MODE);

				DataTable table = connection.GetTable();

				manufacturerTextBox.Text = table.Rows[listBoxDataBaseTable.SelectedIndex][1].ToString();
				modelTextBox.Text = table.Rows[listBoxDataBaseTable.SelectedIndex][2].ToString();
				colorTextBox.Text = table.Rows[listBoxDataBaseTable.SelectedIndex][3].ToString();
				petrolCheckBox.Checked = Boolean.Parse(table.Rows[listBoxDataBaseTable.SelectedIndex][4].ToString());
				engineSizeTextBox.Text = table.Rows[listBoxDataBaseTable.SelectedIndex][5].ToString();
			}
		}

		///allows the mode of the program to be set. Different controls will become available and unavailable
        ///depending on the mode used.
		private void SwitchMode(EditMode mode) {
			switch (mode) {
				case EditMode.VIEW_MODE:
					this.mode = EditMode.VIEW_MODE;
					labelMode.Text = "View";
					labelMode.ForeColor = Color.ForestGreen;
					ResetTextFields();
					listBoxDataBaseTable.ClearSelected();

					buttonNew.Enabled = true;
					listBoxDataBaseTable.Enabled = true;
					groupBoxInputEntry.Enabled = false;

					buttonDelete.Enabled = false;
					buttonCancel.Enabled = false;
					buttonSave.Enabled = false;
					break;

				case EditMode.NEW_MODE:
					this.mode = EditMode.NEW_MODE;
					labelMode.Text = "New";
					labelMode.ForeColor = Color.DarkSlateBlue;
					ResetTextFields();

					groupBoxInputEntry.Enabled = true;
					buttonSave.Enabled = true;
					buttonCancel.Enabled = true;

					buttonNew.Enabled = false;
					buttonDelete.Enabled = false;
					listBoxDataBaseTable.Enabled = false;
					break;

				case EditMode.EDIT_MODE:
					this.mode = EditMode.EDIT_MODE;
					labelMode.Text = "Edit";
					labelMode.ForeColor = Color.DarkRed;

					groupBoxInputEntry.Enabled = true;
					buttonDelete.Enabled = true;
					buttonCancel.Enabled = true;
					buttonSave.Enabled = true;

					buttonNew.Enabled = false;
					break;

				case EditMode.NO_CONNECTION:
					this.mode = EditMode.NO_CONNECTION;
					labelMode.Text = "No Connection";
					labelMode.ForeColor = Color.Purple;
					ResetTextFields();
					listBoxDataBaseTable.Items.Clear();

					buttonNew.Enabled = false;
					buttonDelete.Enabled = false;
					listBoxDataBaseTable.Enabled = false;
					buttonCancel.Enabled = false;
					buttonSave.Enabled = false;
					groupBoxInputEntry.Enabled = false;
					break;

				default:
					throw new Exception("case mismatch error");
			}
		}

		///validates input provided by the user inside each textbox as to ensure the right data is entered
		private bool ValidateInputEntry() {
			if (String.IsNullOrEmpty(manufacturerTextBox.Text)) {
				MessageBox.Show("Please enter a manufacturer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			} else if (String.IsNullOrEmpty(modelTextBox.Text)) {
				MessageBox.Show("Please enter a model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			} else if (colorTextBox.Text.HasNumber()) {
				MessageBox.Show("Please enter a color in text format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			} else if (String.IsNullOrEmpty(colorTextBox.Text)) {
				MessageBox.Show("Please enter a color.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			} else if (engineSizeTextBox.Text.HasAlpha()) {
				MessageBox.Show("Please enter a numeric value for your engine size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			} else if (String.IsNullOrEmpty(engineSizeTextBox.Text)) {
				MessageBox.Show("Please enter an engine size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			} else {
				return true;
			}
		}

		///clears all textfields and checkboxes
		private void ResetTextFields() {
			manufacturerTextBox.Text = String.Empty;
			modelTextBox.Text = String.Empty;
			colorTextBox.Text = String.Empty;
			petrolCheckBox.Checked = false;
			engineSizeTextBox.Text = String.Empty;
		}

		///inserts the newly entered data from inside the input fields as a new row of the database
		private void SaveNew() {
			if (ValidateInputEntry()) {
				StringBuilder sb = new StringBuilder();
				sb.Append("INSERT INTO Cars([Manufacturer], [Model], [Color], [Petrol], [EngineSize]) VALUES ");
				sb.Append("(");
				sb.Append("'" + manufacturerTextBox.Text + "', ");
				sb.Append("'" + modelTextBox.Text + "', ");
				sb.Append("'" + colorTextBox.Text + "', ");
				sb.Append(petrolCheckBox.Checked + ", ");
				sb.Append(engineSizeTextBox.Text);
				sb.Append(")");

				connection.SQLQuery(sb.ToString());

				MessageBox.Show("Entry Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				PopulateListBox();
				listBoxDataBaseTable.TopIndex = listBoxDataBaseTable.Items.Count - 1;

				ResetTextFields();
			}
		}

		///updates the selected row of the database with the new edits provided
		private void SaveChanges() {
			if (CheckForChanges()) {
				if (ValidateInputEntry()) {
					if (ConfirmationBox.Show("Are you sure you wish to make these changes?")) {
						StringBuilder sb = new StringBuilder();
						sb.Append("UPDATE Cars SET ");
						sb.Append("[Manufacturer] = '" + manufacturerTextBox.Text + "', ");
						sb.Append("[Model] = '" + modelTextBox.Text + "', ");
						sb.Append("[Color] = '" + colorTextBox.Text + "', ");
						sb.Append("[Petrol] = " + petrolCheckBox.Checked + ", ");
						sb.Append("[EngineSize] = " + engineSizeTextBox.Text + " ");

						DataTable table = connection.GetTable();

						sb.Append("WHERE ");
						sb.Append("[OrderNumber] = " + table.Rows[listBoxDataBaseTable.SelectedIndex][0].ToString());

						connection.SQLQuery(sb.ToString());

						MessageBox.Show("Changes Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

						PREVIOUSLY_SELECTED_ROW = listBoxDataBaseTable.SelectedIndex;

						PopulateListBox();
						listBoxDataBaseTable.TopIndex = PREVIOUSLY_SELECTED_ROW;

						SwitchMode(EditMode.VIEW_MODE);
					} else {
						SwitchMode(EditMode.VIEW_MODE);
					}
				}
			} else {
				MessageBox.Show("No changes were found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		///checks whether the user has made changes to the selected row
		private bool CheckForChanges() {
			StringBuilder sb = new StringBuilder();

			DataTable table = connection.GetTable();

            //TODO: fix tabbing
			sb.Append(table.Rows[listBoxDataBaseTable.SelectedIndex][0].ToString() + "\t");
			sb.Append(manufacturerTextBox.Text + "\t");
			sb.Append(modelTextBox.Text + "\t");
			sb.Append(colorTextBox.Text + "\t");
			sb.Append(petrolCheckBox.Checked + "\t");
			sb.Append(engineSizeTextBox.Text + "\t");

			return !( sb.ToString() == listBoxDataBaseTable.SelectedItem.ToString() );
		}
		#endregion

		#region Form1 Button Events
		//used for quitting the application
		private void toolStripMenuItemQuit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		//used for displaying help.txt
		private void toolStripMenuItemAbout_Click(object sender, EventArgs e) {
			FileReader.Read(Application.StartupPath + @"\resources\help.txt");
		}

		//used for populating the various text fields and checkboxes
		private void listBoxDataBaseTable_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				FillInputBoxes();
			} catch (Exception err) {
				SwitchMode(EditMode.NO_CONNECTION);
				MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//prompts the user whehter they wish to delete their selected row from the database
		private void buttonDelete_Click(object sender, EventArgs e) {
			try {
				if (ConfirmationBox.Show("Do you really want to Delete this Record?")) {
					StringBuilder sb = new StringBuilder();
					sb.Append("DELETE FROM Cars WHERE [OrderNumber]=");

					DataTable table = connection.GetTable();
					sb.Append(table.Rows[listBoxDataBaseTable.SelectedIndex][0].ToString());

					PREVIOUSLY_SELECTED_ROW = listBoxDataBaseTable.SelectedIndex;

					connection.SQLQuery(sb.ToString());

					PopulateListBox();

                    //moves the selected item to the item directly below the now deleted item
                    if (listBoxDataBaseTable.Items.Count > 0) { 
						if (listBoxDataBaseTable.Items.Count >= PREVIOUSLY_SELECTED_ROW + 1) {
							listBoxDataBaseTable.SelectedIndex = PREVIOUSLY_SELECTED_ROW;
						} else {
							listBoxDataBaseTable.SelectedIndex = listBoxDataBaseTable.Items.Count - 1;
						}
						FillInputBoxes();
					} else {
						SwitchMode(EditMode.VIEW_MODE);
					}

					MessageBox.Show("Record Successfully Deleted", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			} catch (Exception err) {
				SwitchMode(EditMode.NO_CONNECTION);
				MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//used for changing the mode to NEW_MODE
		private void buttonNew_Click(object sender, EventArgs e) {
			try {
				SwitchMode(EditMode.NEW_MODE);
			} catch (Exception err) {
				SwitchMode(EditMode.NO_CONNECTION);
				MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//used for saving new entries and edits to the database
		private void buttonSave_Click(object sender, EventArgs e) {
			try {
                //checks what mode the program is currently in
                switch (mode) { 
					case EditMode.NEW_MODE:
						SaveNew();
						break;
					case EditMode.EDIT_MODE:
						SaveChanges();
						break;
					default:
						throw new Exception("case mismatch error");
				}
			} catch (Exception err) {
				SwitchMode(EditMode.NO_CONNECTION);
				MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//used for returning the mode to VIEW_MODE
		private void buttonCancel_Click(object sender, EventArgs e) {
			try {
				SwitchMode(EditMode.VIEW_MODE);
			} catch (Exception err) {
				SwitchMode(EditMode.NO_CONNECTION);
				MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        #endregion
    }
}