using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrototipoTCC
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text;
            string senha = TextBoxSenha.Text;
            if (!email.Contains("@"))
            {
                LabelResult.Text = "Email invalido!";
                return;
            } else
            {
                LabelResult.Text = "";
            }
            if (senha.All(char.IsLetter) || senha.All(char.IsNumber))
            {
                LabelResult.Text = "Senha inválida!";
                return;
            }

            Response.Redirect("/Logado.aspx");
        }
    }
}