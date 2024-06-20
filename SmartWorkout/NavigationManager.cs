using Microsoft.AspNetCore.Components;

public class AppNavigation
{
    private readonly NavigationManager _navigationManager;

    public AppNavigation(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public void NavigateTo(string url, bool forceLoad = false)
    {
        _navigationManager.NavigateTo(url, forceLoad);
    }

    public void NavigateToHome()
    {
        _navigationManager.NavigateTo("/");
    }

    public void NavigateToLogin()
    {
        _navigationManager.NavigateTo("/login");
    }

    public void NavigateToErrorPage()
    {
        _navigationManager.NavigateTo("/error");
    }

    public void NavigateToProfile(string userId)
    {
        _navigationManager.NavigateTo($"/profile/{userId}");
    }

    public string GetCurrentUri()
    {
        return _navigationManager.Uri;
    }

    public string GetBaseUri()
    {
        return _navigationManager.BaseUri;
    }
}
