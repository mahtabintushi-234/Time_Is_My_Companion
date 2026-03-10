/*
 * Statement of Authorship:
 * I, Mahtabin Tushi, 000952184 certify that this material is my original work.
 * No other person's work has been used without due acknowledgment
 * and I have not made my work available to anyone else.
 * Date: 2 December,2025
 */


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab5b
{   
    /// <summary>
    /// The main form for the Lab5b application, which interacts with the database to 
    /// display and manage information about doctors, companions, and episodes from a 
    /// Doctor Who-like database system. It loads data from SQL Server tables, populates 
    /// combo boxes, and handles interactions between doctors and their companions.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Connection string to the SQL Server database.
        /// </summary>
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True";

        /// <summary>
        /// List of Doctor objects retrieved from the database.
        /// </summary>
        private List<Doctor> doctors = new List<Doctor>();

        /// <summary>
        /// List of Companion objects retrieved from the database.
        /// </summary>
        private List<Companion> companions = new List<Companion>();

        /// <summary>
        /// List of Episode objects retrieved from the database.
        /// </summary>
        private List<Episode> episodes = new List<Episode>();

        /// <summary>
        /// Initializes the form, loads the data from the database tables, 
        /// and populates the doctor selection combo box.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            LoadAllTables();
            PopulateDoctorComboBox();
        }

        /// <summary>
        /// Loads the data from the three main tables (Doctors, Companions, and Episodes) 
        /// in the database using SQL queries and populates the corresponding lists.
        /// </summary>
        private void LoadAllTables()
        {
            LoadDoctors();
            LoadCompanionsTable();
            LoadEpisodesTable();
        }

        /// <summary>
        /// Loads data from the DOCTOR table, including the actor, series, age, and the first appearance year 
        /// of each doctor. This data is used to populate the 'doctors' list.
        /// </summary>
        private void LoadDoctors()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to fetch doctor details including the first appearance year
                string query = @"
                    SELECT d.DoctorID, d.Actor, d.Series, d.Age, MIN(e.SeasonYear) AS FirstYear, d.Picture
                    FROM DOCTOR d
                    JOIN COMPANION c ON d.DoctorID = c.DoctorID
                    JOIN EPISODE e ON c.StoryID = e.StoryID
                    GROUP BY d.DoctorID, d.Actor, d.Series, d.Age, d.Picture
                    ORDER BY d.DoctorID";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Read the results and add each doctor to the list
                while (reader.Read())
                {
                    byte[] photo = reader["Picture"] as byte[];
                    Image image = null;

                    if (photo != null)
                        image = Image.FromStream(new MemoryStream(photo));

                    Doctor d = new Doctor(
                        (int)reader["DoctorID"],
                        reader["Actor"].ToString(),
                        (int)reader["FirstYear"],
                        (int)reader["Series"],
                        (int)reader["Age"],
                        image
                    );

                    doctors.Add(d);
                }
            }
        }

        /// <summary>
        /// Loads the COMPANION table to get companion details (name, actor, doctor ID, story ID) 
        /// and populates the 'companions' list.
        /// </summary>
        private void LoadCompanionsTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to fetch companion details
                string query = "SELECT Name, Actor, DoctorID, StoryID FROM COMPANION";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Read the results and add each companion to the list
                while (reader.Read())
                {
                    companions.Add(new Companion(
                        reader["Name"].ToString(),
                        reader["Actor"].ToString(),
                        (int)reader["DoctorID"],
                        reader["StoryID"].ToString()
                    ));
                }
            }
        }

        /// <summary>
        /// Loads the EPISODE table to get episode details (story ID, season, season year, title) 
        /// and populates the 'episodes' list.
        /// </summary>
        private void LoadEpisodesTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to fetch episode details
                string query = "SELECT StoryID, Season, SeasonYear, Title FROM EPISODE";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Read the results and add each episode to the list
                while (reader.Read())
                {
                    episodes.Add(new Episode(
                        reader["StoryID"].ToString(),
                        (int)reader["Season"],
                        (int)reader["SeasonYear"],
                        reader["Title"].ToString()
                    ));
                }
            }
        }

        /// <summary>
        /// Populates the combo box with the list of available doctors.
        /// </summary>
        private void PopulateDoctorComboBox()
        {
            DoctorComboBox.Items.Clear();
            foreach (Doctor d in doctors)
                DoctorComboBox.Items.Add(d);
        }

        /// <summary>
        /// Handles the event when a doctor is selected from the combo box. It displays the 
        /// corresponding information about the selected doctor and loads their companions.
        /// </summary>
        private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor selected = (Doctor)DoctorComboBox.SelectedItem;
            if (selected == null) return;

            // Display the selected doctor's details
            DisplayDoctorInfo(selected);

            // Load companions for the selected doctor
            LoadCompanionsForDoctor(selected.DoctorID);
        }

        /// <summary>
        /// Displays the selected doctor's information in textboxes and a picture box. 
        /// This includes the actor's name, first appearance year, series number, age, 
        /// and their first episode's title.
        /// </summary>
        private void DisplayDoctorInfo(Doctor doctor)
        {
            ActorTextBox.Text = doctor.Actor;
            YearTextBox.Text = doctor.Year.ToString();       // first appearance year
            SeriesTextBox.Text = doctor.Series.ToString();
            AgeTextBox.Text = doctor.AgeAtStart.ToString();
            DoctorPictureBox.Image = doctor.Picture;
            FirstEpisodeTextBox.Text = GetFirstEpisodeTitle(doctor.DoctorID);
        }

        /// <summary>
        /// Retrieves the title of the first episode for a specific doctor based on the DoctorID.
        /// </summary>
        /// <param name="doctorID">The ID of the doctor for whom the first episode title is retrieved.</param>
        /// <returns>The title of the first episode, or "N/A" if no episodes are found.</returns>
        private string GetFirstEpisodeTitle(int doctorID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to get the first episode title for the given doctor
                string query = @"
                    SELECT TOP 1 e.Title
                    FROM COMPANION c
                    INNER JOIN EPISODE e ON c.StoryID = e.StoryID
                    WHERE c.DoctorID = @DoctorID
                    ORDER BY e.SeasonYear ASC;
                ";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                object result = cmd.ExecuteScalar();

                return result == null ? "N/A" : result.ToString();
            }
        }

        /// <summary>
        /// Loads the companions and episodes for a specific doctor and populates a list box 
        /// with the companion name, actor, episode title, and the year of the episode.
        /// </summary>
        /// <param name="doctorID">The ID of the doctor for whom companions and episodes are loaded.</param>
        private void LoadCompanionsForDoctor(int doctorID)
        {
            CompanionsListBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to get companions and episodes for a specific doctor
                string query = @"
                    SELECT c.Name, c.Actor, e.Title, e.SeasonYear
                    FROM COMPANION c
                    INNER JOIN EPISODE e ON c.StoryID = e.StoryID
                    WHERE c.DoctorID = @DoctorID
                    ORDER BY e.SeasonYear;
                ";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                SqlDataReader reader = cmd.ExecuteReader();

                // Populate the list box with companions and their corresponding episodes
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string actor = reader["Actor"].ToString();
                    string title = reader["Title"].ToString();
                    int year = (int)reader["SeasonYear"];

                    CompanionsListBox.Items.Add(
                        $"{name} ({actor}) \n {title} ({year})"
                    );
                }
            }
            }

        /// <summary>
        /// Handles the click event for the exit menu item. Exits the application.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

