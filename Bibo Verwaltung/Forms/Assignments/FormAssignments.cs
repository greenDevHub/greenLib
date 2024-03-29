﻿using Bibo_Verwaltung.Helper;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormAssignments : MetroForm
    {
        public FormAssignments()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerAssignment;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.AssignmentStyle;
        }
        private void btCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBookGradeClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            FormBookGrade formBookGrade = new FormBookGrade();
            formBookGrade.ShowDialog(this);
            formBookGrade.Dispose();
        }

        private void btBookSubjectClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            FormBookSubject formBookSubject = new FormBookSubject();
            formBookSubject.ShowDialog(this);
            formBookSubject.Dispose();
        }

        private void btSubjectGradeClick(object sender, EventArgs e)
        {

            if (!IsConnected()) return;
            FormSubjectGrade formSubjectGrade = new FormSubjectGrade();
            formSubjectGrade.ShowDialog(this);
            formSubjectGrade.Dispose();
        }

        private void btClassGradeClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            FormClassGrade formClassGrade = new FormClassGrade();
            formClassGrade.ShowDialog(this);
            formClassGrade.Dispose();
        }
        private bool IsConnected()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError())
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software " +
                    "zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
