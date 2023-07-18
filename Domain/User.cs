using Domain.Exception;

namespace Domain
{
    public class User
    {
        public string Firstname { get; set; }
        public string Familyname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private void SetName(string firstname , string familyname)
        {
            Firstname = firstname ?? throw new AllFieldsAreRequiredException();
            Familyname = familyname ?? throw new AllFieldsAreRequiredException();
        }

        private void SetEmail(string email)
        {
            if ()
        }
    }
}