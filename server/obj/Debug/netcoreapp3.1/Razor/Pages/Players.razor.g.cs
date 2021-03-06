#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\Players.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "565b227c9650c27fff96d15bc53198c50cd97e93"
// <auto-generated/>
#pragma warning disable 1591
namespace SoccerLeagueTransferApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using SoccerLeagueTransferApp.Shared;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/players")]
    public partial class Players : SoccerLeagueTransferApp.Pages.PlayersComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Players");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 14 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                  canEdit==true

#line default
#line hidden
                ));
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                                          Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.Player>>(21);
                __builder2.AddAttribute(22, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SoccerLeagueTransferApp.Models.ConData.Player>>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                     getPlayersResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.Player>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.Player>(this, 
#line 16 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                                                                                                         Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(27, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(29);
                    __builder3.AddAttribute(30, "Property", "PlayerID");
                    __builder3.AddAttribute(31, "Title", "Player ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(33);
                    __builder3.AddAttribute(34, "Property", "FirstName");
                    __builder3.AddAttribute(35, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(37);
                    __builder3.AddAttribute(38, "Property", "MiddleName");
                    __builder3.AddAttribute(39, "Title", "Middle Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(41);
                    __builder3.AddAttribute(42, "Property", "Surname");
                    __builder3.AddAttribute(43, "Title", "Surname");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(45);
                    __builder3.AddAttribute(46, "FilterProperty", "Gender.GenderName");
                    __builder3.AddAttribute(47, "Property", "GenderID");
                    __builder3.AddAttribute(48, "SortProperty", "Gender.GenderName");
                    __builder3.AddAttribute(49, "Title", "Gender");
                    __builder3.AddAttribute(50, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.Player>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(51, "\n              ");
                        __builder4.AddContent(52, 
#line 28 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                data.Gender?.GenderName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(53, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(55);
                    __builder3.AddAttribute(56, "FilterProperty", "ClubDetail.TeamName");
                    __builder3.AddAttribute(57, "Property", "CurrentClubID");
                    __builder3.AddAttribute(58, "SortProperty", "ClubDetail.TeamName");
                    __builder3.AddAttribute(59, "Title", "Club Detail");
                    __builder3.AddAttribute(60, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.Player>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(61, "\n              ");
                        __builder4.AddContent(62, 
#line 33 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                data.ClubDetail?.TeamName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(63, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(65);
                    __builder3.AddAttribute(66, "Property", "PlayerPhoto");
                    __builder3.AddAttribute(67, "Title", "Player Photo");
                    __builder3.AddAttribute(68, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.Player>)((soccerLeagueTransferAppModelsConDataPlayer) => (__builder4) => {
                        __builder4.AddMarkupContent(69, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(70);
                        __builder4.AddAttribute(71, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                     soccerLeagueTransferAppModelsConDataPlayer.PlayerPhoto

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(72, "style", "height: 30px; width: 30px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(73, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(75);
                    __builder3.AddAttribute(76, "Property", "ContactEmail");
                    __builder3.AddAttribute(77, "Title", "Contact Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(79);
                    __builder3.AddAttribute(80, "Property", "ContactPhone");
                    __builder3.AddAttribute(81, "Title", "Contact Phone");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(83);
                    __builder3.AddAttribute(84, "FilterProperty", "PlayerPosition.PositionName");
                    __builder3.AddAttribute(85, "Property", "PositionID");
                    __builder3.AddAttribute(86, "SortProperty", "PlayerPosition.PositionName");
                    __builder3.AddAttribute(87, "Title", "Player Position");
                    __builder3.AddAttribute(88, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.Player>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(89, "\n              ");
                        __builder4.AddContent(90, 
#line 48 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                data.PlayerPosition?.PositionName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(91, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.Player>>(93);
                    __builder3.AddAttribute(94, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 51 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(95, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 51 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 51 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                                                   TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(97, "Width", "70px");
                    __builder3.AddAttribute(98, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.Player>)((soccerLeagueTransferAppModelsConDataPlayer) => (__builder4) => {
                        __builder4.AddMarkupContent(99, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(100);
                        __builder4.AddAttribute(101, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 53 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(102, "Icon", "close");
                        __builder4.AddAttribute(103, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 53 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(104, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 53 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                               canEdit==true

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(105, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 53 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                                                        (args) =>GridDeleteButtonClick(args, soccerLeagueTransferAppModelsConDataPlayer)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(106, "onclick", 
#line 53 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                                                                                                                                                                                                                                                     true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(107, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(109, (__value) => {
#line 16 "C:\SoccerLeagueTransfer\server\Pages\Players.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.Player>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
