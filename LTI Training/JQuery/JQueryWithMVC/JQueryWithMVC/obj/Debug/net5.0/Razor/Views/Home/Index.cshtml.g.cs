#pragma checksum "F:\LTI Training\JQuery\JQueryWithMVC\JQueryWithMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97efc645df9ea402be0780e29dc429e69d4a466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\LTI Training\JQuery\JQueryWithMVC\JQueryWithMVC\Views\_ViewImports.cshtml"
using JQueryWithMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\LTI Training\JQuery\JQueryWithMVC\JQueryWithMVC\Views\_ViewImports.cshtml"
using JQueryWithMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97efc645df9ea402be0780e29dc429e69d4a466", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d946e7933b0ea348a83eb2acb08697ab22237451", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "MH", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Mp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\LTI Training\JQuery\JQueryWithMVC\JQueryWithMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97efc645df9ea402be0780e29dc429e69d4a4665000", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
  .Highlight{
      background-color:yellow;
  }
</style>

<script type=""text/javascript"">
    $(document).ready(function () {
        $('div.ccl').attr({
            title: 'Some Title',


        }).css({                                                 //aplying css
            'background-color': 'purple',
            'color': 'White',
            'font-size': '20pt',

        }).text('change Text');                                     //change text
        $('div.text-center').css('background-color','green');

        //modifying Dom
        $('#btn').click(function () {

            $('span').append('<span style=""color:blue"">Apppended to1</span>');
        });
       
        //Wrap 

        $('div.ccl').wrap('<div class=""text-center ParentWrapper""/>');

        //Remove

       // $('div.ParentWrapper').remove();



        //Modifying style demo



        //Class Function

        $('input[type=""text""]').addClass('Highlight');   // apply color

");
            WriteLiteral(@"
        $('#LastName').removeClass('Highlight');     // remove Color


        WritetextUsingEvent();




        // handle select 

        $('#stateselect').change(function () {
            alert($(this).val());
        });


        //mouse Event : when curssor over textr change the backgound color
        /*
        $('.mydiv').mouseenter(function () {

            $(this).toggleClass('Highlight');
        })
            .mouseleave(function () {
                $(this).toggleClass('Highlight')
                $(this).css('cursor', 'pointer');

            })
            .mouseup(function (e) {
                $(this).text('X' + e.pageX +' ' + 'y:' + e.pageY);  //change the x and y Axix value when click
            })
            */

        //Handling Multiple Events

        $('.mydiv').on('mouseenter mouseleave mouseup', function (e) {
            $(this).toggleClass('Highlight')
            $(this).css('cursor', 'pointer');


            if (e.type == 'mouseup')");
            WriteLiteral(@" {
                $(this).text('X' + e.pageX + ' ' + 'y:' + e.pageY);  //change the x and y Axix value when click
            }

        })
       

    });

    function FocusBlure(tb)
    {
        $(tb).toggleClass('Highlight');     //toggle Class : Change The color Backgrond color of textbox

    }


    function WritetextUsingEvent() {                                                //Event Handling Function


        $('#Eventhandling').click(function() {
            var FirstNameVal = $('#FirstName').val();
            var LastName = $('#LastName').val();
            var Email = $('Email').val();
            var mobileno = $('mobileno').val();


            $('#output').text(FirstNameVal + ' ' + LastName);
            //$('output').text(Email);
            //$('output').text(mobileno);



        });

    }

</script>
<div class=""text-center"">
    <h1 class=""display-7"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web ap");
            WriteLiteral(@"ps with ASP.NET Core</a>.</p>
    
    
    <div class=""mydiv"">this is a some text</div>
    
</div>
<div class=""ccl"">
    <span>
       span tag
    </span>
</div>
<div class=""ccl"">
    <span>
       span tag
    </span>
</div>
<div class=""lcc"">
    <span>
        span tag
    </span>
</div>
<div class=""ccl"">
    <span>
        span tag
    </span>
</div>
<br />

<br />
<label>First Name</label>
<input type=""text""   id=""FirstName"" onfocus="" FocusBlure(this)"" onblur="" FocusBlure(this)"" />
<label>Last Name</label>
<input type=""text"" id=""LastName""  onfocus="" FocusBlure(this)"" onblur="" FocusBlure(this)"" />

<label>Email</label>
<input type=""text"" id=""Email"" onfocus=""  FocusBlure(this)"" onblur="" FocusBlure(this)""/>
<label>Mobile No:</label>
<input type=""text"" id=""Mobileno""  onfocus="" FocusBlure(this)"" onblur="" FocusBlure(this)"" />

<select id=""stateselect"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97efc645df9ea402be0780e29dc429e69d4a46610255", async() => {
                WriteLiteral("MH");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97efc645df9ea402be0780e29dc429e69d4a46611415", async() => {
                WriteLiteral("Ap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97efc645df9ea402be0780e29dc429e69d4a46612575", async() => {
                WriteLiteral("Mp");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</select>\r\n\r\n\r\n<button id=\"btn\">Appended text</button>\r\n\r\n<button id=\"Eventhandling\">Submit</button>\r\n\r\n\r\n<h3 id=\"output\"></h3>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591