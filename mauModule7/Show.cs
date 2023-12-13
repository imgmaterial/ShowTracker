using System;

public class Show
{
	private string title;
	private ShowType type;
	private WatchStatus status;
	private int maxEpsiodes;
	private int currentEpisodes;
	private double userScore;

	public Show(string title, ShowType type, WatchStatus status, int maxEpisodes, int currentEpisodes,double userScore )
	{
		this.title = title;
		this.type = type;
		this.status = status;
		this.maxEpsiodes = maxEpisodes;
		this.currentEpisodes = currentEpisodes;
		this.userScore = userScore;
	}

	public Show(string title, ShowType type, WatchStatus status, int maxEpisodes):this(title, type, status, maxEpisodes, 0, 0) 
	{
		if (status == WatchStatus.Complete)
		{
			currentEpisodes = maxEpisodes;
		}
	}

	public Show(string title, ShowType type, WatchStatus status):this(title, type, status, 0)
	{
		if (type == ShowType.Film)
		{
			maxEpsiodes=1;
		}

		if (status == WatchStatus.Complete)
		{
			currentEpisodes = maxEpsiodes;
		}
	}
}
