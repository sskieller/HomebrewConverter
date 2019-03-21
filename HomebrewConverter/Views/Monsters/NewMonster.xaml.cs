using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomebrewConverter.Views.Monsters
{
    /// <summary>
    /// Interaction logic for NewMonster.xaml
    /// </summary>
    public partial class NewMonster : UserControl
    {
        public NewMonster()
        {
            InitializeComponent();
        }

        private void TextBoxTitle_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (e.KeyboardDevice.IsKeyDown(Key.Tab) && textBox != null && !textBox.IsReadOnly)
            {
                (textBox).SelectAll();
            }
        }

        private void ComboBox_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;

            if (e.KeyboardDevice.IsKeyDown(Key.Tab) && comboBox != null)
            {
                (comboBox).IsDropDownOpen = true;
            }
        }
    }
}
