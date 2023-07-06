using MainApp;
using Xunit;

namespace UC7Tests
{
    public class StudentConverterTests
    {
        private StudentConverter _testSubject;

        public StudentConverterTests()
        {
            _testSubject = new StudentConverter();
        }

        [Fact]
        public void ConvertStudents_HonorRollBecomesTrue()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Test1", Age = 25, Grade = 95 }
            };

            // Act
            var result = _testSubject.ConvertStudents(students);

            // Assert
            Assert.True(result.First().HonorRoll);
        }

        [Fact]
        public void ConvertStudents_ExceptionalBecomesTrue()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Test2", Age = 20, Grade = 95 }
            };

            // Act
            var result = _testSubject.ConvertStudents(students);

            // Assert
            Assert.True(result.First().Exceptional);
        }

        [Fact]
        public void ConvertStudents_PassedBecomesTrue()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Test3", Age = 22, Grade = 80 }
            };

            // Act
            var result = _testSubject.ConvertStudents(students);

            // Assert
            Assert.True(result.First().Passed);
        }

        [Fact]
        public void ConvertStudents_PassedRemainsFalse()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Test4", Age = 18, Grade = 60 }
            };

            // Act
            var result = _testSubject.ConvertStudents(students);

            // Assert
            Assert.False(result.First().Passed);
        }

        [Fact]
        public void ConvertStudents_EmptyListGiven()
        {
            // Arrange
            var students = new List<Student>();

            // Act
            var result = _testSubject.ConvertStudents(students);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ConvertStudents_InputIsNotAList()
        {
            // Arrange
            List<Student> students = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _testSubject.ConvertStudents(students));
        }
    }
}