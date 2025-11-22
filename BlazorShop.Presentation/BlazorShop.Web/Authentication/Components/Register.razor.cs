namespace BlazorShop.Web.Authentication.Components
{
    using System.ComponentModel.DataAnnotations;

    using BlazorShop.Web.Shared.Models.Authentication;

    public partial class Register
    {
        private CreateUser _user = new();
        private bool _isLoading = false;

        private async Task HandleRegister()
        {
            _isLoading = true;

            try
            {
                var response = await this.AuthenticationService.CreateUser(_user);

                if (response.Success)
                {
                    this.ToastService.ShowSuccessToast("Registro exitoso.");
                    this.ToastService.ShowInfoToast("Por favor revisa tu correo para confirmar tu cuenta.");
                    this.NavigationManager.NavigateTo("/authentication/login");
                }
                else
                {
                    this.ToastService.ShowErrorToast($"Error en el registro: {response.Message}");
                }
            }
            catch (Exception ex)
            {
                this.ToastService.ShowErrorToast($"Ocurrió un error: {ex.Message}");
            }
            finally
            {
                _isLoading = false;
            }
        }
    }
}