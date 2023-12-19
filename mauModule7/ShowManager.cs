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

	public void AddShow(Show show)
	{
		if (show != null)
		{
			showList.Add(show);
		}
	}

	public void RemoveShow(int index) 
	{
		if (ValidateIndex(index)) 
		{
			showList.RemoveAt(index);
		}
	}

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
}
