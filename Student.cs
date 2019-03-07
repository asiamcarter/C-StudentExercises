

using System.Collections.Generic;

namespace C_StudentExercises
{
    public class Student
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string SlackHandle {get;set;}
        public string CohortName {get;set;}
        public List<Exercise> ExerciseList {get;set;}

        public Student(string firstName, string lastName, string slackHandle) {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            ExerciseList = new List<Exercise>();
        }
    }
}
