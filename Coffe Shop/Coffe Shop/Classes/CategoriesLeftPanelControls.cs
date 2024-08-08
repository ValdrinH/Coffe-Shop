using Coffe_Shop.UserControls.DashboardElementsControl;
using Coffe_Shop.UserControls.DashboardElementsControl.ElementControl;

namespace Coffe_Shop.Classes
{
    public class CategoriesLeftPanelControls
    {
        private static FlowLayoutPanel LeftSide;
        private static Panel dashboardControl;
        private static List<Button> _Buttons = new List<Button>();


        public static void SetLeftPanel(FlowLayoutPanel panel) { LeftSide = panel; }
        public static void SetDashboardPanel(Panel panel) { dashboardControl = panel; }

        public static void UpdateButtonName(string name, int Id)
        {
            var selectedButton = LeftSide.Controls.OfType<Button>()
               .FirstOrDefault(button => button.Tag.ToString() == Id.ToString());

            selectedButton.Text = name;
        }

        public static void AddButtons(string Text, int Id)
        {
            var btn = GetButtonTemplate(Text, Id);
            LeftSide.Controls.Add(btn);
            _Buttons.Add(btn);
        }
        public static void RemoveButtons(int Id)
        {
            var selectedButton = LeftSide.Controls.OfType<Button>()
                .FirstOrDefault(button => button.Tag.ToString() == Id.ToString());

            LeftSide.Controls.Remove(selectedButton);
            _Buttons.Remove(selectedButton);
        }
        private static Button GetButtonTemplate(string text, int Id)
        {
            var btn = new Button()
            {
                Text = text,
                FlatStyle = FlatStyle.Flat, // Përcakton stilin flat të Button
                BackColor = Color.FromName("OliveDrab"),     // Përcakton ngjyrën e sfondit të Button (ndryshoni sipas dëshirës)
                ForeColor = Color.White,    // Përcakton ngjyrën e tekstit të Button (ndryshoni sipas dëshirës)
                AutoSize = true,            // Bën që madhësia e Button të përshtatet automatikisht bazuar në tekst
                Padding = new Padding(10, 5, 10, 5), // Përcakton mbushjen e brendshme të Button (ndryshoni sipas dëshirës)
                Tag = Id,
                Cursor = Cursors.Hand
            };

            // Shtimi i një ngjarje Click (mund ta ndryshoni sipas nevojës)
            btn.Click += (sender, e) =>
            {
                if (dashboardControl != null)
                {
                    //Selekto oftype Dashboard Control nese eshte ne Panel
                    var dash = dashboardControl.Controls.OfType<Dashboard>().FirstOrDefault();
                    if (dash == null) return;

                    var listofElements = dash.flowLayoutPanel.Controls
                       .OfType<Elements>()
                       .ToList();
                    if (btn.Text == "Të Gjitha")
                    {
                        listofElements.ForEach(el => el.Visible = true);
                        return;
                    }


                    // Kthehen në një listë për të shmangur enumerimin dy herë

                    // Përdorimi i LINQ për të vendosur 'Visible' për çdo element
                    listofElements.ForEach(element =>
                    {
                        element.Visible = element.Attributes.Any(attr => attr.ID == int.Parse(btn.Tag.ToString()));
                    });
                }
            };

            return btn;
        }

    }
}
