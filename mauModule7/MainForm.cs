using System.Diagnostics;

namespace mauModule7
{
    public partial class MainForm : Form
    {

        private ShowManager showManager;
        private Show currentShow;
        private int hoverIndex = 0;
        private const string saveFileName = "ShowList.txt";

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Initializes the GUI to default values.
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Show Tracker";
            this.txtCurrentShow.Text = string.Empty;
            this.cmbWachStatus.DataSource = Enum.GetValues(typeof(WatchStatus));
            this.txtTotalEpisodes.Text = "0";
            this.numEpisodesWatched.Value = 0;
            this.numShowScore.Value = 0;
            showManager = new ShowManager();
            UpdateGUI();
        }
        /// <summary>
        /// Updates the GUI with the current values from the showManager.
        /// </summary>
        private void UpdateGUI()
        {
            lstShowEntries.Items.Clear();
            List<Show> showList = showManager.ShowList;
            int listLength = showList.Count;
            for (int i = 0; i < listLength; i++)
            {
                Debug.WriteLine(showList[i].Title);
                lstShowEntries.Items.Add(showManager.GenerateEntryStringRepresentation(i));
            }
        }
        /// <summary>
        /// Sets the values of current series group the the values of the given show.
        /// </summary>
        /// <param name="show"></param>
        private void SetCurrentShowInfo(Show show)
        {
            this.txtCurrentShow.Text = show.Title;
            this.cmbWachStatus.SelectedIndex = (int)show.Status;
            this.txtTotalEpisodes.Text = show.MaxEpisodes.ToString();
            this.numEpisodesWatched.Maximum = show.MaxEpisodes;
            this.numEpisodesWatched.Value = show.CurrentEpisodes;
            this.numShowScore.Value = (decimal)show.UserScore;
        }
        /// <summary>
        /// On Add button click opens a show entry dialogue and updates GUI if the dialog is successful. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Show show = new Show();
            ShowEntry showEntryForm = new ShowEntry(show);
            DialogResult result = showEntryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                showManager.AddShow(show);
            }
            UpdateGUI();
        }
        /// <summary>
        /// Removes a selected show from the list and updates the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstShowEntries.SelectedIndex;
            showManager.RemoveShow(index);
            UpdateGUI();
        }

        private void entryToolTip_Popup(object sender, PopupEventArgs e)
        {

        }
        /// <summary>
        /// On mouse move find the current index of item being hovered over and set its title as the current tooltip for the listbox control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstShowEntries_MouseMove(object sender, MouseEventArgs e)
        {
            int showIndex = lstShowEntries.IndexFromPoint(e.X, e.Y);
            if (showIndex == hoverIndex)
            {
                return;
            }
            if (showIndex >= 0)
            {
                entryToolTip.Active = true;
                hoverIndex = showIndex;//cashes the index that was hovered in order to avoid extra calls to showManager
                string title = showManager.ShowList[showIndex].Title;
                entryToolTip.SetToolTip(lstShowEntries, title);
            }
            else
            {
                entryToolTip.Active = false;
                hoverIndex = showIndex;
            }
        }
        /// <summary>
        /// On change of episode number control sets the values episodes watched to currently selected show.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numEpisodesWatched_ValueChanged(object sender, EventArgs e)
        {
            if (currentShow == null)
            {
                return;
            }

            currentShow.CurrentEpisodes = (int)numEpisodesWatched.Value;
            UpdateGUI();

        }
        /// <summary>
        /// On selecting a new entry in the show list sets it as the current show and updates the current show values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstShowEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstShowEntries.SelectedIndex;

            if (lstShowEntries.SelectedIndex == -1)
            {
                return;
            }
            currentShow = showManager.ShowList[selectedIndex];
            SetCurrentShowInfo(currentShow);
            lstShowEntries.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// On change of watch status sets it to the current show.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWachStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentShow == null)
            {
                return;
            }

            currentShow.Status = (WatchStatus)cmbWachStatus.SelectedIndex;
            UpdateGUI();
        }
        /// <summary>
        /// Changes the current show score.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numShowScore_ValueChanged(object sender, EventArgs e)
        {
            if (currentShow == null)
            {
                return;
            }

            currentShow.UserScore = (double)numShowScore.Value;
            UpdateGUI();
        }
        /// <summary>
        /// On save menu item selected saves the current show list into a text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = showManager.WriteDataToFile(saveFileName);
            if (!ok)
            {
                MessageBox.Show("Error during file save", "Error");
            }
            else
            {
                MessageBox.Show("Data saved to file:" + Environment.NewLine + saveFileName, "Save Successful");
            }
        }
        /// <summary>
        /// On open menu select opens a previously saved files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            bool ok = showManager.ReadDataFromFile(saveFileName);
            if (!ok)
            {
                MessageBox.Show("Error occured when trying to read file");
            }
            else
            {
                UpdateGUI();
            }
        }
        /// <summary>
        /// On new item selected re-initialize the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        /// <summary>
        /// On exit shows a dialog if yes selected closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Quit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// On change button create a new show entry dialog form with the show values initialized. On OK response change the show at the given
        /// index to the new input results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstShowEntries.SelectedIndex;
            Show show = new Show(showManager.ShowList[selectedIndex]);
            ShowEntry showEntryForm = new ShowEntry(show);
            DialogResult result = showEntryForm.ShowDialog();
            if (result == DialogResult.OK) 
            {
                showManager.ChangeAtIndex(selectedIndex, show);
            }
            UpdateGUI();
        }
    }
}