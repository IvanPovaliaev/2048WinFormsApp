using Newtonsoft.Json;
using System.Collections.Generic;

namespace _2048.Common
{
    public static class UserStorage
    {
        private static string filePath { get; } = @".\data\Leaderboard.json";
        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(filePath) || FileProvider.GetContent(filePath) == string.Empty)
            {
                return new List<User>();
            }

            var fileData = FileProvider.GetContent(filePath);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }
        public static void Save(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            FileProvider.Save(filePath, usersResults);
        }
        public static void Clear() => FileProvider.Clear(filePath);        
    }
}
