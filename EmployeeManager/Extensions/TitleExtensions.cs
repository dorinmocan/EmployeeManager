using EmployeeManager.Entities;
using EmployeeManager.Models;

namespace EmployeeManager.Extensions
{
    public static class TitleExtensions
    {
        public static TitleModel ToModel(this Title title)
        {
            return new TitleModel
            {
                Id = title.Id,
                Name = title.Name
            };
        }

        public static Title ToEntity(this TitleModel modelTitle)
        {
            return new Title
            {
                Id = modelTitle.Id,
                Name = modelTitle.Name
            };
        }
    }
}