using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

namespace BSNTools.UI.Controls
{
    public partial class NumericSystemsConversionControl : UserControl
    {
        private long _currentValue = 0;
        private bool _isUpdating = false;

        public NumericSystemsConversionControl()
        {
            InitializeComponent();
        }

        private void InputTextBoxExts_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            TextBoxExt tb = (TextBoxExt)sender;

            if (string.IsNullOrEmpty(tb.Text)) return;

            try
            {
                // 1. Convert input to the "Source of Truth"
                _currentValue = tb.Name switch
                {
                    "DecimalTextBoxExt" => Convert.ToInt64(tb.Text, 10),
                    "BinaryTextBoxExt" => Convert.ToInt64(tb.Text, 2),
                    "HexTextBoxExt" => Convert.ToInt64(tb.Text, 16),
                    "OctalTextBoxExt" => Convert.ToInt64(tb.Text, 8),
                    _ => 0
                };

                // 2. Update all other boxes
                UpdateAllFields(tb);
            }
            catch { /* Handle invalid input silently or show error */ }
        }

        private void UpdateAllFields(TextBoxExt source)
        {
            _isUpdating = true; // Lock events

            if (source != DecimalTextBoxExt) DecimalTextBoxExt.Text = _currentValue.ToString();
            if (source != BinaryTextBoxExt) BinaryTextBoxExt.Text = Convert.ToString(_currentValue, 2);
            if (source != HexTextBoxExt) HexTextBoxExt.Text = Convert.ToString(_currentValue, 16).ToUpper();
            if (source != OctalTextBoxExt) OctalTextBoxExt.Text = Convert.ToString(_currentValue, 8);

            _isUpdating = false; // Unlock events
        }



        private void InputTextBoxExts_KeyDown(object sender, KeyEventArgs e)
        {
            TextBoxExt control = (TextBoxExt)sender;

            Keys key = e.KeyCode & Keys.KeyCode;

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                return;
            }

            if (control == DecimalTextBoxExt)
            {
                if ((key >= Keys.NumPad0 && key <= Keys.NumPad9) ||
                    (key >= Keys.D0 && key <= Keys.D9) ||
                    key == Keys.Back ||
                    key == Keys.Left ||
                    key == Keys.Right ||
                    key == Keys.Tab ||
                    key == Keys.Delete)
                {
                    // valid key
                }
                else
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
            }
            else if (control == BinaryTextBoxExt)
            {
                if (key == Keys.D0 ||
                    key == Keys.D1 ||
                    key == Keys.NumPad0 ||
                    key == Keys.NumPad1 ||
                    key == Keys.Back ||
                    key == Keys.Left ||
                    key == Keys.Right ||
                    key == Keys.Tab ||
                    key == Keys.Delete)
                {
                    // valid key
                }
                else
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
            }
            else if (control == HexTextBoxExt)
            {
                if ((key >= Keys.D0 && key <= Keys.D9) ||
                    (key >= Keys.A && key <= Keys.F) ||
                    (key >= Keys.NumPad0 && key <= Keys.NumPad9) ||
                    key == Keys.Back ||
                    key == Keys.Left ||
                    key == Keys.Right ||
                    key == Keys.Tab ||
                    key == Keys.Delete)
                {
                    // valid key
                }
                else
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
            }
            else if (control == OctalTextBoxExt)
            {
                if ((key >= Keys.D0 && key <= Keys.D7) ||
                    (key >= Keys.NumPad0 && key <= Keys.NumPad7) ||
                    key == Keys.Back ||
                    key == Keys.Left ||
                    key == Keys.Right ||
                    key == Keys.Tab ||
                    key == Keys.Delete)
                {
                    // valid key
                }
                else
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
            }


        }
    }
}
