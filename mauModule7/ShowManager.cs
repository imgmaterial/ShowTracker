using System;

public class ShowManager
{
	private List<Show> showList;

	public ShowManager()
	{
		showList = new List<Show>();
	}

	public List<Show> ShowList
	{
		get { return showList; }
		set 
		{
			if (value != null)
			{
                showList = value;
            }
		}
	}
	/// <summary>
	/// Checks if the given index is valid.
	/// </summary>
	/// <param name="index"></param>
	/// <returns></returns>
	private bool ValidateIndex(int index)
	{
		int listLength = showList.Count;
		if (index >= 0 && index <= listLength)
		{
			return true;
		}
		else 
		{ 
			return false; 
		}
	}
	/// <summary>
	/// Adds a show to the list.
	/// </summary>
	/// <param name="show"></param>
	public void AddShow(Show show)
	{
		if (show != null)
		{
			showList.Add(show);
		}
	}
	/// <summary>
	/// Removes a show at an index if the index is valid.
	/// </summary>
	/// <param name="index"></param>
	public void RemoveShow(int index) 
	{
		if (ValidateIndex(index)) 
		{
			showList.RemoveAt(index);
		}
	}
	/// <summary>
	/// Changes the show at a specified index to the provided show if the index is valid.
	/// </summary>
	/// <param name="index"></param>
	/// <param name="show"></param>
	public void ChangeAtIndex(int index, Show show)
	{
		if (ValidateIndex(index))
		{
			showList[index] = show;
		}
	}
	/// <summary>
	/// Generate a descriptive string for a show at a given index.
	/// </summary>
	/// <param name="index"></param>
	/// <returns></returns>
	public string GenerateEntryStringRepresentation(int index)
	{
		string showName = showList[index].Title;
		if (showName.Length >= 44)
		{
			showName = showName.Substring(0,40) + "...";
		}
		string showType = showList[index].Type.ToString();
		string watchStatus = showList[index].Status.ToString();
		string progress = string.Format("{0}/{1}", showList[index].CurrentEpisodes, showList[index].MaxEpisodes);
		string userScore = showList[index].UserScore.ToString();
		string stringRepresentation = string.Format("{0,-45}{1, -10}{2, -10}{3,-14}{4,-6}", showName, showType, watchStatus, progress, userScore);
		return stringRepresentation;
	}
	/// <summary>
	/// Collect information from the show list into a ListSummary and returns a string representation of all the information present in the list.
	/// </summary>
	/// <returns>string summary</returns>
	public string GenerateUserSummary()
	{
		ListSummary summary = new ListSummary();
        double totalScore = 0;
		summary.TotalShows = showList.Count;
        foreach (var show in showList) 
		{
			if (show.Status != WatchStatus.Planned)
			{
                totalScore += show.UserScore;
            }
			switch (show.Type)
			{
				case ShowType.Film:
					summary.FilmWatched += 1;

					switch (show.Status)
					{
						case WatchStatus.Planned:
							summary.FilmsPlanned += 1;
							break;
						case WatchStatus.Completed:
							summary.FilmsCompleted += 1;
							break;
						case WatchStatus.Watching:
							summary.FilmsWatching += 1;
							break;
						case WatchStatus.Dropped:
							summary.FilmsDropped += 1;
							break;
					}

					break;
				case ShowType.Series:
					summary.SeriesWatched += 1;
					summary.SeriesEpisodesWatched += show.CurrentEpisodes;
					summary.SeriesEpisodesTotal += show.MaxEpisodes;
                    switch (show.Status)
                    {
                        case WatchStatus.Planned:
                            summary.SeriesPlanned += 1;
                            break;
                        case WatchStatus.Completed:
                            summary.SeriesCompleted += 1;
                            break;
                        case WatchStatus.Watching:
                            summary.SeriesWatching += 1;
                            break;
                        case WatchStatus.Dropped:
                            summary.SeriesDropped += 1;
                            break;
                    }
                    break;
				
			}
		}
        summary.AverageScore = totalScore / summary.TotalShows;
		return summary.GenerateSummaryString();
    }


	/// <summary>
	/// Reads data from a file into the show list.
	/// </summary>
	/// <param name="fileName"></param>
	/// <returns></returns>
    public bool ReadDataFromFile(string fileName)
    {
        FileManager fileManager = new FileManager();
        return fileManager.ReadFromTextFile(showList, fileName);
    }
	/// <summary>
	/// Writes the show list to a text file.
	/// </summary>
	/// <param name="fileName"></param>
	/// <returns></returns>
	public bool WriteDataToFile(string fileName)
	{
        FileManager fileManager = new FileManager();
		return fileManager.WriteToTextFile(showList,fileName);
    }
}
