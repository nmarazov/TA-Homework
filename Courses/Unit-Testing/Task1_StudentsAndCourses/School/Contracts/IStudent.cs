namespace School.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IStudent
    {
        int Id { get; }

        string Name { get; }

        ICollection<ICourse> Courses { get; }

        void JoinCourse(ICourse course);

        void LeaveCourse(ICourse course);
    }
}
