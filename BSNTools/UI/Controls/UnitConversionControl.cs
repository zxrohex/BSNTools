using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

using UnitsNet;
using UnitsNet.Units;

namespace BSNTools.UI.Controls
{
    public partial class UnitConversionControl : UserControl
    {
        double unitValue = 1.0;

        double transferFirstUnitValue = 1.0;

        double transferSecondUnitValue = 1.0;

        bool isUpdating = false;


        bool isUpdatingTransfer = false;

        InformationUnit firstUnit = InformationUnit.Byte;

        InformationUnit secondUnit = InformationUnit.Bit;

        InformationUnit transferFirstUnit = InformationUnit.Megabyte;

        BitRateUnit transferSecondUnit = BitRateUnit.MegabitPerSecond;


        Information unitInfo => Information.FromBits(unitValue);

        Information transferFirstUnitInfo => Information.From(transferFirstUnitValue, transferFirstUnit);

        BitRate transferSecondUnitInfo => BitRate.From(transferSecondUnitValue, transferSecondUnit);

        public UnitConversionControl()
        {
            InitializeComponent();


            FirstUnitComboBoxAdv.Items.AddRange(Enum.GetValues<InformationUnit>().Cast<object>().ToArray());

            SecondUnitComboBoxAdv.Items.AddRange(Enum.GetValues<InformationUnit>().Cast<object>().ToArray());

            TransferFirstUnitComboBoxAdv.Items.AddRange(Enum.GetValues<InformationUnit>().Cast<object>().ToArray());

            TransferSecondUnitComboBoxAdv.Items.AddRange(Enum.GetValues<BitRateUnit>().Cast<object>().ToArray());



            FirstUnitComboBoxAdv.SelectedIndex = 1;

            SecondUnitComboBoxAdv.SelectedIndex = 0;
            
            TransferFirstUnitComboBoxAdv.SelectedIndex = 18;

            TransferSecondUnitComboBoxAdv.SelectedIndex = 17;

        }

        private void UpdateInputFields(NumericUpDownExt nud)
        {
            isUpdating = true;

            if (nud == FirstUnitNumericUpDownExt | nud == null) SecondUnitNumericUpDownExt.Value = (decimal)unitInfo.As(secondUnit);
            if (nud == SecondUnitNumericUpDownExt | nud == null) FirstUnitNumericUpDownExt.Value = (decimal)unitInfo.As(firstUnit);

            isUpdating = false;
        }

        private void UpdateTransferInputFields(NumericUpDownExt nud)
        {
            isUpdatingTransfer = true;

            if (nud == TransferFirstUnitNumericUpDownExt) TransferFirstUnitNumericUpDownExt.Value = (decimal)transferFirstUnitInfo.As(transferFirstUnit);
            if (nud == TransferSecondUnitNumericUpDownExt) TransferSecondUnitNumericUpDownExt.Value = (decimal)transferSecondUnitInfo.As(transferSecondUnit);

            isUpdatingTransfer = false;
        }

        private void UnitNumericUpDownExts_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            NumericUpDownExt nud = (NumericUpDownExt)sender;

            try
            {
                // 1. Convert input to the "Source of Truth"
                unitValue = nud.Name switch
                {
                    "FirstUnitNumericUpDownExt" => Information.From((double)nud.Value, firstUnit).Bits,
                    "SecondUnitNumericUpDownExt" => Information.From((double)nud.Value, secondUnit).Bits,
                    _ => 0
                };

                // 2. Update all other boxes
                UpdateInputFields(nud);
            }
            catch { /* Handle invalid input silently or show error */ }
        }

        private void UnitComboBoxAdvs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            ComboBoxAdv cb = (ComboBoxAdv)sender;

            if (cb == FirstUnitComboBoxAdv)
            {
                firstUnit = (InformationUnit)cb.SelectedItem;

                if (firstUnit == InformationUnit.Bit) FirstUnitNumericUpDownExt.DecimalPlaces = 0;
                else FirstUnitNumericUpDownExt.DecimalPlaces = 3;

            }
            else if (cb == SecondUnitComboBoxAdv)
            {
                secondUnit = (InformationUnit)cb.SelectedItem;

                if (secondUnit == InformationUnit.Bit) SecondUnitNumericUpDownExt.DecimalPlaces = 0;
                else SecondUnitNumericUpDownExt.DecimalPlaces = 3;
            }

            UpdateInputFields(null);
        }

        private void TransferUnitNumericUpDownExts_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdatingTransfer) return;

            NumericUpDownExt nud = (NumericUpDownExt)sender;

            try
            {
                // 1. Convert input to the "Source of Truth"
                if (nud.Name == "TransferFirstUnitNumericUpDownExt")
                {
                    transferFirstUnitValue = Information.From((double)nud.Value, transferFirstUnit).Bits;
                } 
                else
                {
                    transferSecondUnitValue = BitRate.From((double)nud.Value, transferSecondUnit).BitsPerSecond;
                }

                // 2. Update all other boxes
                UpdateTransferInputFields(nud);
            }
            catch { /* Handle invalid input silently or show error */ }
        }

        private void TransferUnitComboBoxAdvs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingTransfer) return;

            ComboBoxAdv cb = (ComboBoxAdv)sender;

            if (cb == TransferFirstUnitComboBoxAdv)
            {
                transferFirstUnit = (InformationUnit)cb.SelectedItem;

                if (transferFirstUnit == InformationUnit.Bit) TransferFirstUnitNumericUpDownExt.DecimalPlaces = 0;
                else TransferFirstUnitNumericUpDownExt.DecimalPlaces = 3;

                UpdateTransferInputFields(TransferFirstUnitNumericUpDownExt);
            }
            else if (cb == TransferSecondUnitComboBoxAdv)
            {
                transferSecondUnit = (BitRateUnit)cb.SelectedItem;

                if (transferSecondUnit == BitRateUnit.BitPerSecond) TransferSecondUnitNumericUpDownExt.DecimalPlaces = 0;
                else TransferSecondUnitNumericUpDownExt.DecimalPlaces = 3;

                UpdateTransferInputFields(TransferSecondUnitNumericUpDownExt);
            }

               
        }
    }
}
