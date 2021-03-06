﻿using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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

        // Allows selection of all for easy editing
        private void TextBoxTitle_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (e.KeyboardDevice.IsKeyDown(Key.Tab) && textBox != null && !textBox.IsReadOnly)
            {
                (textBox).SelectAll();
            }
        }

        private void TextBox_OnGotMouseCapture(object sender, MouseEventArgs e)
        {
            var textBox = sender as TextBox;
            textBox?.SelectAll();
        }

        // Makes sure the combobox folds out when focused by keyboard
        private void ComboBox_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;

            if (e.KeyboardDevice.IsKeyDown(Key.Tab) && comboBox != null)
            {
                (comboBox).IsDropDownOpen = true;
            }
        }

        // Setting red markers on required boxes
        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            textBox.BorderBrush = string.IsNullOrWhiteSpace(textBox.Text) ? Brushes.Red : null;
        }

        // To show default values in list boxes
        private void NewMonster_OnLoaded(object sender, RoutedEventArgs e)
        {
            MonsterSizeComboBox.SelectedItem = (MonsterSizeComboBox.ItemsSource as List<string>)?[0];
            MonsterTypeComboBox.SelectedItem = (MonsterTypeComboBox.ItemsSource as List<string>)?[0];
            MonsterAlignmentComboBox.SelectedItem = (MonsterAlignmentComboBox.ItemsSource as List<string>)?[0];
            MonsterSkill1ComboBox.SelectedItem = (MonsterSkill1ComboBox.ItemsSource as List<string>)?[0];
            MonsterSkill2ComboBox.SelectedItem = (MonsterSkill2ComboBox.ItemsSource as List<string>)?[0];
            MonsterSkill3ComboBox.SelectedItem = (MonsterSkill3ComboBox.ItemsSource as List<string>)?[0];
            MonsterSkill4ComboBox.SelectedItem = (MonsterSkill4ComboBox.ItemsSource as List<string>)?[0];
        }

        // Regex for numbers only
        private void UIElement_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[0-9]*$") || string.IsNullOrWhiteSpace(e.Text))
            {
                e.Handled = true;
            }
        }
    }
}