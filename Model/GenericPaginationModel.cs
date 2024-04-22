using System.ComponentModel.DataAnnotations;

namespace Shared_Static_Class.Models
{
    public class GenericPaginationModel<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        [Required]
        public T Value { get; set; }
    }
}
