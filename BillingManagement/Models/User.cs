namespace Ekart.Models
{
    public class User
    {
        public int Id { get; set; }

        public string username { get; set; }

        public string Email { get; set; }

        public string password { get; set; }

        public virtual Cart cart { get; set; }


    }
}
