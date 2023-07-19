using Domain.Exception;
using Domain.Repository;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace Domain.Entities
{
    public class User
    {
        private readonly IUserRepository _userRepository;

        public User(IUserRepository userRepository, string firstname, string familyname,
            string username, string email, string password)
        {
            _userRepository = userRepository;
            UniqueID = Guid.NewGuid();
            SetName(firstname, familyname);
            SetUsername(username);
            SetEmail(email);
            SetPassword(password);
            RegisterDate = DateTime.Now;
        }

        public Guid UniqueID { get; set; }
        public string Firstname { get; set; }
        public string Familyname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }

        private void SetName(string firstname, string familyname)
        {
            Firstname = firstname ?? throw new AllFieldsAreRequiredException();
            Familyname = familyname ?? throw new AllFieldsAreRequiredException();
        }

        private void SetUsername(string username)
        {
            if (_userRepository.IsExists(e => e.Username == username))
                throw new EmailAddressExistsException();

            else
                Username = username ?? throw new AllFieldsAreRequiredException();
        }

        private void SetEmail(string email)
        {
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"))
                throw new EmailAddressNotValidException();

            else if (_userRepository.IsExists(e => e.Email == email))
                throw new EmailAddressExistsException();

            else
                Email = email ?? throw new AllFieldsAreRequiredException();
        }

        private void SetPassword(string password)
        {
            if (!Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$"))
                throw new PasswordIsWeakException();

            else
                Password = password ?? throw new AllFieldsAreRequiredException();
        }
    }
}