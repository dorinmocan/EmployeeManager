using EmployeeManager.Entities;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Extensions
{
    public static class FieldExtensions
    {
        public static FieldModel ToModel(this Field field)
        {
            return new FieldModel
            {
                Id = field.Id,
                Name = field.Name
            };
        }

        public static Field ToEntity(this FieldModel modelField)
        {
            return new Field
            {
                Id = modelField.Id,
                Name = modelField.Name
            };
        }
    }
}