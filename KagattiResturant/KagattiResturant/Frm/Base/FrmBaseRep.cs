using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GBase.Frm.Base
{
    public partial class FrmBaseRep : GProjects.Frm.FrmBase
    {
        private string _RepName;
        public string RepName { get {return _RepName; } set {_RepName=value;this.Text = _RepName; } }
        public FrmBaseRep()
        {
            InitializeComponent();
        }

        private void FrmBaseRep_Load(object sender, EventArgs e)
        {

        }
        public override void intControls()
        {
            BtnClose.Image = ImageListBase24.Images["false"];
            BtnView.Image = ImageListBase24.Images["View"];
            intField();
            base.intControls();
        }

        public override void IntLanguage()
        {
           
            CBase.CurrentLanguage.GetValue(BtnClose);
            CBase.CurrentLanguage.GetValue(BtnView);
            CBase.CurrentLanguage.GetValue(LField);
            
            base.IntLanguage();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            CBase.ChangeMethodName("End Rep View");
            ShowRep();
            CBase.ChangeMethodName("End Rep View");
        }

        public virtual void ShowRep()
        {
            
        }

        public virtual String GetSql()
        {
            string Result = "";
            return Result;
        }

        public virtual void intField()
        {
            string Sql = GetSql();
            if (Sql == "")
                return;
            ListField.Items.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, GBase.CBase.Conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            foreach (DataColumn item in dataSet.Tables[0].Columns)
            {
                ListField.Items.Add(GBase.CBase.GetLanguageText(item.ColumnName),true);
            }
        }
    }
}
