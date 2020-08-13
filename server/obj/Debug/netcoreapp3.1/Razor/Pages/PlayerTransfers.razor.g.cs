#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79d24a308bdd3828c0a18b3cf7b882478bf54f95"
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
#line 5 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/player-transfers")]
    public partial class PlayerTransfers : SoccerLeagueTransferApp.Pages.PlayerTransfersComponent
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
                __builder2.AddAttribute(6, "Text", "Player Transfers");
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
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                                     getPlayerTransfersResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>(this, 
#line 16 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                                                                                                                                         Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(28);
                    __builder3.AddAttribute(29, "Property", "TransferID");
                    __builder3.AddAttribute(30, "Title", "Transfer ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(32);
                    __builder3.AddAttribute(33, "Property", "PlayerID");
                    __builder3.AddAttribute(34, "SortProperty", "Player.FirstName");
                    __builder3.AddAttribute(35, "FilterProperty", "Player.FirstName");
                    __builder3.AddAttribute(36, "Title", "Player");
                    __builder3.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(38, "\n              ");
                        __builder4.AddContent(39, 
#line 22 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                data.Player?.FirstName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(40, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(42);
                    __builder3.AddAttribute(43, "Property", "OriginatingClubID");
                    __builder3.AddAttribute(44, "SortProperty", "ClubDetail.TeamName");
                    __builder3.AddAttribute(45, "FilterProperty", "ClubDetail.TeamName");
                    __builder3.AddAttribute(46, "Title", "Club Detail");
                    __builder3.AddAttribute(47, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(48, "\n              ");
                        __builder4.AddContent(49, 
#line 27 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                data.ClubDetail?.TeamName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(50, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(52);
                    __builder3.AddAttribute(53, "Property", "DestinationClubID");
                    __builder3.AddAttribute(54, "SortProperty", "ClubDetail1.TeamName");
                    __builder3.AddAttribute(55, "FilterProperty", "ClubDetail1.TeamName");
                    __builder3.AddAttribute(56, "Title", "Club Detail");
                    __builder3.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(58, "\n              ");
                        __builder4.AddContent(59, 
#line 32 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                data.ClubDetail1?.TeamName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(60, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(62);
                    __builder3.AddAttribute(63, "Property", "TransferDate");
                    __builder3.AddAttribute(64, "FormatString", "{0:dd/MM/yyyy}");
                    __builder3.AddAttribute(65, "Title", "Transfer Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(67);
                    __builder3.AddAttribute(68, "Property", "TransferTypeID");
                    __builder3.AddAttribute(69, "SortProperty", "TransferType.TransferTypeName");
                    __builder3.AddAttribute(70, "FilterProperty", "TransferType.TransferTypeName");
                    __builder3.AddAttribute(71, "Title", "Transfer Type");
                    __builder3.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(73, "\n              ");
                        __builder4.AddContent(74, 
#line 39 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                data.TransferType?.TransferTypeName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(75, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(77);
                    __builder3.AddAttribute(78, "Property", "TransferFee");
                    __builder3.AddAttribute(79, "Title", "Transfer Fee");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(81);
                    __builder3.AddAttribute(82, "Property", "SignOnFee");
                    __builder3.AddAttribute(83, "Title", "Sign On Fee");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(85);
                    __builder3.AddAttribute(86, "Property", "TransferAgent");
                    __builder3.AddAttribute(87, "Title", "Transfer Agent");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(89);
                    __builder3.AddAttribute(90, "Property", "AgentFee");
                    __builder3.AddAttribute(91, "Title", "Agent Fee");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>>(93);
                    __builder3.AddAttribute(94, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 50 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(95, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 50 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                                                         false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "Width", "70px");
                    __builder3.AddAttribute(97, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 50 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                                                                                        TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(98, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>)((soccerLeagueTransferAppModelsConDataPlayerTransfer) => (__builder4) => {
                        __builder4.AddMarkupContent(99, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(100);
                        __builder4.AddAttribute(101, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 52 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(102, "Icon", "close");
                        __builder4.AddAttribute(103, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 52 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(104, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 52 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, soccerLeagueTransferAppModelsConDataPlayerTransfer)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(105, "onclick", 
#line 52 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                                                                                                                                                                                                                                  true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(106, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(108, (__value) => {
#line 16 "C:\SoccerLeagueTransfer\server\Pages\PlayerTransfers.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.PlayerTransfer>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
