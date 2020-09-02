using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    public class ChessPlayersParser : IChessPlayersParser
    {
        public List<ChessPlayer> chessPlayers = new List<ChessPlayer>
        {
            new ChessPlayer
            {
                FirstName = "Leonardo",
                LastName = "DiCaprio",
                Birthdate = new DateTime(1974, 11, 11),
                EloRating = 5512,
                ThisYearTrainingTime = new TimeSpan(1211, 10, 7),
                Country = Country.USA
            },
            new ChessPlayer
            {
                FirstName = "Elena",
                LastName = "An",
                Birthdate = new DateTime(1998, 01, 13),
                EloRating = 912,
                ThisYearTrainingTime = new TimeSpan(1777, 5, 13),
                Country = Country.Russia
            },
            new ChessPlayer
            {
                FirstName = "Mi",
                LastName = "Yang ",
                Birthdate = new DateTime(1986, 09, 12),
                EloRating = 3113,
                ThisYearTrainingTime = new TimeSpan(911, 11, 3),
                Country = Country.China
            },
            new ChessPlayer
            {
                FirstName = "Natalie",
                LastName = "Portman",
                Birthdate = new DateTime(1981, 06, 09),
                EloRating = 5311,
                ThisYearTrainingTime = new TimeSpan(1531, 6, 1),
                Country = Country.USA
            },
            new ChessPlayer
            {
                FirstName = "Natalia",
                LastName = "Vodianova",
                Birthdate = new DateTime(1982, 02, 28),
                EloRating = 2679,
                ThisYearTrainingTime = new TimeSpan(911, 11, 3),
                Country = Country.Russia
            },
            new ChessPlayer
            {
                FirstName = "Pizza",
                LastName = "Spagetti",
                Birthdate = new DateTime(1990, 01, 01),
                EloRating = 7111,
                ThisYearTrainingTime = new TimeSpan(375, 2, 6),
                Country = Country.Italy
            },
            new ChessPlayer
            {
                FirstName = "Deng",
                LastName = "Lun",
                Birthdate = new DateTime(1992, 10, 21),
                EloRating = 2135,
                ThisYearTrainingTime = new TimeSpan(651, 1, 21),
                Country = Country.China
            },
        };

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAge(int ageInYears)
        {
            var playersOlderThanSpecifiedAge = chessPlayers
                .Where(n => n.AgeInYears > ageInYears);
            return playersOlderThanSpecifiedAge;
        }

        public IEnumerable<ChessPlayer> GetChessPlayersInEloRatingRange(int minEloRating, int maxEloRating)
        {
            var playersInEloRatingRange = chessPlayers
                .Where(n => n.EloRating >= minEloRating && n.EloRating <= maxEloRating);
            return playersInEloRatingRange;
        }

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(int ageInYears, Country country)
        {
            var playersOlderThanSpecifiedAgeFromSpecifiedCoutry = chessPlayers
                .Where(n => n.AgeInYears > ageInYears && n.Country == country);
            return playersOlderThanSpecifiedAgeFromSpecifiedCoutry;
        }

        public IEnumerable<IGrouping<Country, ChessPlayer>> GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(int minEloRating, Country country)
        {
            var playersWithHigherOrEqualEloRatingGroupedByCountry = chessPlayers
                .Where(n => n.EloRating >= minEloRating)
                .GroupBy(n => n.Country);
            return playersWithHigherOrEqualEloRatingGroupedByCountry;
        }
    }
}
