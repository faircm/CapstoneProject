namespace C969Assessment
{
    // This class records and maintains the context for the currently logged-in user
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
