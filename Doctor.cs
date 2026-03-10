/*
 * Statement of Authorship:
 * I, Mahtabin Tushi,000952184 certify that this material is my original work.
 * No other person's work has been used without due acknowledgment
 * and I have not made my work available to anyone else.
 * Date: 3 December,2025
 */

using System.IO;
using System.Drawing;

/// <summary>
/// Represents a Doctor in the Doctor Who-like series, containing information about the 
/// doctor's unique ID, the actor who portrays them, the year of their first appearance, 
/// their series number, the age at the start of their journey, and their portrait image.
/// </summary>
public class Doctor
{
    /// <summary>
    /// Gets or sets the unique identifier for the doctor.
    /// </summary>
    public int DoctorID { get; set; }

    /// <summary>
    /// Gets or sets the name of the actor who portrays the doctor.
    /// </summary>
    public string Actor { get; set; }

    /// <summary>
    /// Gets or sets the year in which the doctor first appeared in the series.
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the series number the doctor belongs to.
    /// </summary>
    public int Series { get; set; }

    /// <summary>
    /// Gets or sets the doctor's age at the time of their first appearance in the series.
    /// </summary>
    public int AgeAtStart { get; set; }

    /// <summary>
    /// Gets or sets the doctor's portrait image.
    /// </summary>
    public Image Picture { get; set; }

    /// <summary>
    /// Initializes a new instance of the class with the specified 
    /// doctor ID, actor name, first appearance year, series number, starting age, and portrait.
    /// </summary>
    /// <param name="id">The unique identifier for the doctor.</param>
    /// <param name="actor">The name of the actor who portrays the doctor.</param>
    /// <param name="year">The year the doctor first appeared in the series.</param>
    /// <param name="series">The series number the doctor belongs to.</param>
    /// <param name="age">The doctor's age at the time of their first appearance.</param>
    /// <param name="picture">The doctor's portrait image.</param>
    public Doctor(int id, string actor, int year, int series, int age, Image picture)
    {
        DoctorID = id;
        Actor = actor;
        Year = year;
        Series = series;
        AgeAtStart = age;
        Picture = picture;
    }

    /// <summary>
    /// Returns a string representation of the doctor, displaying their unique DoctorID.
    /// </summary>
    /// <returns>A string representing the DoctorID of the doctor.</returns>
    public override string ToString()
    {
        return DoctorID.ToString();
    }
}
