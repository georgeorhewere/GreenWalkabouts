namespace Walkabouts.Data.DTO
{
    public class ServiceResultDTO
    {
        public bool Success { get; set; }
        public dynamic Data { get; set; }
        public dynamic Error { get; set; }

    }
}