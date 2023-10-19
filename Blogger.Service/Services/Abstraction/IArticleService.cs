using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Service.Services.Abstraction
{
    public interface IArticleService
    {
        Task<List<ArticleDTO>> GetAllArticlesAsync();

    }
}
