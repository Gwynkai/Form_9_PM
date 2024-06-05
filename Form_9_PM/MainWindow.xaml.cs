using Form_9_PM.Classes;
using System.Text;
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


namespace Form_9_PM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        User user = new User();

        public MainWindow()
        {
            InitializeComponent();
 

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "Введите имя" || box.Text == "Введите фамилию" || box.Text == "Введите отчество" || box.Text == "Введите возраст")
            {
                if (box.Text != null || box.Text != "")
                {
                    box.Text = "";
                    sender = box;
                }
            }
        }
        private void Popup_OnLoaded(object sender, EventArgs e)
        {
            PopupEducation.CustomPopupPlacementCallback = (popupSize, targetSize, offset) =>
            {
                return new[]
                {new CustomPopupPlacement(new Point(0, targetSize.Height - 1), PopupPrimaryAxis.None),};
            };
            PopupGender.CustomPopupPlacementCallback = (popupSize, targetSize, offset) =>
            {
                return new[]
                {new CustomPopupPlacement(new Point(0, targetSize.Height - 1), PopupPrimaryAxis.None),};
            };
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            user = new User();

            user.Name = FName.Text;
            user.LastName = LName.Text;
            user.Patronymic = Patro.Text;
            ///////////////////////////////////////////////////
            if (OutAge.Text == "Введите возраст" || OutAge.Text.Length == 0)
            {
                user.Age = 0;
            }
            else
            {
                user.Age = Convert.ToInt32(OutAge.Text);
            }
            ///////////////////////////////////////////////////
            if (Male.IsChecked == true)
            {
                user.GenderChoice = User.Gender.Мужчина;
            }
            else if (Female.IsChecked == true)
            {
                user.GenderChoice = User.Gender.Женщина;
            }
            ///////////////////////////////////////////////////
            if (Middle.IsChecked == true)
            {
                user.GradeChoice = User.Grade.Среднее;
            }
            else if (High.IsChecked == true)
            {
                user.GradeChoice = User.Grade.Высшее;
            }
            else if (DegreeM.IsChecked == true)
            {
                user.GradeChoice = User.Grade.Магистратура;
            }
            else if (Postgraduate.IsChecked == true)
            {
                user.GradeChoice = User.Grade.Аспирантура;
            }
            ///////////////////////////////////////////////////
            if (Yes.IsChecked == true)
            {
                user.Work = true;
            }
            else
            {
                user.Work = false;
            }
            ///////////////////////////////////////////////////
            //TextResults.Text = user.ToString();

            Form.Visibility = Visibility.Hidden;
            FormResult.Visibility = Visibility.Visible;
            TextResults.Text = user.ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FName.Text = "Введите имя";
            LName.Text = "Введите фамилию";
            Patro.Text = "Введите отчество";
            OutAge.Text = "Введите возраст";

            Male.IsChecked = false;
            Female.IsChecked = false;

            Middle.IsChecked = false;
            High.IsChecked = false;
            DegreeM.IsChecked = false;
            Postgraduate.IsChecked = false;


            Yes.IsChecked = false;
            No.IsChecked = false;

            Form.Visibility = Visibility.Visible;
            FormResult.Visibility = Visibility.Hidden;
        }


        public bool buttonCheck = false;

    }
}