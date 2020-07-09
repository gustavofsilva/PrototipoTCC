using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsDesktopPrototipo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Visualizador de Código";
            //richTextBox1.LoadFile("C:\\Users\\PICHAU\\source\\repos\\PrototipoTCC\\WindowsDesktopPrototipo\\codigoValidacao.rtf");
            richTextBox1.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "\\codigoValidacao.rtf");
        }

        
        public void textboxVerdeNome()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            string codigoNome = "if (pessoa.nome.Any(char.IsNumber))            {                LabelNome.Text = 'Nome com números!';                 return; ;";
            form1.richTextBox1.Select(richTextBox1.Find("if (pessoa.nome.Any(char.Is", RichTextBoxFinds.MatchCase), codigoNome.Length);
            form1.richTextBox1.SelectionColor = Color.Green;
        }

        
        public void startForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            //Thread tr = new Thread(Show);
            //tr.Start(tr);
            Thread _thread = new Thread(() =>
            {
                Application.Run(new Form1());
            });
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        public void textboxVerdeEmail()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;            
            string codigoNome = "if (!pessoa.email.Contains('@'))                {                LabelEmail.Text = 'Email precisa ter um @';                    return;            }            ";
            form1.richTextBox1.Select(richTextBox1.Find("if (!pessoa.email.Co", RichTextBoxFinds.MatchCase), codigoNome.Length);            
            form1.richTextBox1.SelectionColor = Color.Green;
        }

        public void textboxVerdeCPF()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            string codigoNome = "if (pessoa.cpf.Any(char.IsLetter))                    {                LabelCPF.Text = 'CPF inválido!';                return;            }            ";
            form1.richTextBox1.Select(richTextBox1.Find("if (pessoa.cpf.Any(c", RichTextBoxFinds.MatchCase), codigoNome.Length);
            form1.richTextBox1.SelectionColor = Color.Green;
        }

        public void textboxVerdeSenhaAllNumeros()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            string codigoNome = "if (pessoa.senha.All(char.IsLetter))                 {                 LabelSenha.Text = 'Senha precisa conter números!';                  return;             }             ";
            form1.richTextBox1.Select(richTextBox1.Find("if (pessoa.senha.All(char.IsLette", RichTextBoxFinds.MatchCase), codigoNome.Length);
            form1.richTextBox1.SelectionColor = Color.Green;
        }

        public void texboxVerdeSenhaAllLetras()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            string codigoNome = "if (pessoa.senha.All(char.IsNumber))                     {                         LabelSenha.Text = 'Senha precisa conter letras!';                 return;             }             ";
            form1.richTextBox1.Select(richTextBox1.Find("if (pessoa.senha.All(char.IsNumber", RichTextBoxFinds.MatchCase), codigoNome.Length);
            form1.richTextBox1.SelectionColor = Color.Green;
        }

        public void textboxSenhaDiferente()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            string codigoNome = "if (!(pessoa.senhaConfirma == pessoa.senha))             {                     LabelSenhaConfirma.Text = 'Senhas diferentes!';                 return;             }             ";
            form1.richTextBox1.Select(richTextBox1.Find("if (!(pessoa.senhaConfirma == pessoa.senha", RichTextBoxFinds.MatchCase), codigoNome.Length);
            form1.richTextBox1.SelectionColor = Color.Green;
        }

        public void textboxIdadeVerde()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            string codigoNome = "try             {                     pessoa.idade = Convert.ToInt32(TextBoxIdade.Text);             }             catch             {                 LabelIdade.Text = 'Idade inválida!';                 return;             }             ";
            form1.richTextBox1.Select(richTextBox1.Find("pessoa.idade = Conver", RichTextBoxFinds.MatchCase), codigoNome.Length);
            form1.richTextBox1.SelectionColor = Color.Green;

            
        }
    }
}
