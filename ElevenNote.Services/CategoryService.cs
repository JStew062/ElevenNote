using ElevenNote.Data;
using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Services
{
    public class CategoryService
    {
        private readonly Guid _userId;
        public CategoryService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCategory(CategoryCreate model)
        {
            var entity =
                new Category()
                {
                    CatId = model.CatId,
                    CatName = model.CatName
                                    };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Categorys.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
