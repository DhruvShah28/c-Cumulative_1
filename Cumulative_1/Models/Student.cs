﻿namespace Cumulative_1.Models
{

    // Created a Student Class that defines different properties of the Student table
    // This definition is used to create different objects for each row in that table
    // The properties of that each object is then accessed and are sent to view to display on the respective webpages
    // Here, Student 'Class' has 5 properties (S_Id, S_FName, S_LName, S_Num, S_E_Date)
    // these are accessed by Controllers and then retrived to View to display that properties information on the web page
    public class Student
    {
        // Unique identifier for each student. It is used as the primary key in a database.
        public int S_Id { get; set; }

        // First name of the student. It stores the student's first name as a string.
        public string S_FName { get; set; }

        // Last name of the student. It stores the student's last name as a string.
        public string S_LName { get; set; }

        // The student roll number. it is stored as string.
        public string S_Num { get; set; }

        // The date when the Student was enrolled. It is Stored as DateTime.
        public DateTime S_E_Date { get; set; }
    }
}