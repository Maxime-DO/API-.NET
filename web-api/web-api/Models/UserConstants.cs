using web_api.Models;
using System.Collections.Generic;

public class UserConstants
{
    public static List<User> Users = new List<User>()
    {
        new User() { Username = "maxigo",
                        EmailAddress = "maxigo31@live.fr", 
                        Password = "MyPass_w0rd", 
                        GivenName = "Maxime", 
                        Surname = "De Oliveira",
                        Role = "Administrator" },
        new User() { Username = "thomss",
                        EmailAddress = "reveltdev@gmail.com",
                        Password = "MyPass_w0rd",
                        GivenName = "Thomas",
                        Surname = "Revel",
                        Role = "Administrator" },
};
}