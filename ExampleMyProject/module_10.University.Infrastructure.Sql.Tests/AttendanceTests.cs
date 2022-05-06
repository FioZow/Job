using System;
using Autofac;
using NUnit.Framework;
using AutoFixture;
using module_10.University.Domain.Attendances;
using Shouldly;

namespace module_10.University.Infrastructure.Sql.Tests
{
    [TestFixture]
    public class AttendanceTests
    {
        private readonly IContainer _container;
        private readonly Fixture _fixture;

        public AttendanceTests()
        {
            _fixture = new Fixture();
            _container = SqlTestContainer.GetContainer();
        }

        [Test]
        public void Create_ShouldCreateEntity()
        {
            //Arrange
            var attendance = GetAttendance();
            var repository = GetAttendanceRepository();
            var context = GetCustomDbContext();

            //Act
            repository.Create(attendance);

            //Assert
            context.Attendances.ShouldNotBeEmpty();
        }

        [Test]
        public void Update_ShouldUpdateEntity([Values(1)] int id)
        {
            //Arrange
            var attendance = GetAttendance();
            var repository = GetAttendanceRepository();
            var context = GetCustomDbContext();
            repository.Create(attendance);

            //Act
            var newAttendance = GetAttendance();
            newAttendance.Id = attendance.Id;
            repository.Update(attendance);
            //Assert
        }

        private Attendance GetAttendance()
        {
            return _fixture.Create<Attendance>();
        }

        private IAttendanceRepository GetAttendanceRepository()
        {
            return _container.Resolve<IAttendanceRepository>();
        }

        private CustomDbContext GetCustomDbContext()
        {
            return _container.Resolve<CustomDbContext>();
        }
    }
}