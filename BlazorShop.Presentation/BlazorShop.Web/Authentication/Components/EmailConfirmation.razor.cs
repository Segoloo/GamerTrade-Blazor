namespace BlazorShop.Web.Authentication.Components
{
    public partial class EmailConfirmation
    {
        private string? _message;
        private bool _isLoading = true;
        private bool _isSuccess = false;

        private string? UserId { get; set; }

        private string? Token { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var uri = this.NavigationManager.ToAbsoluteUri(this.NavigationManager.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);

            this.UserId = query.Get("userId");
            this.Token = query.Get("token");

            if (string.IsNullOrEmpty(this.UserId) || string.IsNullOrEmpty(this.Token))
            {
                _message = "Enlace de confirmación inválido.";
                _isLoading = false;
                return;
            }

            var response = await this.AuthenticationService.ConfirmEmail(this.UserId, this.Token);

            if (response.Success)
            {
                _message = "Tu correo electrónico ha sido confirmado exitosamente.";
                _isSuccess = true;
                this.ToastService.ShowSuccessToast("Correo confirmado exitosamente.");
            }
            else
            {
                _message = $"Error al confirmar el correo: {response.Message}";
                this.ToastService.ShowErrorToast($"Error al confirmar el correo: {response.Message}");
            }

            _isLoading = false;
        }
    }
}