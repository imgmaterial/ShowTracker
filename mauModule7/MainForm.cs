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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Show show = new Show();
            ShowEntry showEntryForm = new ShowEntry(show);
            DialogResult result = showEntryForm.ShowDialog();
        }
    }
}