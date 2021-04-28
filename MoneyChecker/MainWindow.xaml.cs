using MoneyChecker.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoneyChecker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KeyValuePair<ToggleButton, Page> _currentTab;
        FrameViewController _frameViewController = new FrameViewController();
        TabViewController tabViewController = new TabViewController();
        public MainWindow()
        {
            InitializeComponent();
            /*MainWindowGrid.Children.Add(_frameViewController);
            _frameViewController.Background = Brushes.Red;
            Grid.SetRow(_frameViewController, 2);
            Grid.SetColumn(_frameViewController, 0);
            _currentTab = new KeyValuePair<ToggleButton, Page>(ToggleBut_Search, _frameViewController.SearchPage);
            _frameViewController.Navigate(_frameViewController.SearchPage);*/



            //tabViewController.AddTab(new TabViewControl(TabViewControl.GetToggleButton("images/research.png", "Обзор"), new SearchPage()));
            //tabViewController.AddTab(new TabViewControl(TabViewControl.GetToggleButton("images/money-transfer.png", "Транзакции"), new TransactionPage()));
            //tabViewController.AddTab(new TabViewControl(TabViewControl.GetToggleButton("images/calendar.png", "Календарь"), new CalendarPage()));

            // -------------------------------------------------  my code
            tabViewController.AddTab("images/cash-flow.png", "Бюджет", new BudgetPage()); // ?
            tabViewController.AddTab("images/calendar.png", "Календарь", new CalendarPage());
            tabViewController.AddTab("images/categories.png", "Категории", new CategoriesPage());
            tabViewController.AddTab("images/bill.png", "Валюты", new CurrenciesPage()); // ? 
            tabViewController.AddTab("images/debt.png", "Долги", new DebtsPage());
            tabViewController.AddTab("images/invoices.png", "Счета", new InvoicesPage());
            tabViewController.AddTab("images/settings.png", "Настройки", new OptionsPage()); 
            tabViewController.AddTab("images/analysis.png", "Отчеты", new ReportsPage()); // ? 
            tabViewController.AddTab("images/schedule.png", "Планировщик", new SchedulerPage());
            tabViewController.AddTab("images/research.png", "Обзор", new SearchPage());
            tabViewController.AddTab("images/money-transfer.png", "Транзакции", new TransactionPage());
            tabViewController.AddTab("images/group.png", "Пользователи", new UsersPage());
            // -------------------------------------------------  my code


            MainWindowGrid.Children.Add(tabViewController.Body);
            Grid.SetRow(tabViewController.Body, 1);
            Grid.SetColumn(tabViewController.Body, 0);

        }


        //private void ToggleBut_Search_Click(object sender, RoutedEventArgs e)
        //{
        //    // _currentTab.Key.IsChecked = false;
        //    _currentTab = new KeyValuePair<ToggleButton, Page>((ToggleButton)sender, _frameViewController.SearchPage);
        //    _frameViewController.ChangeTab(_currentTab);
        //}
        //private void ToggleBut_Transaction_Click(object sender, RoutedEventArgs e)
        //{
        //    _currentTab.Key.IsChecked = false;
        //    _currentTab = new KeyValuePair<ToggleButton, Page>((ToggleButton)sender, _frameViewController.TransactionPage);
        //    _frameViewController.ChangeTab(_currentTab);
        //}
    }
}
