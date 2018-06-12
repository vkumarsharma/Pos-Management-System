﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_Management_System
{
    public partial class WmsTransferBranchListDialog : Form
    {
        private string cnNo;
        private WmsTransferBranchListForm wmsTransferBranchListForm;

        public WmsTransferBranchListDialog()
        {
            InitializeComponent();
        }

        public WmsTransferBranchListDialog(WmsTransferBranchListForm wmsTransferBranchListForm, string cnNo)
        {
            InitializeComponent();
            this.wmsTransferBranchListForm = wmsTransferBranchListForm;
            this.cnNo = cnNo;
        }

        private void WmsTransferBranchListDialog_Load(object sender, EventArgs e)
        {
            using (SSLsEntities db = new SSLsEntities())
            {
                var data = db.WmsTransferOut.SingleOrDefault(w => w.Code == cnNo);
                textBoxDocNo.Text = data.Code;
                textBoxDocDate.Text = Library.ConvertDateToThaiDate(data.CreateDate);
                foreach (var item in data.WmsTransferOutDetails.Where(w => w.Enable == true).ToList())
                {
                    dataGridView1.Rows.Add
                        (
                        item.ProductDetails.Code,
                        item.ProductDetails.Products.ThaiName,
                        item.ProductDetails.ProductUnit.Name,
                        item.ProductDetails.PackSize,
                        Library.ConvertDecimalToStringForm(item.PricePerUnit),
                          Library.ConvertDecimalToStringForm(item.BeforeVat),
                          Library.ConvertDecimalToStringForm(item.Vat),
                          Library.ConvertDecimalToStringForm(item.Qty),
                          Library.ConvertDecimalToStringForm(item.TotalPrice)
                        );
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
