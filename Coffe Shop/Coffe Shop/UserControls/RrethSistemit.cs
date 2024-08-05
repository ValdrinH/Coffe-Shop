namespace Coffe_Shop.UserControls
{
    public partial class RrethSistemit : UserControl
    {
        public RrethSistemit()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {

            lblTitle.Location = new Point((panel2.Width - lblTitle.Width) / 2, lblTitle.Location.Y);
            lblSubtitle.Location = new Point((panel2.Width - lblSubtitle.Width) / 2, lblSubtitle.Location.Y);
            lblVersion.Location = new Point((panel2.Width - lblVersion.Width) / 2, lblVersion.Location.Y);
            btnUpdate.Location = new Point((panel2.Width - btnUpdate.Width) / 2, btnUpdate.Location.Y);

            lblContact.Location = new Point((panel4.Width - lblContact.Width) / 2, lblContact.Location.Y);
            btnContact.Location = new Point((panel4.Width - btnContact.Width) / 2, btnContact.Location.Y);



            // Vendosni tekstin në RichTextBox duke përdorur HTML
            richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033
            {\fonttbl{\f0\fnil\fcharset0 Calibri;}}
            {\*\generator Riched20 10.0.18362}\viewkind4\uc1 
            \pard\sa200\sl276\slmult1\f0\fs22\lang1033
            Ky sistem i kafenesë ofron një zgjidhje të plotë dhe të integruar për menaxhimin e çdo aspekti të aktivitetit tuaj. Ai përfshin veçoritë e mëposhtme:\par
            \par
            \b Menaxhimi i Stokut:\b0\par
            Sistemi ju mundëson të mbani një pasqyrë të saktë të inventarit dhe të menaxhoni ndërrimin e stokut në mënyrë efikase, duke ndihmuar në parandalimin e mungesave dhe mbiprodhimeve.\par
            \par
            \b Menaxhimi i Porosive:\b0\par
            Ju mund të pritni dhe përpunoni porositë e klientëve në mënyrë të thjeshtë dhe të shpejtë, duke përfshirë mundësinë për të regjistruar porosi për të marrë dhe për të dorëzuar, duke garantuar një shërbim të shpejtë dhe të saktë.\par
            \par
            \b Menaxhimi i Shitjeve:\b0\par
            Sistemi regjistron dhe analizon të gjitha transaksionet e shitjeve, duke ofruar një pasqyrë të qartë të performancës së biznesit tuaj dhe mundësinë për të marrë vendime të informuara për rritjen e shitjeve.\par
            \par
            \b Menaxhimi i Tavolinave:\b0\par
            Koordinoni dhe menaxhoni tavolinat e kafenesë për të optimizuar hapësirën dhe për të përmirësuar përvojën e klientëve, duke bërë të mundur një menaxhim të efektshëm të hapësirës.\par
            \par
            \b Menaxhimi i Punëtorëve:\b0\par
            Sistemi ndihmon në menaxhimin e stafit tuaj duke ndjekur oraret, detyrat dhe performancën e tyre, duke e bërë më të lehtë organizimin dhe optimizimin e punës.\par
            \par
            \b Autentikimi dhe Ruajtja e Të Dhënave të Sigurta:\b0\par
            Të dhënat e klientëve dhe transaksionet janë të mbrojtura me një sistem të fuqishëm autentikimi dhe ruajtjeje të të dhënave, duke garantuar sigurinë dhe privatësinë e informacionit të ndjeshëm.\par
            \par
            \b Përdorimi dhe Kushtet:\b0\par
            Ky sistem është krijuar dhe zhvilluar nga Valdrin Hasallari dhe është në përkujdesjen e tij të vazhdueshme. Përdorimi i sistemit është i rregulluar nga këto kushte:\par
            \par
            \b Përdorimi i Lejuar:\b0\par
            Ky sistem është i dedikuar për përdorim të brendshëm dhe nuk lejohet keqpërdorimi i tij në asnjë mënyrë. Modifikimi, shitja, ose transferimi i sistemit ose i elementeve të tij pa lejen e shprehur të zhvilluesit është i ndaluar.\par
            \par
            \b Ndalohet Shkurtimi dhe Fshirja e Elementeve:\b0\par
            Fshirja, ndërrimi, ose manipulimi i elementeve të sistemit pa autorizim do të rezultojë në anulimin e kontratës dhe fshirjen automatike të të dhënave nga sistemi.\par
            \par
            \b Ruajtja e Të Dhënave dhe Siguria:\b0\par
            Çdo informacion dhe të dhëna që mbahen nga ky sistem janë të mbrojtura dhe duhet të ruhen në përputhje me standardet më të larta të sigurisë. Zhvilluesi është përgjegjës për mirëmbajtjen e sigurisë së të dhënave dhe çdo shkelje e këtyre standardeve do të merret seriozisht.\par
            \par
            \b Kontakti për Ndihmë dhe Mirëmbajtje:\b0\par
            Për çdo ndihmë, pyetje, ose kërkesë për ndryshime, ju lutem kontaktoni Valdrin Hasallari në adresën e tij të emailit ose në kontaktet e ofruara në dokumentacionin e sistemit.\par
            \par
            Faleminderit që zgjodhët sistemin tonë dhe për respektimin e kushteve të përdorimit.\par
            }";


            base.OnLoad(e);
        }
        private void RrethSistemit_Load(object sender, EventArgs e)
        {

        }
    }
}
