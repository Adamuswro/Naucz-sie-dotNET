using _24RobotsFactory.DataSource;
using System;
using System.Text;
using Helpers;

namespace _24RobotsFactory.Models
{
    public class RobotFactory
    {
        IDataSource db;

        public RobotFactory(IDataSource db)
        {
            this.db = db;
        }

        public Robot CreateRobot()
        {
            var result = new Robot()
            {
                Id = AssignId(),
                Parameter = GetParameter()
            };
            return result;
        }

        public void ResetId(Robot robot)
        {
            Robot result;
            result = (Robot)robot;

            var oldId = result.Id;
            result.Id = AssignId();
            db.RemoveId(oldId);
        }

        private string AssignId()
        {
            var allIds = db.GetAllIds();
            string newId;
            do
            {
                newId = GetRanomId();
            } while (allIds.Contains(newId));

            db.AddId(newId);
            return newId;
        }

        private RobotParameter GetParameter()
        {
            Random random = new Random();

            Type type = typeof(RobotParameter);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);

            RobotParameter result = (RobotParameter)values.GetValue(index);

            return result;
        }

        private string GetRanomId()
        {
            Random rng = new Random();

            const string poolLetters = "abcdefghijklmnopqrstuvwxyz";
            const string poolNumbers = "0123456789";

            var result = new StringBuilder();

            for (var i = 0; i < 2; i++)
            {
                var c = poolLetters[rng.Next(0, poolLetters.Length)];
                result.Append(c);
            }
            for (var i = 0; i < 3; i++)
            {
                var c = poolNumbers[rng.Next(0, poolNumbers.Length)];
                result.Append(c);
            }

            return result.ToString();
        }
    }
}
