﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashTrack
{
    public partial class Home : MaterialForm
    {

        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #if !DEBUG
            MessageBox.Show("This is free AF, consider donating.", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endif

            SortedDictionary<string, int> currencyCache = new SortedDictionary<string, int>
            {
              {"Euro", 1},
              {"USDT", 2},
              {"Bitcoin", 3},
              {"Ethereum", 4},
              {"Solana", 5},
            };
            comboBoxDonationCurrency.DataSource = new BindingSource(currencyCache, null);
            comboBoxDonationCurrency.DisplayMember = "Key";
            comboBoxDonationCurrency.ValueMember = "Value";
        }

        #region

        private string GetCurrencyName()
        {
            string currency = comboBoxDonationCurrency.Items[comboBoxDonationCurrency.SelectedIndex].ToString();
            currency = currency.Replace("[", "");
            currency = currency.Replace("]", "");
            currency = currency.Split('\u002C')[0];

            return currency;
        }

        private string GetPaymentDestination()
        {
            switch(GetCurrencyName())
            {
                case "Euro":
                    return "Paypal/CashTrack";
                    break;

                case "Bitcoin":
                case "Ethereum":
                case "Solana":
                case "USDT":
                    return "6g32bd6dsnbg8fsdngfd6ngdf68gndf" + Environment.NewLine + "(Wallet)";
                    break;
                default:
                    return string.Empty;
            }
        }
        #endregion

        #region Actions

        private void btn1_Click(object sender, EventArgs e)
        {

            if (comboBoxDonationCurrency.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a currency.", "No currency selected.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            

            if (numericUpDownDonationAmount.Value <= 0)
            {
                MessageBox.Show("Please select an amount for " + GetCurrencyName(), "No amount selected.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            textBoxDonationInfo.Text = string.Empty;
            textBoxDonationInfo.Text = "Donated " + numericUpDownDonationAmount.Value.ToString() + " " + GetCurrencyName() + " to: " + Environment.NewLine + GetPaymentDestination();
        }

        private void numericUpDownDonationAmount_ValueChanged(object sender, EventArgs e)
        {
            textBoxDonationResume.Text = numericUpDownDonationAmount.Value + " " + GetCurrencyName();
        }

        #endregion

        private void comboBoxDonationCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDonationResume.Text = numericUpDownDonationAmount.Value + " " + GetCurrencyName();
        }
    }
}
