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
}
