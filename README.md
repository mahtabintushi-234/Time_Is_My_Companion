# Lab5b – Time is My Companion

## Author

**Mahtabin Tushi**  
Computer Systems Technology – Software Development  
Mohawk College

## Overview
**Lab5b – Time is My Companion** is a C# Windows Forms application that connects to a SQL Server database containing information about the long-running BBC series *Doctor Who*.

The application allows users to select a Doctor from a dropdown list and view information about that Doctor along with the companions who travelled with them.

The project demonstrates the use of:
- Windows Forms GUI
- SQL Server database connectivity
- C# classes and collections
- LINQ queries for data matching

---

## Features
- Windows Forms graphical interface
- Menu with **Exit** option
- Doctor selection using a **ComboBox**
- Doctor details displayed with **Labels/TextBoxes**
- Doctor image displayed using a **PictureBox**
- Companion list displayed using a **ListBox**
- Data stored in **generic List<T> collections**
- Data retrieved using **SQL queries and LINQ**

---

## Technologies Used
- C#
- .NET Framework (Windows Forms)
- SQL Server Express
- LINQ
- Microsoft SQL Server Management Studio (SSMS)

---

## Database Setup

1. Ensure **SQL Server Express (SQLEXPRESS)** is running.
2. Open **Microsoft SQL Server Management Studio (SSMS)**.
3. Download and open the provided database script.
4. Execute the script to create the database:

```
COMP10204_Lab5
```

The database contains the following tables:

- **Doctor** – Information about each Doctor, including their image.
- **Companion** – Information about companions who travelled with the Doctor.
- **Episode** – Episode and story information.

---

## Database Connection

The application connects using the following connection string:

```csharp
string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True";
```

---

## Project Structure

### Classes

#### Doctor
Represents a Doctor from the database.  
Contains properties such as:
- DoctorID
- Actor
- Series information
- StoryID
- Picture

#### Companion
Represents a companion character associated with a Doctor.

#### Episode
Stores information about episode titles and story identifiers.

Each class includes:
- Properties
- A constructor to initialize data

---

## User Interface

### Left GroupBox
- **ComboBox** for selecting a Doctor
- Labels/TextBoxes displaying Doctor information
- **PictureBox** displaying the Doctor's image

### Right GroupBox
- **ListBox** displaying companions who travelled with the selected Doctor

### Menu
- **File → Exit** to close the application

---

## Image Handling

Doctor images are stored as binary data in the database and converted to images using a `MemoryStream`.

Example:

```csharp
byte[] photo = (byte[])reader["Picture"];
MemoryStream stream = new MemoryStream(photo);
Image image = Image.FromStream(stream);
```

The image is then displayed in the PictureBox.

---

## How to Run the Application

1. Start **SQL Server Express**.
2. Run the provided SQL script to create the database.
3. Open the project in **Visual Studio**.
4. Build and run the application.
5. Select a Doctor from the ComboBox to view their information and companions.

---
