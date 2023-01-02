using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF_UI_AcademyDashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            members.Add(new Member { Number = "1", Character = "Q", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Quinter Oduor", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "2", Character = "S", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Samson Kamau", Position = "Administrator", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "3", Character = "J", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "James Smart", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "4", Character = "M", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Marshal Erickson", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "5", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Klark Kent", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "6", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Kortney Owino", Position = "Administrator", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "7", Character = "W", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Whitne Njoroge", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "8", Character = "O", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Optimus Prime", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "9", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Penina Kerubo", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "10", Character = "T", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Titus Mulama", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });


            members.Add(new Member { Number = "1", Character = "Q", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Quinter Oduor", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "2", Character = "S", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Samson Kamau", Position = "Administrator", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "3", Character = "J", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "James Smart", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "4", Character = "M", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Marshal Erickson", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "5", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Klark Kent", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "6", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Kortney Owino", Position = "Administrator", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "7", Character = "W", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Whitne Njoroge", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "8", Character = "O", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Optimus Prime", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "9", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Penina Kerubo", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "10", Character = "T", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Titus Mulama", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });


            members.Add(new Member { Number = "1", Character = "Q", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Quinter Oduor", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "2", Character = "S", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Samson Kamau", Position = "Administrator", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "3", Character = "J", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "James Smart", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "4", Character = "M", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Marshal Erickson", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "5", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Klark Kent", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "6", Character = "K", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Kortney Owino", Position = "Administrator", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "7", Character = "W", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Whitne Njoroge", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "8", Character = "O", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Optimus Prime", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "9", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Penina Kerubo", Position = "Manager", Email = "example.23@gmail.com", Phone = "342-342-3424" });
            members.Add(new Member { Number = "10", Character = "T", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Titus Mulama", Position = "Coach", Email = "example.23@gmail.com", Phone = "342-342-3424" });

            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private bool isMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (isMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Height = 720;
                    this.Width = 1000;
                    isMaximized = false;
                }
                else
                {

                    this.WindowState = WindowState.Maximized;
                    isMaximized = true;
                }
            }
        }

        public class Member
        {
            public string Character { get; set; }
            public string Number { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public Brush BgColor { get; set; }
        }

       


       private void checkAllButtons(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
