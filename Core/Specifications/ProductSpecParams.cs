namespace Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;

        private int _pagesize = 6;
        public int PageSize 
        {
            get => _pagesize;
            set => _pagesize = (value > MaxPageSize ? MaxPageSize : value);
        }

        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
        public string Sort { get; set; }
    }
}