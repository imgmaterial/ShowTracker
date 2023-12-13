using System.Diagnostics;

namespace mauModule7
{
    public partial class MainForm : Form
    {

        private ShowManager showManager;

        public MainForm()
        {
            InitializeComponent();
            showManager = new ShowManager();
        }

        private void UpdateGUI()
        {
            lstShowEntries.Items.Clear();
            List<Show> showList = showManager.ShowList;
            int listLength = showList.Count;
            Debug.WriteLine("pepega");
            for (int i = 0; i < listLength; i++)
            {
                Debug.WriteLine(showList[i].Title);
                lstShowEntries.Items.Add(showManager.GenerateEntryStringRepresentation(i));
            }
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
    }
}