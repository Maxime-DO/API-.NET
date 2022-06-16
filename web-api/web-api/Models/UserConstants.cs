public class UserConstants
{
    public static List<User> Users = new List<User>()
    {
        new UserModel() { Username = "maxigo",
                        EmailAddress = "maxigo31@live.fr", 
                        Password = "MyPass_w0rd", 
                        GivenName = "Maxime", 
                        Surname = "De Oliveira",
                        Role = "Administrator" },
        new UserModel() { Username = "thomss",
                        EmailAddress = "reveltdev@gmail.com",
                        Password = "MyPass_w0rd",
                        GivenName = "Thomas",
                        Surname = "Revel",
                        Role = "Administrator" },
};
}