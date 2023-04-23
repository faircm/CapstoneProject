namespace C969Assessment
{
    public static class userContext
    {
        private static int userId;
        private static string username;

        public static void setUserId(int id)
        {
            userId = id;
        }

        public static void setUsername(string newName)
        {
            username = newName;
        }

        public static int getUserId()
        {
            return userId;
        }

        public static string getUsername()
        {
            return username;
        }
    }
}
