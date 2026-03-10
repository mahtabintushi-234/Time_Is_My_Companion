/*
 * Statement of Authorship:
 * I, Mahtabin Tushi,000952184 certify that this material is my original work.
 * No other person's work has been used without due acknowledgment
 * and I have not made my work available to anyone else.
 * Date: 2 December ,2025
 */

/// <summary>
/// Represents a companion of a Doctor, containing information about the companion's 
/// name, the actor who portrays them, the associated Doctor's ID, and the StoryID 
/// that connects the companion to a particular episode or story in the series.
/// </summary>
public class Companion
{
    /// <summary>
    /// Gets or sets the Name of the companion.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the Actor's name who portrays the companion.
    /// </summary>
    public string Actor { get; set; }

    /// <summary>
    /// Gets or sets the Doctor's ID that the companion is associated with.
    /// </summary>
    public int DoctorID { get; set; }

    /// <summary>
    /// Gets or sets the StoryID, which links the companion to a particular episode or story.
    /// </summary>
    public string StoryID { get; set; }

    /// <summary>
    /// Initializes a new instance of the  class with the provided 
    /// name, actor, DoctorID, and StoryID.
    /// </summary>
    /// <param name="name">The name of the companion .</param>
    /// <param name="actor">The name of the actor who plays the companion .</param>
    /// <param name="doctorID">The ID of the Doctor that the companion is associated with.</param>
    /// <param name="storyID">The ID of the story or episode in which the companion appears.</param>
    public Companion(string name, string actor, int doctorID, string storyID)
    {
        Name = name;
        Actor = actor;
        DoctorID = doctorID;
        StoryID = storyID;
    }
}
