using System;
using System.CodeDom.Compiler;

public class ListSummary
{
	public int FilmWatched{ get; set; }
	public int SeriesWatched{ get; set; }
	public int TotalShows{ get; set; }

	public int SeriesEpisodesWatched{ get; set; }
	public int SeriesEpisodesTotal{ get; set; }

	public double AverageScore{ get; set; }

	public int SeriesPlanned{ get; set; }
	public int SeriesCompleted{ get; set; }
	public int SeriesDropped{ get; set; }
	public int SeriesWatching{ get; set; }

    public int FilmsPlanned{ get; set; }
    public int FilmsCompleted{ get; set; }
    public int FilmsDropped{ get; set; }
    public int FilmsWatching{ get; set; }
	/// <summary>
	/// Generate a string representation of the summary.
	/// </summary>
	/// <returns>string summary</returns>
	public string GenerateSummaryString()
	{
		string summary = string.Format("Total amount of shows in the list {0}.\n" +
			"Films added to the list {1}\n" +
			"Series added to the lsit {2}\n" +
			"Series episodes watched {3}/{4}\n" +
			"Series planned {5}\n" +
			"Series watching {6}\n" +
			"Series completed {7}\n" +
			"Series dropped {8}\n" +
			"Films planned {9}\n" +
			"Films watching {10}\n" +
			"Films completed {11}\n" +
			"Films dropped {12}\n" +
			"Average score of a show {13:f2}\n",TotalShows, FilmWatched, SeriesWatched,SeriesEpisodesWatched, SeriesEpisodesTotal, SeriesPlanned,
			SeriesWatching, SeriesCompleted, SeriesDropped, FilmsPlanned, FilmsWatching, FilmsCompleted, FilmsDropped, AverageScore);
		return summary;
	}
}
