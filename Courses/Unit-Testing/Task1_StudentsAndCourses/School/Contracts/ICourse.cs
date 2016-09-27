namespace School.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ICourse
    {
        string CourseName { get; }

        ICollection<IStudent> StudentsList { get; }

        void AddStudent(IStudent student);

        void RemoveStudent(IStudent student);
    }
}
