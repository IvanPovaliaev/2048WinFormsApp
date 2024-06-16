namespace _2048.Common
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public User()
        {
            Name = "NoName";
            Score = 0;
        }
        public User(string name)
        {
            Name = name.NullIfEmpty() ?? "NoName";
            Score = 0;
        }
        public void ResetResults() => Score = 0;
    }
}
