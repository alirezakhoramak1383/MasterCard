using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCard.Web.ViewModel
{
    public class CardViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool IsDeleted { get; set; }
        public long CategoryId { get; set; }
    }
}
