namespace Library.Model
{
    public class BusinessResult<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
