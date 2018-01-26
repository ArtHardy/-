﻿using CalcConsole;
using CalcDB.Models;
using CalcDB.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalc
{
    public partial class Form1 : Form
    {
        private Calc Calc { get; set; }

        public Form1()
        {
            InitializeComponent();
            Calc = new Calc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbOperations.Items.Clear();
            lbOperations.Items.AddRange(Calc.GetOperationNames());
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (lbOperations.SelectedItem == null)
                return;

            var oper = lbOperations.SelectedItem.ToString();

            var result = Calc.Exec(oper, tbInput.Text.Trim().Split(' '));

            label1.Text = result.ToString();

            #region Сохранение в БД

            var or = new OperationResult()
            {
                OperationId = lbOperations.SelectedIndex,
                Result = result,
                ExecutionTime = new Random().Next(100, 4000),
                Error = "",
                Args = tbInput.Text.Trim(),
                CreationDate = DateTime.Now
            };
            
            var operResultRepository = new BaseRepository<OperationResult>();
            operResultRepository.Save(or);

            #endregion

        }

        private void lbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.Enabled = lbOperations.SelectedItem != null;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled = !string.IsNullOrWhiteSpace(tbInput.Text);
        }
    }
}