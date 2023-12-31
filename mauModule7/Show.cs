﻿using System;

public class Show
{
	private string title;
	private ShowType type;
	private WatchStatus status;
	private int maxEpisodes;
	private int currentEpisodes;
	private double userScore;

	public Show(string title, ShowType type, WatchStatus status) 
	{
		this.title = title;
		this.type = type;
		this.status = status;
		this.maxEpisodes = 0;
		this.currentEpisodes = 0;
		this.userScore = 0;
	}

	public Show():this(string.Empty, ShowType.Film, WatchStatus.Planned) 
	{
		
	}

	public Show(Show other)
	{
        this.title = other.Title;
        this.type = other.Type;
        this.status = other.Status;
        this.maxEpisodes = other.MaxEpisodes;
        this.currentEpisodes = other.CurrentEpisodes;
        this.userScore = other.UserScore;
    }

	public string Title
	{
		get { return this.title; } 
		set 
		{
			if (!string.IsNullOrEmpty(value)) 
			{
				this.title = value;
			}
		}
	}

	public int CurrentEpisodes
	{
		get { return this.currentEpisodes; }
		set
		{
			if (value >= 0) 
			{
				this.currentEpisodes = value;
			}
		}
	}

	public ShowType Type
	{
		get { return this.type; }
		set { this.type = value; }
	}

	public WatchStatus Status
	{
		get { return this.status; }
		set { this.status = value; } 
	}

	public int MaxEpisodes
	{
		get { return this.maxEpisodes; }
		set 
		{
			if (value >= 0)
			{
				this.maxEpisodes = value;
			}
		}
	}

	public double UserScore
	{
		get { return this.userScore; }
		set 
		{
			if (value >= 0)
			{
				this.userScore = value;
			}
		}
	}
}
