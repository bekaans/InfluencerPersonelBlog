using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        protected ArticleProfile()
        {
            CreateMap<ArticleDTO, Article>().ReverseMap();
        }
    }
}
