using Coffe_Shop.UserControls.CategoryControlElements;
using Coffe_Shop.UserControls.DashboardElementsControl;
using Coffe_Shop.UserControls.Porosit;
using Coffe_Shop.UserControls.Punetoret;
using Coffe_Shop.UserControls.SalesElement;
using Coffe_Shop.UserControls.StockElements;

namespace Coffe_Shop.Classes
{
    public class FormParentElements
    {
        public static UserControl LastControl;
        public static Form ParentForm;
        public static Label lblTavolina;
        public static List<Panel> pnls;

        public static void GoToControl(UserControl userControl)
        {
            var frm = ParentForm as Form1;
            frm.CallUserControl(userControl);
        }
        public static void GoToBackControl()
        {
            var frm = ParentForm as Form1;
            var newControl = (LastControl) switch
            {
                CategoryControlList category => new CategoryControlList(),
                Dashboard dashboard => new Dashboard(),
                StockList stockList => new StockList(),
                ListofOrders orders => new ListofOrders(),
                SaleControl control => new SaleControl(),
                ListofEmployees employees => new ListofEmployees(),


                _ => new UserControl()  // Rasti përgjithshëm, mund të përdorni UserControl ose vlerën që dëshironi
            };
            frm.CallUserControl(newControl);
        }

        /// <summary>
        /// Per te bere te gjitha controls enable false nese nuk eshte kyqur ose per te i bere enable true
        /// </summary>
        /// <param name="pnls"></param>
        public static void LoginIntoSystem(bool value)
        {
            pnls.ForEach(panel => panel.Enabled = value);
        }
    }
}
