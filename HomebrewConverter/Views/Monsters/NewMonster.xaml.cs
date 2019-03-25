using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        
        private void NewMonster_OnLoaded(object sender, RoutedEventArgs e)
        {
            MonsterSizeComboBox.SelectedItem = (MonsterSizeComboBox.ItemsSource as List<string>)?[0];
            MonsterTypeComboBox.SelectedItem = (MonsterTypeComboBox.ItemsSource as List<string>)?[0];
            MonsterAlignmentComboBox.SelectedItem = (MonsterAlignmentComboBox.ItemsSource as List<string>)?[0];
        }

        private void UIElement_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[0-9]*$") || string.IsNullOrWhiteSpace(e.Text))
                e.Handled = true;
        }
    }
}
