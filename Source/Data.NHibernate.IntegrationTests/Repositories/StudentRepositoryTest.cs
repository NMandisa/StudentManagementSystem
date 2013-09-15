﻿namespace Data.NHibernate.IntegrationTests.Repositories
{
    using System;

    using Domain;

    using NHibernate.Repositories;

    using NUnit.Framework;

    [TestFixture]
    public class StudentRepositoryTest
    {
        private BaseRepository<Student> studentRepository;

        [SetUp]
        public void SetUp()
        {
            this.studentRepository = new BaseRepository<Student>();
        }

        [Test]
        public void ShouldGetStudentById()
        {
            var student = studentRepository.GetById(1);
            Console.WriteLine();
            Console.WriteLine("RollNumber \t {0}", student.RollNumber);
            Console.WriteLine("FirstName \t {0}", student.FirstName);
            Console.WriteLine("MiddleName \t {0}", student.MiddleName);
            Console.WriteLine("LastName \t {0}", student.LastName);
            Console.WriteLine("JoinDate \t {0}", student.JoinDate);
        }

        [Test]
        public void ShouldGetAllStudents()
        {
            var students = studentRepository.GetAll();
            foreach (var student in students)
            {
                Console.WriteLine();
                Console.WriteLine("RollNumber \t {0}", student.RollNumber);
                Console.WriteLine("FirstName \t {0}", student.FirstName);
                Console.WriteLine("MiddleName \t {0}", student.MiddleName);
                Console.WriteLine("LastName \t {0}", student.LastName);
                Console.WriteLine("JoinDate \t {0}", student.JoinDate);
            }
        }
    }
}