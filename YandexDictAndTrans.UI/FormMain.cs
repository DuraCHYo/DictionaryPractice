﻿using System.Windows.Forms;
using YandexDictAndTrans.UI.API;
using YandexDictAndTrans.UI.ViewModel;
using System.Diagnostics;

namespace YandexDictAndTrans.UI
{
    public partial class FormMain : Form
    {
        private readonly MainViewModel _viewModel;

        public FormMain()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new YandexServices());

            //привязки
            _textBoxInput.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Input));
            _textBoxOutput.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Output));
            _viewModel.OutputChanged += (s, e) => _textBoxOutput.DataBindings[0].ReadValue();
            _comboBoxLang.DataSource = _viewModel.Langs;
            _comboBoxLang.DataBindings.Add("SelectedIndex", _viewModel, nameof(_viewModel.SelectedLang));

            //кнопки
            _buttonTrans.Click += async (s, e) => await _viewModel.GetTransationAsync();
            _buttonDict.Click += async (s, e) => await _viewModel.GetDictionaryAsync();

        }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://yandex.ru/dev/translate/");
    }
  }
}
