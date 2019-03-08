using System;
using System.Collections.Generic;

namespace C_StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise exercise1 = new Exercise("Exercise 1", "JavaScript");
            Exercise exercise2 = new Exercise("Exercise 2", "C#");
            Exercise exercise3 = new Exercise("Exercise 3", "ReactJS");
            Exercise exercise4 = new Exercise("Exercise 4", "Python");


            // Create 3, or more, cohorts.
            Cohort Cohort1 = new Cohort();
            Cohort1.CohortName = "Cohort 1";
            Cohort Cohort2 = new Cohort();
            Cohort2.CohortName = "Cohort 2";
            Cohort Cohort3 = new Cohort();
            Cohort3.CohortName = "Cohort 3";

            // Create 4, or more, students and assign them to one of the cohorts.
            Student Nick = new Student("Nick", "Hansen", "@therealnick"
            );
            Nick.CohortName= "29";
            Cohort1.StudentList.Add(Nick);
            // Cohort1.StudentList.Add(Nick);

            Student Hunter = new Student("Hunter", "Metts", "endlesssummerhd");
            Cohort2.StudentList.Add(Hunter);
            Student Jordan = new Student ("Jordan", "Rosas", "@polyglotboy");
            Cohort3.StudentList.Add(Jordan);
            Student Cole = new Student("Cole", "Bryant", "crossfitguru29");
            Cohort1.StudentList.Add(Cole);

            // Create 3, or more, instructors and assign them to one of the cohorts.

            Instructor Jisie = new Instructor("Jisie", "David", "jjdavid", Cohort1);
            Cohort1.InstructorList.Add(Jisie);

            Instructor Andy = new Instructor("Andy", "Collins", "askingalot", Cohort2);
            Cohort2.InstructorList.Add(Andy);

            Instructor Leah = new Instructor("Leah", "Gwin", "leahgwin22", Cohort3);
             Cohort3.InstructorList.Add(Leah);

            // Have each instructor assign 2 exercises to each of the students.

            Jisie.AssignStudents(Cohort1, exercise1);
            Jisie.AssignStudents(Cohort1, exercise2);
            Andy.AssignStudents(Cohort2, exercise1);
            Andy.AssignStudents(Cohort2, exercise3);
            Leah.AssignStudents(Cohort3, exercise2);
            Leah.AssignStudents(Cohort3, exercise4);

            // Create a list of students. Add all of the student instances to it.
            List<Cohort> CohortList = new List<Cohort>() {
                Jisie.CohortName, Andy.CohortName, Leah.CohortName
            };
            List<Student> StudentList = new List<Student>();
            List<Exercise> ExerciseList = new List<Exercise>();

            foreach(Cohort cohortname in CohortList) {
                foreach(Student student in cohortname.StudentList) {
                    StudentList.Add(student);
                    // Console.WriteLine(student.FirstName);
                foreach(Exercise exercise in student.ExerciseList) {
                    // Console.WriteLine(exercise.ExerciseName);
                    ExerciseList.Add(exercise);

                Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.ExerciseName}");
                }
                }

            }



        }
    }
}
