namespace CertificationManager.Core.Abstractions.Models.Request
{
    public class PaginationRequestBase
    {
        public int Offset { get; set; } = 0;
        
        public int Limit { get; set; }
        
        //example- firstName:asc,age:desc
        public string Sort { get; set; }
        
    }
}
