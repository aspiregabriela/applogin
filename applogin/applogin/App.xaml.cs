using System;
using Xamarin.Forms;
using Xamarim.Forms.Xaml;
using System.Collections.Generic;


using applogin.View;
using applogin.Model;

namespace applogin
{
    public partial class App : Application
    {
        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "aspiregabriela@gmail.com",
                Nome  = "Aluno",
                Senha = "123"
            },

            new DadosUsuario()
            {
                Email = "aspiregeovane@gmail.com",
                Nome  = "Coordenador",
                Senha = "456"
            }
        };

        public App ()
        {
            InitializeComponent();
            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new login();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }

}