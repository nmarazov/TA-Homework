namespace School.Model
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Common;

    public class Student : IStudent
    {
        private int id;
        private string name;
        private ICollection<ICourse> courses;

        public Student(string name, ISchool school)
        {
            Validator.NullCheck(school, "School");

            this.Id = school.GenerateStudentId();
            this.courses = new List<ICourse>();
            this.Name = name;
            school.AddStudent(this);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value < GlobalConstants.StudentIdStartsFrom || value > GlobalConstants.MaxStudents + 1)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Id should be between {0} - {1}", GlobalConstants.StudentIdStartsFrom, GlobalConstants.MaxStudents));
                }

                this.id = value;
            }
        }

        public ICollection<ICourse> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void JoinCourse(ICourse course)
        {
            Validator.NullCheck(course, "Course");

            if (Validator.IsPartOfCollection(this.courses, course))
            {
                throw new InvalidOperationException($"{this} is already part of {course}");
            }

            course.AddStudent(this);
            this.courses.Add(course);
        }

        public void LeaveCourse(ICourse course)
        {
            Validator.NullCheck(course, "Course");

            if (Validator.IsPartOfCollection(this.courses, course))
            {
                course.RemoveStudent(this);
                this.courses.Remove(course);
            }
            else
            {
                throw new InvalidOperationException($"{course} is not added in {this} courses!");
            }

        }

        public override string ToString()
        {
            return $"{this.name} ({this.id})";
        }
    }
}
