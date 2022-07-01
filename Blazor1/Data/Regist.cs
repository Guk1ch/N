using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Blazor1.Pages;


namespace Blazor1.Data
{

    public class Regist : ModalTemplate
    {
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Регистрация");
            };
        }

        protected override RenderFragment Body()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Name");
                builder.OpenElement(2, "div");
                builder.OpenElement(3, "input");
                builder.CloseElement();
                builder.CloseElement();
                builder.AddContent(4, "Surname");
                builder.OpenElement(5, "div");
                builder.OpenElement(6, "input");
                builder.CloseElement();
                builder.CloseElement();

            };
        }

        protected override RenderFragment Footer()
        {
            int seq = 0;
            return (builder) =>
            {
                builder.OpenElement(++seq, "button");
                builder.AddAttribute(++seq, "type", "button");
                builder.AddAttribute(++seq, "class", "btn btn-success");
                builder.AddAttribute(++seq, "data-dismiss", "modal");
                builder.AddAttribute(++seq, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, Close));
                builder.AddContent(++seq, "Зарегистрироваться");
                builder.CloseElement();
            };
        }
        private void Reg (string name, string surname)
        {
                     
        }
    }
  }

