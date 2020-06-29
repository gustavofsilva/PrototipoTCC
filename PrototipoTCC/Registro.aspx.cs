using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrototipoTCC
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void ButtonConfirma_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = TextBoxNome.Text;
            pessoa.cpf = TextBoxCPF.Text;
            pessoa.senha = TextBoxSenha.Text;
            pessoa.senhaConfirma = TextBoxSenhaConfirma.Text;
            pessoa.email = TextBoxEmail.Text;
            WebDriver web = new WebDriver();

            TextBoxEscrever.BackColor = Color.White;
            if (pessoa.nome.Any(char.IsNumber))
            {
                LabelNome.Text = "Nome com números!";
                textBoxEscreverVerde();                  
                
                return;
            } else
            {
                if (pessoa.nome == "")
                {
                    LabelNome.Text = "Nome Vazio!";
                    return;
                } else
                {
                    LabelNome.Text = "";
                }
            }
            if (pessoa.email == "")
            {
                LabelEmail.Text = "Email vazio!";
                return;
            } else
            {
                if (!pessoa.email.Contains("@"))
                {
                    textBoxEscreverVerde();
                    LabelEmail.Text = "Email precisa ter um @";
                    return;
                }
                LabelEmail.Text = "";
            }
            if (pessoa.cpf == "")
            {
                LabelCPF.Text = "CPF vazio!";
                return;
            }
            else
            {
                if (pessoa.cpf.Any(char.IsLetter))
                {
                    LabelCPF.Text = "CPF inválido!";
                    textBoxEscreverVerde();
                    return;
                }
                else
                {
                    LabelCPF.Text = "";
                }
            }
            if (pessoa.senha == "")
            {
                LabelSenha.Text = "Senha vazia!";
                return;
            } else
            {
                if (pessoa.senha.All(char.IsLetter))
                {
                    textBoxEscreverVerde();
                    LabelSenha.Text = "Senha precisa conter números!";
                    return;
                } else
                {
                    if (pessoa.senha.All(char.IsNumber))
                    {
                        textBoxEscreverVerde();
                        LabelSenha.Text = "Senha precisa conter letras!";
                        return;
                    } else
                    {
                        LabelSenha.Text = "";
                    }
                    
                }
                
            }
            if (!(pessoa.senhaConfirma == pessoa.senha))
            {
                LabelSenhaConfirma.Text = "Senhas diferentes!";
                textBoxEscreverVerde();
                return;
            } else
            {
                if (pessoa.senhaConfirma == "")
                {
                    LabelSenhaConfirma.Text = "Senha vazia!";
                    return;
                } else
                {
                    LabelSenhaConfirma.Text = "";
                }
            }
            if (TextBoxIdade.Text == "")
            {
                LabelIdade.Text = "Idade vazia!";
                return;
            }
            try
            {
                pessoa.idade = Convert.ToInt32(TextBoxIdade.Text);
            }
            catch
            {
                textBoxEscreverVerde();
                LabelIdade.Text = "Idade inválida!";
                return;
            }
            //Response.Redirect("/Login.aspx");
            LabelResultadoFinal.Text = "TESTE REALIZADO COM SUCESSO!";
        }

        private void textBoxEscreverVerde()
        {
            TextBoxEscrever.BackColor = Color.LightGreen;
        }

        private void textBoxEscreverBranco()
        {
            TextBoxEscrever.BackColor = Color.White;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            WebDriver web = new WebDriver();
            IWebDriver driver = web.startTesteRegistro();

            
            web.escreveTesteCampoNome(driver);
            web.testeCampoNomeRegistro(driver);
            web.AtualizaPagina(driver);
            web.waitMiliSegundos(2000);

            web.AtualizaPagina(driver);
            web.escreveTesteCampoEmail(driver);
            web.testeCampoEmailRegistro(driver);
            web.AtualizaPagina(driver);
            web.waitMiliSegundos(2000);

            web.AtualizaPagina(driver);
            web.escreveTesteCampoCPF(driver);
            web.testeCampoCpfRegistro(driver);
            web.AtualizaPagina(driver);
            web.waitMiliSegundos(2000);

            web.AtualizaPagina(driver);
            web.escreveTesteCampoSenha(driver);
            web.testeCampoSenha(driver);
            web.AtualizaPagina(driver);
            web.waitMiliSegundos(2000);

            web.AtualizaPagina(driver);
            web.escreveTesteCampoSenhaConfirma(driver);
            web.testeCampoSenhaConfirma(driver);
            web.AtualizaPagina(driver);
            web.waitMiliSegundos(2000);

            web.AtualizaPagina(driver);
            web.escreveTesteCampoIdade(driver);
            web.testeCampoIdade(driver);
            web.AtualizaPagina(driver);
            web.waitMiliSegundos(2000);

            web.AtualizaPagina(driver);
            //web.escreveTesteOk(driver);
            web.testeRegistroOk(driver);
            web.waitMiliSegundos(2000);
        }

        private void ShowResult(string label)
        {
            //if (label.Equals("LabelNome"))
            //{
                if (LabelNome.Text.Equals("Nome com números!"))
                {
                    mudaCorTextArea("vermelho");
                }
                    
            //}
        }

        private void mudaCorTextArea(string cor)
        {
            TextBoxEscrever.BackColor = Color.Green;
            if (cor.Equals("verde"))
            {
                TextBoxEscrever.BackColor = Color.Green;
            }
            if (cor.Equals("vermelho"))
            {
                TextBoxEscrever.BackColor = Color.Red;
            }
        }

        private void updateTextArea(string v)
        {
            TextBoxEscrever.Text = v;
        }
    }
}