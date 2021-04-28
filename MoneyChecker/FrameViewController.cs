using MoneyChecker.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MoneyChecker
{
    class FrameViewController:Frame
    {
        public readonly InvoicesPage InvoicesPage = new InvoicesPage();
        public readonly BudgetPage BudgetPage = new BudgetPage();
        public readonly CalendarPage CalendarPage = new CalendarPage();
        public readonly CategoriesPage CategoriesPage = new CategoriesPage();
        public readonly CurrenciesPage CurrenciesPage = new CurrenciesPage();
        public readonly DebtsPage DebtsPage = new DebtsPage();
        public readonly OptionsPage OptionsPage = new OptionsPage();
        public readonly ReportsPage ReportsPage = new ReportsPage();
        public readonly SchedulerPage SchedulerPage = new SchedulerPage();
        public readonly SearchPage SearchPage = new SearchPage();
        public readonly TransactionPage TransactionPage = new TransactionPage();
        public readonly UsersPage UsersPage = new UsersPage();

        public FrameViewController()
        {
            //this.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            
        }

        public void ChangeTab(KeyValuePair<ToggleButton, Page> currTab) 
        {
            //this.Navigate(currTab.Value);
            //currTab.Key.IsChecked = true;
        }

    }
}
