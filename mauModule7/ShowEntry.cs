using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mauModule7
{
    public partial class ShowEntry : Form
    {
        Show show;
        public ShowEntry(Show show)
        {
            InitializeComponent();
            this.show = show;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.cmbShowType.DataSource =  Enum.GetValues(typeof(ShowType));
            this.cmbWatchStatus.DataSource = Enum.GetValues(typeof(WatchStatus));
        }

        private bool ReadInputs()
        {
            bool ok = false;
            string showTitle = txtShowTitle.Text;
            if (string.IsNullOrEmpty(showTitle))
            {
                MessageBox.Show("Show title can not be an empty field", "Error");
                return ok;
            }
            show.Type = (ShowType)cmbShowType.SelectedIndex;
            show.Status = (WatchStatus)cmbWatchStatus.SelectedIndex;
            if (ReadMaxEpisodes() && ReadEpisodesWatched() && ReadUserScore()) 
            {
                ok = true; 
            }
            return ok;

        }

        private bool ReadEpisodesWatched()
        {
            int episodesWatched;
            bool ok = false;
            string episodesWatchedString = txtEpisodesWatched.Text;
            ok = int.TryParse(episodesWatchedString, out episodesWatched);
            int maxEpisodes = show.MaxEpisodes;
            if (ok && episodesWatched >= 0 && episodesWatched <= maxEpisodes)
            {
                show.CurrentEpisodes = episodesWatched;
            }
            else 
            {
                ok = false;
                MessageBox.Show("Episodes Watched should be an integer larger than 0 and lower than the value of max episodes", "Error");
            }
            return ok;
        }

        private bool ReadMaxEpisodes()
        {
            int maxEpisodes;
            bool ok = false;
            string maxEpisodesString = txtTotalEpisodes.Text;
            ok = int.TryParse(maxEpisodesString, out maxEpisodes);
            if (ok && maxEpisodes >= 0)
            {
                show.MaxEpisodes = maxEpisodes;
            }
            else
            {
                ok = false;
                MessageBox.Show("Max Epsiodes Should be an integer larger than 0", "Error");
            }
            return ok;
        }

        private bool ReadUserScore()
        {
            double userScore;
            bool ok = false;
            string userScoreString = txtUserScore.Text;
            ok = double.TryParse(userScoreString, out userScore);
            if (ok && userScore >= 0 && userScore <=10)
            {
                show.UserScore = userScore;
            }
            else
            {
                ok = false;
                MessageBox.Show("User Score should be a value between 0 and 10", "Error");
            }
            return ok;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputs();
            if (!ok) 
            {
                this.DialogResult = DialogResult.None;
            }
        }

    }
}
