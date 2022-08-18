using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace applogin.Model
{
    public class DadosUsuario : ContentPage
    {
        public DadosUsuario()
        { }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
    
    }
}