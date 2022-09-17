using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
    public class OrganizationalUnit
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "名稱 不可為空白")]
        public string Name { get; set; } = String.Empty;
        public string? Remark { get; set; }
        public OrganizationalUnit? Parent { get; set; }
        public int? ParentId { get; set; }
    }
}
