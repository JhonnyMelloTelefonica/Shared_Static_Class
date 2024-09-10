using System.ComponentModel.DataAnnotations;

namespace Shared_Razor_Components.FundamentalModels
{
    public class GenericPaginationModel<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        [Required]
        public T Value { get; set; }
    }
}
