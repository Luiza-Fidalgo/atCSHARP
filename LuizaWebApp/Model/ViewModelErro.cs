namespace LuizaWebApp.Model
{
    public class ViewModelErro
    {
        public string? RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
