namespace UserLogin.DTO.Response
{
    public class BaseUserClaims
    {
        public string UserID{get;set;}

        public string Name {get;set;}

        public string RoleName{get; set;}
        
        public bool ManageUser {get; set;}

        public bool Read {get; set;}

        public bool Delete {get; set;}

        public bool Update {get; set;}

        public bool Create {get; set;}

    }
}
