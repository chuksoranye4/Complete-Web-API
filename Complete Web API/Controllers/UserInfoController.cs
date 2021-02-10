using AutoMapper;
using Complete_Web_API.Filter;
using CompleteWebApi.Data.AutoMapper;
using CompleteWebApi.Data.Interface;
using CompleteWebApi.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Complete_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private ICommand<UserInfo> _repository;
        private readonly IMapper _mapper;

        public UserInfoController( ICommand<UserInfo> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET:      api/commands
        [HttpGet]
        public ActionResult<IEnumerable<UserInfoReadDto>> GetAllUser()
        {
            var cmd = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<UserInfoReadDto>>(cmd));
        }

        //GET:      api/commands/{Id}
        //[Authorize]
        [ApiFilter]
        [HttpGet("{id}")]
        public ActionResult<UserInfoReadDto> GetUserInfoById(int id)
        {
            var cmd = _repository.GetById(id);

            if (cmd == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<UserInfoReadDto>(cmd));
        }

        //POST:     api/commands
        [HttpPost]
        public ActionResult<UserInfo> PostUserInfo(UserInfoCreateUpdateDto userInfo)
        {
            var cmd = _mapper.Map<UserInfo>(userInfo);
            _repository.Create(cmd);
            try
            {
                _repository.SaveChanges();
            }
            catch
            {
                return BadRequest();
            }
            return CreatedAtAction("GetUserInfoById", new UserInfo { Id = userInfo.Id }, userInfo);
        }

        //PUT:     api/commands/{Id}
        [HttpPut("{id}")]
        public ActionResult PutUserInfo(int id, UserInfoCreateUpdateDto userInfoUpdateDto)
        {
            if (id != userInfoUpdateDto.Id)
            {
                return BadRequest();
            }
            var commandItem = _repository.GetById(id);

            if (commandItem == null)
            {
                return NotFound();
            }
            _mapper.Map(userInfoUpdateDto, commandItem);

            _repository.Update(commandItem);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE:     api/commands/{Id}
        [HttpDelete("{id}")]
        public ActionResult<UserInfo> DeleteUser(int id)
        {
            var commandItem = _repository.GetById(id);

            if (commandItem == null)
                return NotFound();

            _repository.Delete(commandItem);
            _repository.SaveChanges();

            return commandItem;
        }

    }
}
