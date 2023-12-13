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
		return showName;
	}
}
