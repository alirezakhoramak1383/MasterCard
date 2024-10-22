using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCard.Web.ViewModel
{
    public class CategoryViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
    }
}
