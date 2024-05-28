using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DTO
{
    public class CategoryDto:BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AppUserId { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
