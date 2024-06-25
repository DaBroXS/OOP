using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Controls;

namespace lr8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        }

        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var selection = rtbEditor.Selection;

            object temp = selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

            temp = selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));

            temp = selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;

            temp = selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp?.ToString();
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                using (FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open))
                {
                    TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                    range.Load(fileStream, DataFormats.Rtf);
                }
            }
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                using (FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create))
                {
                    TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                    range.Save(fileStream, DataFormats.Rtf);
                }
            }
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
            }
        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(cmbFontSize.Text, out double size))
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, size);
            }
        }
    }
}