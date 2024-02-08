using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services;

    internal class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly AddressService _addressService;
        private readonly RoleService _roleService;

        public UserService(UserRepository repository, AddressService addressService, RoleService roleService)
        {
            _userRepository = repository;
            _addressService = addressService;
            _roleService = roleService;
        }


        public UserEntity CreateUser(string firstName, string lastName, string email, string roleName, string streetName, string postalcode, string city)
        {
            var roleEntity = _roleService.CreateRole(roleName);
            var addressEntity = _addressService.CreateAddress(streetName, postalcode, city);

            var userEntity = new UserEntity
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                RoleId = roleEntity.Id,
                AddressID = addressEntity.Id,
            };
            
            userEntity = _userRepository.Create(userEntity);

            return userEntity;

        }

        public UserEntity GetUserByEmail(string email)
        {
            var userEntity = _userRepository.Get(x => x.Email == email);
            return userEntity;
        }

        public IEnumerable<UserEntity> GetUser()
        {
            var users = _userRepository.GetAll();
            return users;
        }

        public UserEntity UpdateUser(UserEntity userEntity)
        {
            var updatedUserEntity = _userRepository.Update(x => x.Id == userEntity.Id, userEntity);
            return updatedUserEntity;
        }

        public void DeleteUser(int id)
        {
            _userRepository.Detele(x => x.Id == id);
        }
    }
