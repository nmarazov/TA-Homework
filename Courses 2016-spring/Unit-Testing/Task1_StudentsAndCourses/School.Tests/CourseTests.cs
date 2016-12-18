namespace School.Tests
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Model;
    using Contracts;

    using NUnit.Framework;
    using Telerik.JustMock;

    [TestFixture]
    public class CourseTests
    {
        [Test]
        public void CourseCtor_WhenCreateCourseWithNullName_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Course(null));
        }

        [Test]
        public void CourseCtor_WhenCreateCourseWithEmptyName_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Course(string.Empty));
        }

        [Test]
        public void CourseCtor_WhenCreateCourse_ShouldSaveName()
        {
            var course = new Course("Unit Testing");

            Assert.AreEqual("Unit Testing", course.CourseName);
        }

        [Test]
        public void AddStudent_WhenAddStudentWihNullName_ShouldThrowArgumentNullException()
        {
            var course = new Course("Unit Testing");

            Assert.Throws<ArgumentNullException>(() => course.AddStudent(null));
        }

        [Test]
        public void AddStudent_WhenAddStudentToCourseMultipleTimes_ShouldThrowInvalidOperationException()
        {
            var course = new Course("Unit Testing");
            var student = Mock.Create<IStudent>();

            course.AddStudent(student);

            Assert.Throws<InvalidOperationException>(() => course.AddStudent(student));
        }

        [Test]
        public void AddStudent_WhenAddStudentToCourseAfterlimit_ShouldThrowInvalidOperationException()
        {
            var course = new Course("Unit Testing");
            for (int i = 0; i < GlobalConstants.MaxStudentsInCourse; i++)
            {
                var student = Mock.Create<IStudent>();
                course.AddStudent(student);
            }
            var student1 = Mock.Create<IStudent>();

            Assert.Throws<InvalidOperationException>(() => course.AddStudent(student1));
        }

        [Test]
        public void AddStudent_WhenAddStudentToCourse_ShouldIncreaseStudentList()
        {
            var course = new Course("Unit Testing");
            var student = Mock.Create<IStudent>();
            var student1 = Mock.Create<IStudent>();

            course.AddStudent(student);
            course.AddStudent(student1);

            Assert.AreEqual(2, course.StudentsList.Count);
        }

        [Test]
        public void RemoveStudent_WhenRemoveStudentWithNullOrEmptyName_ShouldThrowArgumentNullException()
        {
            var course = new Course("Unit Testing");

            Assert.Throws<ArgumentNullException>(() => course.RemoveStudent(null));
        }

        [Test]
        public void RemoveStudent_WhenRemoveStudentFromCourseBeforeAdd_ShouldThrowInvalidOperationException()
        {
            var course = new Course("Unit Testing");
            var student = Mock.Create<IStudent>();

            Assert.Throws<InvalidOperationException>(() => course.RemoveStudent(student));
        }

        [Test]
        public void RemoveStudent_WhenRemoveStudentFromCourse_ShouldDecreaseStudentsList()
        {
            var course = new Course("Unit Testing");
            var student = Mock.Create<IStudent>();
            var student1 = Mock.Create<IStudent>();

            course.AddStudent(student);
            course.AddStudent(student1);
            course.RemoveStudent(student);

            Assert.AreEqual(1, course.StudentsList.Count);
        }

        [Test]
        public void CourseToString_ShouldReturnCourseName()
        {
            var name = "Unit Testing";

            var course = new Course(name);

            Assert.AreEqual(name, course.ToString());
        }
    }
}
