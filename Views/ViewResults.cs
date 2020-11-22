﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QTLProject.Types;

namespace QTLProject
{
    public partial class ViewResults : UserControl
    {
        public event EventHandler<EventArgsViewResults> backButtonClicked;
        private SoftwareStep prevStep;
        private string index;
        public ViewResults()
        {
            //create list/arraylist of string
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.btnBack.MouseClick += BtnBack_MouseClick;
            this.btnShowResutls.MouseClick += BtnShowResutls_MouseClick;
            this.btnOpenFolder.BackColor =  ColorTranslator.FromHtml("#ebf9fc");
            this.btnShowResutls.BackColor = ColorTranslator.FromHtml("#ebf9fc");
            // this.comboBoxFuncs.Items.AddRange();
            this.comboBoxFuncs.SelectedValueChanged += ComboBoxFuncs_SelectedValueChanged;
        }

        private void ComboBoxFuncs_SelectedValueChanged(object sender, EventArgs e)
        {
            //save the seleted value
            index = e.ToString();
        }

        private void BtnShowResutls_MouseClick(object sender, MouseEventArgs e)
        {
            //if not checked 1 , 2 ,3 ...
            // message box  : please fill all fields
            //
            /*
             if all checked

            new presentor
            ViewresultsPresentor pr=new ViewREsultsPresentor();
            pr.GenereateQTLEffect();
             
             */
        }

        public void updateInternalstate(SoftwareStep step)
        {
            this.prevStep = step;
        }
        private void BtnBack_MouseClick(object sender, MouseEventArgs e)
        {
            EventArgsViewResults args = new EventArgsViewResults();
            args.PrevoiusStep = prevStep;
            backButtonClicked?.Invoke(this, args);
        }

        public class EventArgsViewResults : EventArgs
        {
            public SoftwareStep PrevoiusStep { get; set; }
        }

        private void ViewResults_Load(object sender, EventArgs e)
        {

        }

        private void inputData1_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
