namespace School.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;
    using Telerik.JustMock;

    using Contracts;
    using Model;

    [TestFixture]
    public class SchoolTests
    {
        [Test]
        public void SchoolConstructor_ShouldMakeInstanceOf_COllectionOfStudents()
        {
            var school = new School("Telerik - Academy");

            Assert.IsInstanceOf<ICollection<IStudent>>(school.StudentList);
        }

        [Test]
        public void School_ShouldProperlySetName()
        {
            var expected = "Telerik - Academy";

            var school = new School(expected);

            Assert.AreEqual(expected, school.SchoolName);
        }

        [Test]
        public void AddStudent_WhenNullStudent_shouldThrowAnException()
        {
            var school = new School("Telerik - Academy");

            Assert.Throws<ArgumentNullException>(() => school.AddStudent(null));
        }

        [Test]
        public void AddStudent_WhenAddStudentManyTimes_ShuldThrowInvalidOperationException()
        {
            var student = Mock.Create<IStudent>();

            var school = new School("Telerik - Academy");

            school.AddStudent(student);

            Assert.Throws<InvalidOperationException>(() => school.AddStudent(student));
        }

        [Test]
        public void AddCourse_WhenCourseNameIsNull_ShouldThrowArgumentNullException()
        {
            var school = new School("Telerik");

            Assert.Throws<ArgumentNullException>(() => school.AddCourse(null));
        }
       
        [Test]
        public void AddStudent_WhenAddCourseManyTimes_ShuldThrowInvalidOperationException()
        {
            var course = Mock.Create<ICourse>();

            var school = new School("Telerik");

            school.AddCourse(course);

            Assert.Throws<InvalidOperationException>(() => school.AddCourse(course));
        }

        [Test]
        public void RemoveStudent_WhenStudentIsnull_ShuldThrowArgumentNullException()
        {
            var school = new School("Telerik");

            Assert.Throws<ArgumentNullException>(() => school.RemoveCourse(null));
        }

        [Test]
        public void SchoolRemoveCourse_ShouldThrowAnException_IfCourseIsNull()
        {
            var school = new School("Telerik");

            Assert.Throws<ArgumentNullException>(() => school.AddCourse(null));
        }

        [Test]
        public void SchoolRemoveStudent_ShouldThrowAnException_IfStudentIsNotAdded()
        {
            var student = Mock.Create<IStudent>();

            var school = new School("Telerik");

            Assert.Throws<InvalidOperationException>(() => school.RemoveStudent(student));
        }

        [Test]
        public void SchoolRemoveCourse_ShouldThrowAnException_IfCourseIsNotAdded()
        {
            var course = Mock.Create<ICourse>();

            var school = new School("Telerik");

            Assert.Throws<InvalidOperationException>(() => school.RemoveCourse(course));
        }
    }
}
