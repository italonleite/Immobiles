using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Immobiles.Api.ViewModel;
using Immobiles.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Immobiles.Api.Controllers
{
    [Route("api/usuarios")]
    public class UsersController : MainController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetAlls()
        {
            var user = _mapper.Map<IEnumerable<UserViewModel>>(await _userRepository.GetAll());
            return Ok(user);
        }
    }


}
