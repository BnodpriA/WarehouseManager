// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WarehouseManager.Client.Pages.Identity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
using WarehouseManager.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Blazor\WarehouseManager\src\Client\Pages\Identity\RolePermissions.razor"
using WarehouseManager.Application.Responses.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "d:\Blazor\WarehouseManager\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Blazor\WarehouseManager\src\Client\Pages\Identity\RolePermissions.razor"
           [Authorize(Policy = Permissions.RoleClaims.View)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/identity/role-permissions/{Id}")]
    public partial class RolePermissions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<RolePermissions> _localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientPreferenceManager _clientPreferenceManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpInterceptorManager _interceptor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService _authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorHeroStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountManager _accountManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationManager _authenticationManager { get; set; }
    }
}
#pragma warning restore 1591
