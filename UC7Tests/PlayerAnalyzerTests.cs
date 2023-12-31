﻿using MainApp;
using Xunit;

namespace UC7Tests
{
    public class PlayerAnalyzerTests
    {
        [Fact]
        public void CalculateScore_NormalPlayer_ReturnsCorrectScore()
        {
            // Arrange
            var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
        };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(250, score);
        }

        [Fact]
        public void CalculateScore_JuniorPlayer_ReturnsCorrectScore()
        {
            // Arrange
            var players = new List<Player>
        {
            new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
        };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(67.5, score);
        }

        [Fact]
        public void CalculateScore_SeniorPlayer_ReturnsCorrectScore()
        {
            // Arrange
            var players = new List<Player>
        {
            new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(2520, score);
        }

        [Fact]
        public void CalculateScore_MultiplePlayers_ReturnsCorrectScore()
        {
            // Arrange
            var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
            new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } },
            new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
        };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(250 + 67.5 + 2520, score);
        }

        [Fact]
        public void CalculateScore_NullSkills_ThrowsArgumentNullException()
        {
            // Arrange
            var players = new List<Player>
        {
            new Player { Age = 25, Experience = 5, Skills = null }
        };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => PlayerAnalyzer.CalculateScore(players));
        }

        [Fact]
        public void CalculateScore_EmptyArray_ReturnsZero()
        {
            // Arrange
            var players = new List<Player>();

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(0, score);
        }
    }
}