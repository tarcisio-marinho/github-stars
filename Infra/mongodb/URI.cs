using System.IO;

namespace github_stars.Infra.mongodb
{
    public static class URI
    {
        public static string Uri
        {
            get
            {
                return string.Format("mongodb://{0}:{1}@{2}:{3}/{4}", Login, Password, Ip, Port, DbName);
            }
        }

        public static string Ip
        {
            get
            {
                return "localhost";
            }
        }

        public static string Port
        {
            get
            {
                return "27017";
            }
        }

        public static string Login
        {
            get
            {
                return Credentials.Login;
            }
        }

        public static string Password
        {
            get
            {
                return File.ReadAllText(Credentials.PasswordPath).Replace("\n", "");
            }
        }

        public static string User
        {
            get
            {
                return "tarcisio";
            }
        }

        public static string DbName
        {
            get
            {
                return "github";
            }
        }

        public static string Collection
        {
            get
            {
                return "repositories";
            }
        }
    }
}