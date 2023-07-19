using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserServices(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Register(UserRegisterDTO userRegisterDTO)
        {
            var user = new User(_userRepository,
                userRegisterDTO.Firstname,
                userRegisterDTO.Familyname,
                userRegisterDTO.Username,
                userRegisterDTO.Email,
                userRegisterDTO.Password);

            _userRepository.Register(user);
        }

        public bool Login(string Email, string Password)
        {
            var isValidUser = _userRepository.Login(Email, Password);

            if (isValidUser)
                return true;

            return false;
        }

        
    }
}
