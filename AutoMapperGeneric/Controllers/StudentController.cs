using AutoMapper;
using AutoMapperGeneric.Models.Context;
using AutoMapperGeneric.Models.Dto;
using AutoMapperGeneric.Models.Entities;
using AutoMapperGeneric.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperGeneric.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;
        private readonly GenericContext _context;

        public StudentController(GenericContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            DBResponse<Student> student = new DBResponse<Student>();

            student.Data = _context.Students.FirstOrDefault(x => x.StudentNo == 3);
            student.IsSuccess = true;

            ServiceReponse<StudentDto> stu = _mapper.Map<ServiceReponse<StudentDto>>(student);

            return View(stu);
        }
    }
}
