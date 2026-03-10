/*
 * Statement of Authorship:
 * I, Mahtabin Tushi, 000952184 certify that this material is my original work.
 * No other person's work has been used without due acknowledgment
 * and I have not made my work available to anyone else.
 * Date: 2 December,2025
 */

/// <summary>
/// Represents an episode from the Doctor Who-like series, containing information 
/// about the episode's story ID, season number, season year, and title.
/// </summary>
public class Episode
{
    /// <summary>
    /// Gets or sets the StoryID, a unique identifier for the episode's story.
    /// </summary>
    public string StoryID { get; set; }

    /// <summary>
    /// Gets or sets the Season number of the episode
    /// </summary>
    public int Season { get; set; }

    /// <summary>
    /// Gets or sets the SeasonYear, indicating the year in which the episode's season was released.
    /// </summary>
    public int SeasonYear { get; set; }

    /// <summary>
    /// Gets or sets the Title of the episode 
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Initializes a new instance of the class with the provided 
    /// story ID, season number, season year, and episode title.
    /// </summary>
    /// <param name="storyID">The unique identifier for the episode's story.</param>
    /// <param name="season">The season number to which the episode belongs.</param>
    /// <param name="seasonYear">The year the season was released.</param>
    /// <param name="title">The title of the episode.</param>
    public Episode(string storyID, int season, int seasonYear, string title)
    {
        StoryID = storyID;
        Season = season;
        SeasonYear = seasonYear;
        Title = title;
    }
}
