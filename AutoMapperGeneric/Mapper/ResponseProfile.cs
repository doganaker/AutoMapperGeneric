using AutoMapper;
using AutoMapperGeneric.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperGeneric.Mapper
{
    public class ResponseProfile : Profile
    {
        public ResponseProfile()
        {
            CreateMap(typeof(DBResponse<>), typeof(ServiceReponse<>));
        }
    }
}
