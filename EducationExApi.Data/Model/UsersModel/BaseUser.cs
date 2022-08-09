﻿namespace EducationExApi.Data.Model.UsersModel
{
    public class BaseUser
    {
        [Key]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public CredentialsContainer? Credentials { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
