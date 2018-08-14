using AutoMapper;
using Livraria.DTO;
using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.App_Start
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            Mapper.CreateMap<Livros,LivroDTO>();
            Mapper.CreateMap<LivroDTO,Livros>();
        }
    }
}