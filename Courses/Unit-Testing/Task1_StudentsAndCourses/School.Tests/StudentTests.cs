namespace School.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;
    using Telerik.JustMock;
    using Contracts;
    using Model;

    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void StudentCtor_WhenNameIsNull_ShouldThrowArgumentNullException()
        {
            var school = Mock.Create<ISchool>();
            
            Assert.Throws<ArgumentNullException>(() => new Student(null, school));
        }

        [Test]
        public void StudentCtor_WhenNameIsEmptyString_ShouldThrowArgumentNullException()
        {
            var school = Mock.Create<ISchool>();

            Assert.Throws<ArgumentNullException>(() => new Student(string.Empty, school));
        }

        [Test]
        public void StudentCtor_WhenCreateStudentWithName_ShouldSaveNameCorectly()
        {
            var school = Mock.Create<ISchool>();

            var student = new Student("Pesho", school);

            Assert.AreEqual("Pesho", student.Name);
        }

        [Test]
        public void StudentCtor_WhenCreateStudentAndSchoolIsNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Student("Pesho", null));
        }

        [Test]
        public void StudentCtor_WhenCreateStudent_ShouldGetId()
        {
            var school = Mock.Create<ISchool>();
            Mock.Arrange(() => school.GenerateStudentId()).Returns(50);

            var student = new Student("Pesho", school);

            Assert.AreEqual(50, student.Id);
        }

        [TestCase(-1)]
        [TestCase(500000)]
        [TestCase(2002)]
        public void StudentCtor_WhenCreateStudentWithBigId_ShouldThrowArgumentOutOfRangeException(int id)
        {
            var school = Mock.Create<ISchool>();
            Mock.Arrange(() => school.GenerateStudentId()).Returns(id);

            Assert.Throws<ArgumentOutOfRangeException>(() => new Student("Pesho", school));
        }

        [Test]
        public void JoinCourse_WhenStudentJoinNullCourse_ShouldThrowArgumentNullException()
        {
            var school = Mock.Create<ISchool>();
            var student = new Student("Pesho", school);

            Assert.Throws<ArgumentNullException>(() => student.JoinCourse(null));
        }

        [Test]
        public void JoinCourse_WhenStudentJoinCourse_ShouldIncreaseCourseCount()
        {
            var school = Mock.Create<ISchool>();
            var course = Mock.Create<ICourse>();
            var course1 = Mock.Create<ICourse>();
            var student = new Student("Pesho", school);

            student.JoinCourse(course);
            student.JoinCourse(course1);

            Assert.AreEqual(2, student.Courses.Count);
        }

        [Test]
        public void JoinCourse_WhenStudentJoinCourseTwice_ShouldThrowInvalidOperationException()
        {
            var school = Mock.Create<ISchool>();
            var course = Mock.Create<ICourse>();
            var student = new Student("Pesho", school);

            student.JoinCourse(course);

            Assert.Throws<InvalidOperationException>(() => student.JoinCourse(course));
        }

        [Test]
        public void LeaveCourse_WhenStudentLeaveCourse_ShouldDecreaseCourseCount()
        {
            var school = Mock.Create<ISchool>();
            var course = Mock.Create<ICourse>();
            var course1 = Mock.Create<ICourse>();
            var student = new Student("Pesho", school);

            student.JoinCourse(course);
            student.JoinCourse(course1);
            student.LeaveCourse(course);

            Assert.AreEqual(1, student.Courses.Count);
        }

        [Test]
        public void LeaveCourse_WhenStudentLeaveCourseBeforeJoinCourse_ShouldThrowInvalidOperationException()
        {
            var school = Mock.Create<ISchool>();
            var course = Mock.Create<ICourse>();
            var student = new Student("Pesho", school);

            Assert.Throws<InvalidOperationException>(() => student.LeaveCourse(course));
        }

        [Test]
        public void LeaveCourse_WhenStudentLeaveNullCourse_ShouldThrowArgumentNullException()
        {
            var school = Mock.Create<ISchool>();
            var course = Mock.Create<ICourse>();
            var student = new Student("Pesho", school);

            student.JoinCourse(course);

            Assert.Throws<ArgumentNullException>(() => student.LeaveCourse(null));
        }

        [Test]
        public void ToString_WhenStudentIsToString_ShouldReturnStudentInFormat()
        {
            var school = Mock.Create<ISchool>();
            Mock.Arrange(() => school.GenerateStudentId()).Returns(15);
            var student = new Student("Pesho", school);

            Assert.AreEqual("Pesho (15)", student.ToString());
        }
    }
}
