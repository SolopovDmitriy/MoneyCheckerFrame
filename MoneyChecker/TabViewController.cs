using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;

namespace MoneyChecker
{
    class TabViewController
    {
        private Grid _bodyControl;

        private  List<TabViewControl> _tabs = new List<TabViewControl>();

        private ToolBar _toolBar;
        private Frame _frame;
        public Grid Body
        {
            get
            {
                return _bodyControl;
            }
        }
        public TabViewController()
        {
              //  < Grid x: Name = "MainWindowGrid" >
      
              //< Grid.RowDefinitions>  
              //    < RowDefinition></ RowDefinition >   
              //     < RowDefinition></ RowDefinition > 
              //  </ Grid.RowDefinitions >    

              //  < Grid.ColumnDefinitions >    
              //      < ColumnDefinition ></ ColumnDefinition >    
              //  </ Grid.ColumnDefinitions >

            _bodyControl = new Grid();            
            _bodyControl.RowDefinitions.Add(new RowDefinition());
            _bodyControl.RowDefinitions.Add(new RowDefinition());
            _bodyControl.ColumnDefinitions.Add(new ColumnDefinition());


             // < ToolBar Grid.Row = "1" Grid.Column = "0" Height = "60" VerticalAlignment = "Top" >
            _toolBar = new ToolBar() { VerticalAlignment = System.Windows.VerticalAlignment.Top, Height = 60};
            Grid.SetRow(_toolBar, 0);
            Grid.SetColumn(_toolBar, 0);

            _frame = new Frame();

            Grid.SetRow(_frame, 1);
            Grid.SetColumn(_frame, 0);

            _bodyControl.Children.Add(_toolBar);
            _bodyControl.Children.Add(_frame);
        }

        private void renderTab(TabViewControl tabViewControl)
        {
            //tabViewControl.Tab.Key : 
            //< ToggleButton FontFamily = "Consolas" > 
            //     < WrapPanel Orientation = "Vertical" >  
            //          < Image Source = "images/settings.png" Height = "25" />     
            //             < TextBlock VerticalAlignment = "Center" HorizontalAlignment = "Center" > Настройки </ TextBlock >        
            //     </ WrapPanel >        
            // </ ToggleButton >

            // -------------------------------------------------  my code
            ToggleButton toggleButton = tabViewControl.Tab.Key;
            toggleButton.Click += ToggleButton_Click;
            _toolBar.Items.Add(toggleButton);

            Page page = tabViewControl.Tab.Value;
            _frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            _frame.Navigate(page); // tabViewControl.Tab.Value = page
            // -------------------------------------------------  my code

        }


        // -------------------------------------------------  my code
        private void ToggleButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {     
            ToggleButton toggleButtonClicked = (ToggleButton)sender;
            toggleButtonClicked.IsChecked = true; // currTab.Key.IsChecked = true;
            foreach (TabViewControl tabViewControl  in _tabs)
            {
                if(tabViewControl.Tab.Key== toggleButtonClicked)
                {
                    _frame.Navigate(tabViewControl.Tab.Value);  //this.Navigate(currTab.Value);
                }
            }           
        }
        // -------------------------------------------------  my code



        //  public TabViewControl (ToggleButton toggleButton, Page page){ - constructor
        // new TabViewControl(TabViewControl.GetToggleButton("images/research.png", "Обзор"), new SearchPage())
        public void AddTab(TabViewControl tabViewControl) 
        {
            _tabs.Add(tabViewControl);
            renderTab(tabViewControl);
        }


        // -------------------------------------------------  my code
        //  "images/research.png", "Обзор", new SearchPage()
        public void AddTab(string imagePath, string buttonText, Page page)
        {
            ToggleButton toggleButton = TabViewControl.GetToggleButton(imagePath, buttonText);  
            TabViewControl tabViewControl = new TabViewControl(toggleButton, page);
            _tabs.Add(tabViewControl);
            renderTab(tabViewControl);
        }
        // -------------------------------------------------  my code

    }
}
