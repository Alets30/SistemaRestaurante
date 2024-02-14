namespace SistemaRestaurante.Models
{
    using SistemaRestaurante.Modelos.ViewModels;
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
