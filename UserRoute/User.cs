namespace MinimalApi.UserRoute;

public class User
{
       public Guid Id { get; init; }
       public string Name { get; private set; }
       public string Email { get; private set; }
       public bool Active { get; set; }

       public User(string name, string email)
       {
              Name = name;
              Email = email;
              Id = Guid.NewGuid();
       }
}
