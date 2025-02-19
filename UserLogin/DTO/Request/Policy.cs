namespace UserLogin.DTO.Request
{
    public static class Policy
    {
        public const string AdminPolicy = "AdminPolicy";
        public const string ManagerPolicy = "ManagerPolicy";
        public const string UserPolicy = "UserPolicy";

        public static class RoleClaim
        {
            public const string Admin = "admin";
            public const string Manager = "manager";
            public const string User = "user";
        }
    }
}
