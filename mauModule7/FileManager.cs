using System;
using System.Diagnostics;

public class FileManager
{
    private const string fileVersionToken = "ShowTracker_01";
    private const double fileVersionNr = 1.0;

    /// <summary>
    /// Writes the entries from the provided show to a text file with given name. Returns true if the save was successful.
    /// </summary>
    /// <param name="showList"></param>
    /// <param name="textFile"></param>
    /// <returns>bool ok</returns>
	public bool WriteToTextFile(List<Show> showList,string textFile) 
	{
        bool ok = true;
        StreamWriter? writer = null;
        try
        {
            int listLength = showList.Count;
            writer = new StreamWriter(textFile);
            writer.WriteLine(fileVersionToken);
            writer.WriteLine(fileVersionNr);
            writer.WriteLine(listLength);
            for (int i = 0; i < listLength; i++)
            {
                Show show = showList[i];
                writer.WriteLine(show.Title);
                writer.WriteLine(show.Type.ToString());
                writer.WriteLine(show.Status.ToString());
                writer.WriteLine(show.MaxEpisodes);
                writer.WriteLine(show.CurrentEpisodes);
                writer.WriteLine(show.UserScore);
            }
        }
        catch
        {
            ok = false;
        }
        finally
        {
            if (writer != null)
            {
                writer.Close();
            }
        }
        return ok;
    }
    /// <summary>
    /// Reads the values from an existing save file to a show list. Returns true if reading was successful.
    /// </summary>
    /// <param name="showList"></param>
    /// <param name="textFile"></param>
    /// <returns>bool ok</returns>
    public bool ReadFromTextFile(List<Show> showList, string textFile)
	{
        bool ok = true;
        StreamReader reader = null;

        try
        {
            if (showList != null)
            {
                showList.Clear();
            }
            else
            {
                showList = new List<Show>();
            }

            reader = new StreamReader(textFile);
            string versionTest = reader.ReadLine();
            double version = double.Parse(reader.ReadLine());
            if ((versionTest == fileVersionToken) && (version == fileVersionNr))
            {
                int count = int.Parse(reader.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Show show = new Show();
                    show.Title = reader.ReadLine();
                    show.Type = (ShowType)Enum.Parse(typeof(ShowType), reader.ReadLine());
                    show.Status = (WatchStatus)Enum.Parse(typeof(WatchStatus), reader.ReadLine());
                    show.MaxEpisodes = int.Parse(reader.ReadLine());
                    show.CurrentEpisodes = int.Parse(reader.ReadLine());
                    show.UserScore = double.Parse(reader.ReadLine());
                    showList.Add(show);
                }
            }
            else
            {
                ok = false;
            }
        }
        catch
        {
            ok = false;
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
            }
        }
        return ok;
    }

	
}
