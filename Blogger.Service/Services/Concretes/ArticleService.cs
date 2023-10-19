using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blogger.Data.UnitOfWorks;
using Blogger.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ArticleDTO>> GetAllArticlesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDTO>>(articles);
                return map;
        }
    }
}
