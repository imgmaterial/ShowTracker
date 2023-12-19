using System.Diagnostics;

namespace mauModule7
{
    public partial class MainForm : Form
    {

        private ShowManager showManager;
        private Show currentShow;
        private int hoverIndex = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            showManager = new ShowManager();
        }

        private void InitializeGUI()
        {
            this.Text = "Show Tracker";
            this.txtCurrentShow.Text = string.Empty;
            this.cmbWachStatus.DataSource = Enum.GetValues(typeof(WatchStatus));
            this.txtTotalEpisodes.Text = "0";
            this.numEpisodesWatched.Value = 0;
            this.numShowScore.Value = 0;
        }

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

        private void SetCurrentShowInfo(Show show)
        {
            this.txtCurrentShow.Text = show.Title;
            this.cmbWachStatus.SelectedIndex = (int)show.Status;
            this.txtTotalEpisodes.Text = show.MaxEpisodes.ToString();
            this.numEpisodesWatched.Maximum = show.MaxEpisodes;
            this.numEpisodesWatched.Value = show.CurrentEpisodes;
            this.numShowScore.Value = (decimal)show.UserScore;
        }

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

        private void numEpisodesWatched_ValueChanged(object sender, EventArgs e)
        {
            if (currentShow == null)
            {
                return;
            }

            currentShow.CurrentEpisodes = (int)numEpisodesWatched.Value;
            UpdateGUI();

        }

        private void lstShowEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstShowEntries.SelectedIndex;

            if (lstShowEntries.SelectedIndex == -1)
            {
                return;
            }
            currentShow = showManager.ShowList[selectedIndex];
            SetCurrentShowInfo(currentShow);
        }

        private void cmbWachStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentShow == null)
            {
                return;
            }

            currentShow.Status = (WatchStatus)cmbWachStatus.SelectedIndex;
            UpdateGUI();
        }

        private void numShowScore_ValueChanged(object sender, EventArgs e)
        {
            if (currentShow == null) 
            {
                return;
            }

            currentShow.UserScore = (double)numShowScore.Value;
            UpdateGUI();
        }
    }
}