namespace MauiApp1.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    string nome;

    [ObservableProperty]
    string email;

    [ObservableProperty]
    string senha;

    [RelayCommand]
    public async Task Salvar()
    {
        await Shell.Current.DisplayAlert("Atenção", $"Nome: {Nome}, E-mail: {Email}, Senha: {Senha}", "OK");
    }
}
