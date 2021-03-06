﻿using System;
using System.Windows.Forms;
using SmartSystemMenu.Code.Common;

namespace SmartSystemMenu.Code.Forms
{
    partial class PositionForm : Form
    {
        private Window _window;

        public PositionForm(Window window)
        {
            InitializeComponent();

            _window = window;
            numericLeft.Value = _window.Size.Left;
            numericTop.Value = _window.Size.Top;
        }

        private void ButtonApplyClick(object sender, EventArgs e)
        {
            try
            {
                Int32 left = (Int32)numericLeft.Value;
                Int32 top = (Int32)numericTop.Value;
                _window.ShowNormal();
                _window.SetPosition(left, top);
                _window.Menu.UncheckAlignmentMenu();
                _window.Menu.CheckMenuItem(SystemMenu.SC_ALIGN_CUSTOM, true);
            }
            catch
            {
            }
            finally
            {
                Close();
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    {
                        ButtonApplyClick(sender, (EventArgs)e);
                    }break;

                case 27:
                    {
                        Close();
                    } break;
            }
        }
    }
}
