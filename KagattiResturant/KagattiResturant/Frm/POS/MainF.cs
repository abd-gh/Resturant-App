using GProjects.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KagattiResturant.Class;
using System.Runtime.InteropServices;
using System.IO;

namespace KagattiResturant
{

    public partial class MainF : Form
    {
        private RestOrder order;
        private RestBill bill;
        public static Guid billGuid;
        Timer timer = new Timer();

        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;

        //center
        int cx, cy;

        Bitmap bmp;
        Graphics graph;

        public MainF()
        {
            InitializeComponent();
            SearchBill.Connection.ConnectionString = ProjBase.ConnectionString;
            SearchBill.GenerateFelidSearch = true;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void statusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
        }
        public Stimulsoft.Controls.Win.DotNetBar.StyleManager styleManager { get; set; }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }


        public static int deliveryOrder;
        public static bool userIsAdmin;
        public string repName { get; set; }
        private void MainF_Load(object sender, EventArgs e)
        {
            //translate
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                btnClosse.Text = ProjBase.CurrentLanguage.GetValue(btnClosse.Text);
                btnOpenDraw.Text = ProjBase.CurrentLanguage.GetValue(btnOpenDraw.Text);
                btnPrint.Text = ProjBase.CurrentLanguage.GetValue(btnPrint.Text);
                btnPay.Text = ProjBase.CurrentLanguage.GetValue(btnPay.Text);
                btnDeletBill.Text = ProjBase.CurrentLanguage.GetValue(btnDeletBill.Text);
                btnZeroCounter.Text = ProjBase.CurrentLanguage.GetValue(btnZeroCounter.Text);
                btnClear.Text = ProjBase.CurrentLanguage.GetValue(btnClear.Text);
                ProjBase.CurrentLanguage.GetValue(C_Item.HeaderText);
                ProjBase.CurrentLanguage.GetValue(C_Quantity.HeaderText);
                ProjBase.CurrentLanguage.GetValue(C_SingalPrice.HeaderText);
                ProjBase.CurrentLanguage.GetValue(C_TotalPrice.HeaderText);
                ProjBase.CurrentLanguage.GetValue(C_Tax.HeaderText);
            }
            LTitle.Text = (Options.GetOptionRegistry("CompanyName", "GetCompany", "Kagatti")).ToString();

            //add lebl to display UserName
            Label lebl = new Label();
            lebl.Name = "label-userName";
            lebl.Text = "Welcome " + CSamaHotel.CurrUser.LoginName + " :)";
            lebl.ForeColor = Color.White;
            lebl.BackColor = Color.Transparent;
            lebl.Font = new Font("Serif", 12, FontStyle.Bold);
            lebl.Width = 225;
            lebl.Height = 23;
            lebl.TextAlign = ContentAlignment.MiddleCenter;
            lebl.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Controls.Add(lebl);

            try
            {
                repName = GControls.Class.CBaseClass.Getpath() + "\\CustRep\\RepPrint\\" + this.Text + ".mrt";
                if (!File.Exists(repName))
                    File.Copy(GControls.Class.CBaseClass.Getpath() + "\\Base Rep\\BRep.mrt", repName);
                Rep.Load(repName);
            }
            catch (Exception)
            {

            }

            //User Is Admin ?
            Guid userGuid = CSamaHotel.CurrUser.guid;
            SqlDataReader dr;
            SqlCommand command = ProjBase.Conn.CreateCommand();
            command.CommandText = " Select Isadmin from GUsers where Guid='" + userGuid.ToString() + "' ";
            dr = command.ExecuteReader();
            dr.Read();
            userIsAdmin = ValuesFix.GetValuebool(dr["Isadmin"].ToString());
            dr.Close();

            //info bill
            //LNum.Text = Options.GetOptionRegistry("Counter", "GetCounter", "0").ToString();
            //---------------------------------------------------------------------------------------------------Draw item and section
            /* SqlDataReader Dr;
             SqlCommand Comm = ProjBase.Conn.CreateCommand();
             Comm.CommandText = " select * from RestSection ";
             Dr = Comm.ExecuteReader();
             using (DataTable dt = new DataTable())
             {
                 dt.Load(Dr);
                 sectionCount = (dt.Rows.Count);
             }
             Dr.Close();
             for (int i = 1; i <= sectionCount; i++)
             {
                 SqlDataReader D;
                 SqlCommand Com = ProjBase.Conn.CreateCommand();
                 Com.CommandText = "select * from RestSection where Number=" + i + "";
                 D = Com.ExecuteReader();
                 D.Read();
                 if (D.HasRows)
                 {
                     D.Close();
                     Button btn_section = draw_btn_section(i);
                     flowLayoutPanel1.Controls.Add(btn_section);
                     btn_section.Click += new System.EventHandler(this.SectionDoubleClick);
                 }
                 D.Close();
             }
            */
            //********

            SqlDataReader drSetion;
            SqlCommand comSection = ProjBase.Conn.CreateCommand();
            comSection.CommandText = "select Guid, Name from RestSection";
            drSetion = comSection.ExecuteReader();
            using (DataTable dt_section = new DataTable())
            {
                dt_section.Load(drSetion);
                drSetion.Close();
                int count = (dt_section.Rows.Count);
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Button btnSection = DrawSectionBtn(dt_section.Rows[i][0].ToString(), dt_section.Rows[i][1].ToString());
                        flowLayoutPanel1.Controls.Add(btnSection);
                        btnSection.Click += new System.EventHandler(this.SectionDoubleClick);
                    }
                }
            }
            //********


            //---------------------------------------------------------------------------------------------------------Print orders that have not been received
            SqlDataReader Drr;
            SqlCommand Commm = ProjBase.Conn.CreateCommand();
            Commm.CommandText = "select Guid from RestBill where Type=0 and Checks=0 ";
            Drr = Commm.ExecuteReader();
            using (DataTable dtt = new DataTable())
            {
                dtt.Load(Drr);
                Drr.Close();
                deliveryOrder = (dtt.Rows.Count);
                if (deliveryOrder > 0)
                {
                    for (int i = 0; i < deliveryOrder; i++)
                    {
                        Button deliveryBtn = DrawSectionBtn(dtt.Rows[i][0].ToString());
                        flowDelivary.Controls.Add(deliveryBtn);
                        deliveryBtn.Click += new System.EventHandler(this.btn_deliveryDoubleClick);
                    }
                }
            }


            //-------------------------------------------------------------------------------------------------------Display Resturan Name and timer
            label2.Text = DateTime.Now.ToShortDateString();
            label4.Text = "Kagatti" + "\n" + "Restaurant";

            //-------------------------------------------------------------------------------------------------------create timer bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            //timer
            timer.Interval = 1000;      //in millisecond
            timer.Tick += new EventHandler(this.Display_Clock);
            timer.Start();

        }

        public delegate void CashDelivary();
        public delegate void DeletDelvary();
        public static string deliveryBillGuid;
        private void btn_deliveryDoubleClick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LNum.Text = "";
            Lprice.Text = "";
            Cash payment_frm = new Cash();
            var btn_delivery = sender as Button;
            deliveryBillGuid = btn_delivery.Name;

            // -------------------------------------------------------------------------load information of delivery bill on data table

            SqlDataReader dr;
            SqlCommand Com = ProjBase.Conn.CreateCommand();
            Com.CommandText = "select ri.Name,ro.Single_Price,ro.Count,ro.Tax,ro.Total_Price,ri.GUID,ro.Guid,rb.Num,rb.Total_Price Bill_total_price,rb.Date" +
                             " from RestBill rb, RestOrder ro " +
                              "inner join RestItem ri on ri.GUID=ro.Item_Name where ro.Guid_RestBill='" + deliveryBillGuid.ToString() + "' and rb.GUID='" + deliveryBillGuid.ToString() + "'";
            dr = Com.ExecuteReader();

            using (DataTable dt = new DataTable())
            {
                dt.Load(dr);
                dr.Close();
                int rowCount = (dt.Rows.Count);
                for (int i = 0; i < rowCount; i++)
                {
                    i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                }
                LNum.Text = "Order Number: " + dt.Rows[0][7].ToString() + "  Date: " + dt.Rows[0][9].ToString();
                Lprice.Text = dt.Rows[0][8].ToString();
            }
            /*
            SqlDataReader Drr;
            SqlCommand Commm = ProjBase.Conn.CreateCommand();
            Commm.CommandText = " Select * from RestBill where Guid='" + delivery_Guid_Bill.ToString() + "' ";
            Drr = Commm.ExecuteReader();
            Drr.Read();
            LNum.Text = "Order Number: "+ValuesFix.GetValueInt(Drr["Num"]).ToString();
            Lprice.Text = ValuesFix.GetValueString(Drr["Total_Price"]).ToString();
            DateTime time = ValuesFix.GetValueDateTime(Drr["Date"]);
            LNum.Text +="Date: "+ time;
            Drr.Close();
            */

            //rr = e.RowIndex;
            payment_frm.DelDeliv = new DeletDelvary(this.DelDelivFN);//this will trigger AddCheckCallbackFn
            payment_frm.CashDeliv = new CashDelivary(this.CashDelivFn);//this will trigger AddCheckCallbackFn
            payment_frm.Show();
        }

        private void CashDelivFn()
        {
            dataGridView1.Rows.Clear();
            LNum.Text = "";
            Lprice.Text = "";
            SqlCommand command = ProjBase.Conn.CreateCommand();
            command.CommandText = "UPDATE RestBill SET Checks = 1 , Users='" + CSamaHotel.CurrUser.guid + "'  Where GUID ='" + deliveryBillGuid + "'";
            command.ExecuteNonQuery();
            Updateflowdeliv();
        }

        private void DelDelivFN()
        {
            dataGridView1.Rows.Clear();
            LNum.Text = "";
            Lprice.Text = "";
            SqlCommand cmd = ProjBase.Conn.CreateCommand();
            cmd.CommandText = "DELETE FROM RestBill WHERE Guid='" + deliveryBillGuid + "'";
            cmd.ExecuteNonQuery();
            Updateflowdeliv();
        }
        private void Updateflowdeliv()
        {
            flowDelivary.Controls.Clear();
            Guid User_Guid = CSamaHotel.CurrUser.guid;
            SqlDataReader Drr;
            SqlCommand Commm = ProjBase.Conn.CreateCommand();
            Commm.CommandText = "select Guid from RestBill where Type=0 and Checks=0 ";
            Drr = Commm.ExecuteReader();
            using (DataTable dtt = new DataTable())
            {
                dtt.Load(Drr);
                Drr.Close();
                deliveryOrder = (dtt.Rows.Count);
                if (deliveryOrder > 0)
                {
                    for (int i = 0; i < deliveryOrder; i++)
                    {
                        Button btn_delivery = DrawSectionBtn(dtt.Rows[i][0].ToString());
                        flowDelivary.Controls.Add(btn_delivery);
                        btn_delivery.Click += new System.EventHandler(this.btn_deliveryDoubleClick);
                    }
                }
            }
        }

        private Button DrawSectionBtn(string Guid)
        {
            Button btn = new Button();
            SqlDataReader dr;
            SqlCommand Com = ProjBase.Conn.CreateCommand();
            Com.CommandText = "select * from RestBill where Guid='" + Guid + "'";
            dr = Com.ExecuteReader();
            dr.Read();
            btn.Name = ValuesFix.GetValueString(dr["GUID"].ToString());
            btn.Text = ValuesFix.GetValueString(dr["Num"].ToString()) + "\n" + ValuesFix.GetValueDouble(dr["Total_Price"].ToString());
            btn.ForeColor = Color.FromArgb(1, 35, 81);
            btn.BackColor = Color.White;
            string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            btn.Image = Image.FromFile(exePath + "\\dv.png");
            btn.ImageAlign = ContentAlignment.MiddleRight;
            btn.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btn.Width = 120;
            btn.Height = 67;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Margin = new Padding(2, 2, 2, 2);
            dr.Close();
            return btn;
        }

        void SectionDoubleClick(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            var But = sender as Button;
            SqlDataReader Dr;
            SqlCommand Comm = ProjBase.Conn.CreateCommand();
            Comm.CommandText = " Select * from RestItem where Section_Name='" + Guid.Parse(But.Name) + "' ";
            Dr = Comm.ExecuteReader();
            using (DataTable dt = new DataTable())
            {
                dt.Load(Dr);
                Dr.Close();
                int rowCount = (dt.Rows.Count);
                for (int i = 0; i < rowCount; i++)
                {
                    Button l = DrawItemBtn(dt.Rows[i][0].ToString());
                    flowLayoutPanel2.Controls.Add(l);
                    l.Click += new System.EventHandler(this.ItemBtnClick);
                }
            }
        }
        void ItemBtnClick(object sender, EventArgs e)
        {

            var btn = sender as Button;
            bool addCount = false;
            int r = 0;
            double tax, taxItem, total, totalWithTax;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[5].Value == btn.Name && dataGridView1.Rows[r].Cells[6].Value == null)
                {
                    addCount = true;
                    r = i;

                    int count = int.Parse(dataGridView1.Rows[r].Cells[2].Value.ToString());
                    dataGridView1.Rows[r].Cells[2].Value = count + 1;
                    tax = Convert.ToDouble(Options.GetOptionRegistry("Tax", "GetTax", "0.8").ToString());
                    total = Convert.ToDouble(dataGridView1.Rows[r].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[r].Cells[2].Value);
                    taxItem = tax * total;
                    dataGridView1.Rows[r].Cells[3].Value = taxItem;
                    totalWithTax = total + taxItem;
                    dataGridView1.Rows[r].Cells[4].Value = totalWithTax;
                    return;

                }
            }


            SqlDataReader Dr;
            SqlCommand Comm = ProjBase.Conn.CreateCommand();
            Comm.CommandText = " Select * from RestItem where Guid='" + Guid.Parse(btn.Name) + "' ";
            Dr = Comm.ExecuteReader();
            Dr.Read();
            int rows = dataGridView1.Rows.Add();
            dataGridView1.Rows[rows].Cells[0].Value = ValuesFix.GetValueString(Dr["Name"].ToString());
            dataGridView1.Rows[rows].Cells[1].Value = ValuesFix.GetValueDouble(Dr["Price"].ToString());
            dataGridView1.Rows[rows].Cells[2].Value = "1";

            tax = Convert.ToDouble(Options.GetOptionRegistry("Tax", "GetTax", "0.8").ToString());
            total = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value);
            taxItem = tax * total;
            dataGridView1.Rows[rows].Cells[3].Value = taxItem;
            totalWithTax = total + taxItem;
            dataGridView1.Rows[rows].Cells[4].Value = totalWithTax;
            dataGridView1.Rows[rows].Cells[5].Value = btn.Name;
            Guid sec = ValuesFix.GetValueGUID(Dr["Section_Name"].ToString());
            Dr.Close();

            /*------------------------------------------------------------------------- get the Printer of Section 
            SqlDataReader Drr;
            SqlCommand Commm = ProjBase.Conn.CreateCommand();
            Commm.CommandText = " Select * from RestSection where Guid='" + sec + "' ";
            Drr = Commm.ExecuteReader();
            Drr.Read();
            dataGridView1.Rows[rows].Cells[12].Value = ValuesFix.GetValueString(Drr["Printer"].ToString());
            Drr.Close();
            */

        }
        Button DrawItemBtn(string itemGuid)
        {
            Button btn = new Button();
            SqlDataReader dr;
            SqlCommand com = ProjBase.Conn.CreateCommand();
            com.CommandText = "select * from RestItem where Guid='" + itemGuid + "'";
            dr = com.ExecuteReader();
            dr.Read();
            btn.Name = ValuesFix.GetValueString(dr["GUID"].ToString());
            btn.Text = ValuesFix.GetValueString(dr["Name"].ToString()) + "\n" + ValuesFix.GetValueDouble(dr["Price"].ToString());
            btn.ForeColor = Color.FromArgb(1, 35, 81);
            btn.BackColor = Color.White;
            btn.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btn.Width = 124;
            btn.Height = 70;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(0, 2, 3, 0);
            dr.Close();
            return btn;
        }
        Button DrawSectionBtn(string GUID, string Name)
        {
            Button btn = new Button();
            btn.Name = GUID;
            btn.Text = Name;
            btn.ForeColor = Color.FromArgb(1, 35, 81);
            btn.BackColor = Color.White;
            btn.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            btn.Width = 105;
            btn.Height = 70;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(4, 2, 0, 0);
            return btn;
        }
        private void Display_Clock(object sender, EventArgs e)
        {
            //create graphics
            graph = Graphics.FromImage(bmp);

            //get time
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = ((DateTime.Now.Hour + 11) % 12) + 1;

            int[] time = new int[2];

            //clear
            graph.Clear(Color.White);

            //draw circle
            graph.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

            //draw figure
            graph.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            graph.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            graph.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            graph.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            //second hand
            time = msCoord(ss, secHAND);
            graph.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(time[0], time[1]));

            //minute hand
            time = msCoord(mm, minHAND);
            graph.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(time[0], time[1]));

            //hour hand
            time = hrCoord(hh % 12, mm, hrHAND);
            graph.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(time[0], time[1]));

            //display time
            label1.Text = hh + ":" + mm + ":" + ss;

            //dispose
            graph.Dispose();
        }

        //coord for minute and second hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //coord for hour hand
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    int qount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if (qount > 0)
                    {
                        double price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                        double total = price * qount;
                        //tax
                        string t = Options.GetOptionRegistry("Tax", "GetTax", "0.8").ToString();
                        double tax = Convert.ToDouble(t);
                        double with_tax = tax * total;
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = with_tax;
                        double total_with_tax = total + with_tax;
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = total_with_tax;
                        //end tax
                    }
                    else
                    {
                        //dataGridView1.Rows[e.RowIndex].Cells[2].Value = "1";
                        //MessageBox.Show("You can't enter quantity 0");
                        this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                        //LNum.Text = "1";
                        //LTim.Text = DateTime.Now.ToShortTimeString();

                    }
                }
                LNum.Text = Options.GetOptionRegistry("Counter", "GetCounter", "0").ToString();
                //LTim.Text = DateTime.Now.ToShortTimeString();

                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                Lprice.Text = sum.ToString();
                // LItem.Text = (dataGridView1.Rows.Count - 1).ToString();
            }


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
        public delegate void AddItemDelegate(string item);
        public delegate void DelItemDelegate();
        public delegate void AddTypeBill(bool ty, string Not);
        public static int rowNumber;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //click on Quantity Cell
            if (dataGridView1.Rows.Count > 1 && e.ColumnIndex == 2 && dataGridView1.Rows[e.RowIndex].Cells[6].Value == null && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                ControlGrid frm = new ControlGrid();
                rowNumber = e.RowIndex;
                frm.AddItemCallback = new AddItemDelegate(this.AddCheckCallbackFn);//this will trigger AddCheckCallbackFn
                frm.DelItemCallback = new DelItemDelegate(this.DelCheckCallbackFn);//this will trigger DelCheckCallbackFn
                frm.Show();
            }
            // minus
            else if (dataGridView1.Rows.Count > 1 && e.ColumnIndex == 7 && dataGridView1.Rows[e.RowIndex].Cells[6].Value == null && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                quantity--;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = quantity.ToString();
            }
            //remove
            else if (dataGridView1.Rows.Count > 1 && e.ColumnIndex == 11 && dataGridView1.Rows[e.RowIndex].Cells[6].Value == null && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                Lprice.Text = sum.ToString();
            }
            //add
            else if (dataGridView1.Rows.Count > 1 && e.ColumnIndex == 9 && dataGridView1.Rows[e.RowIndex].Cells[6].Value == null && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                quantity++;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = quantity.ToString();
            }
        }
        private void AddCheckCallbackFn(string item)
        {
            this.dataGridView1.Rows[rowNumber].Cells[2].Value = item;
        }
        private void DelCheckCallbackFn()
        {
            this.dataGridView1.Rows.RemoveAt(rowNumber);
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            Lprice.Text = sum.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClosse_Click(object sender, EventArgs e)
        {
            string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            if (lng == "Ar")
            {
                DialogResult dialogResult = MessageBox.Show(ProjBase.CurrentLanguage.GetValue("Do you Close Programm??"), "Close", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you Close Programm??", "Close", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
        public void addtypefn(bool billType, string Note)
        {
            order = new RestOrder();
            bill = new RestBill();
            bill.Num = int.Parse(LNum.Text);
            bill.Total_Price = double.Parse(Lprice.Text);
            bill.Date = DateTime.Now;
            bill.Users = CSamaHotel.CurrUser.guid;
            if (billType == true)//-------------- true means pay direct, false means delivery
            {
                bill.Type = true;
                bill.Checks = true;
                bill.Notes = Note;
            }
            else
            {
                bill.Type = false;
                bill.Checks = false;
                bill.Notes = Note;
            }
            bool saveBill = bill.Add();
            billGuid = bill.GUID;
            if (saveBill) //-----------------------------------------------------check if Bill added successfully to DB
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    order.Guid_RestBill = bill.GUID;
                    string Guid_Item = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    order.Item_Name = Guid.Parse(Guid_Item);
                    order.Count = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
                    order.Single_Price = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    order.Total_Price = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    order.Date = DateTime.Now;
                    order.Tax = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    order.Users = CSamaHotel.CurrUser.guid;
                    bool saveOrder = order.Add();
                    if (saveOrder) //---------------------------------------------check if Order added successfully to DB
                    {
                        //--------------------------------------------------------check if the item have quantity to update the quantity in DB
                        SqlCommand C = ProjBase.Conn.CreateCommand();
                        C.CommandText = " select rs.IsProduct from RestItem ri " +
                        " inner join RestSection rs on rs.GUID=ri.Section_Name " +
                        " where (rs.IsProduct=1) and(ri.GUID='" + order.Item_Name + "')";
                        var result = C.ExecuteScalar();
                        bool isResult = Convert.ToBoolean(result);
                        if (isResult)
                        {
                            SqlCommand Cc = ProjBase.Conn.CreateCommand();
                            Cc.CommandText = "update RestItem  set Quantity= Quantity -" + order.Count + " " +
                                                "where GUID='" + order.Item_Name + "'";
                            Cc.ExecuteNonQuery();
                        }
                    }
                }

                //Print bill one to one
                /*
                 
                List<string> list = new List<string>();
                int items_count = dataGridView1.Rows.Count;
                for (int i = 0; i < items_count - 1; i++)
                {
                    list.Add(dataGridView1.Rows[i].Cells[12].Value.ToString());
                }
                List<string> distinct = list.Distinct().ToList();
                RepName = GControls.Class.CBaseClass.Getpath() + "\\CustRep\\RepPrint\\" + "E_Pos" + ".mrt";
                if (!File.Exists(RepName))
                    File.Copy(GControls.Class.CBaseClass.Getpath() + "\\Base Rep\\BRep.mrt", RepName);
                Rep.Load(RepName);
                
                bool actPrint = bool.Parse(Options.GetOptionRegistry("ActPrinter2", "GetActPrinter2", false).ToString());
                if (actPrint)
                {
                    for (int p = 0; p < distinct.Count; p++)
                    {
                        string pn2 = distinct[p];
                        string PrinterNamee = pn2;
                        string qe = "select ri.Name Name,ro.Single_Price price,ro.Count Count, rb.Total_Price Total," +
                             " rb.Date time ,rb.Num Number,rb.Type Type " +
                             "   from RestOrder as ro  " +
                             "   inner join RestBill rb on rb.GUID=ro.Guid_RestBill " +
                             "   inner join RestItem ri on ri.GUID=ro.Item_Name  " +
                             "   inner join RestSection rs on rs.GUID=ri.Section_Name " +
                             "  where (ro.Guid_RestBill='" + GP.ToString() + "') " +
                             "   and (rs.Printer='" + pn2 + "') ";
                        SqlDataAdapter adaptere = new SqlDataAdapter(qe, ProjBase.Conn);
                        dataSet = new DataSet();
                        adaptere.Fill(dataSet, "f");
                        Rep.RegData(dataSet);
                        Rep.Dictionary.Synchronize();
                        Rep.PrinterSettings.PrinterName = PrinterNamee;
                        //Rep.Design();
                        Rep.Print(showPrintDialog: false);
                        // end filter print
                    }
                }*/
                dataGridView1.Rows.Clear();
                int num = int.Parse(Options.GetOptionRegistry("Counter", "GetCounter", "0").ToString());
                Options.SetOptionRegistry("Counter", "GetCounter", (num + 1).ToString());
                LNum.Text = Options.GetOptionRegistry("Counter", "GetCounter", "0").ToString();
                Lprice.Text = "0";
            }
            if (SearchBill.guid != Guid.Empty)
            {
                SearchBill.guid = Guid.Empty;
            }
            Updateflowdeliv();
            string PrinterName = Options.GetOptionRegistry("PrinterName", "GetPrinterName", " ").ToString();
            string q = "select ri.Name Name,ro.Single_Price price,ro.Count Count, rb.Total_Price Total,rb.Date time ,rb.Num Number,rb.Type Type  " +
                "from RestOrder as ro inner join RestBill rb on rb.GUID=ro.Guid_RestBill inner join RestItem ri on ri.GUID=ro.Item_Name " +
                "where ro.Guid_RestBill='" + billGuid.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(q, ProjBase.Conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "f");
            Rep.RegData(dataSet);
            Rep.Dictionary.Synchronize();
            Rep.PrinterSettings.PrinterName = PrinterName;

            ///print test 
            /*
            Rep.Print(showPrintDialog: false);
            */
        }
        private void btnPay_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 1)
            {
                if (SearchBill.guid != Guid.Empty) //---------------------------------------------------It's mean he want to delete and return an order
                {
                    if (userIsAdmin == true)
                    {
                        DialogResult dialogResult = MessageBox.Show(ProjBase.CurrentLanguage.GetValue("Are you sure to delete the bill " + SearchBill.Text + "?"), "Delete Bill", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            billGuid = SearchBill.guid;
                            Guid bill_guid = SearchBill.guid;
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                Guid item_Guid = Guid.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                                int Quantity = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                                //-----------------------------------------------------------------------------check if the item has Quantity to update it
                                SqlCommand Com = ProjBase.Conn.CreateCommand();
                                Com.CommandText = " select rs.IsProduct from RestItem ri " +
                                " inner join RestSection rs on rs.GUID=ri.Section_Name " +
                                " where (rs.IsProduct=1) and(ri.GUID='" + item_Guid + "')";
                                var result = Com.ExecuteScalar();
                                bool isResult = Convert.ToBoolean(result);
                                if (isResult == true)
                                {
                                    if (dataGridView1.Rows[i].Cells[6].Value != null) // ´-------------------It's mean the bill has product with quantity, make other check to be sure
                                    {
                                        SqlCommand Comm = ProjBase.Conn.CreateCommand();
                                        Comm.CommandText = "update RestItem  set Quantity= Quantity +" + Quantity + " " +
                                                            "where GUID='" + item_Guid + "'";
                                        Comm.ExecuteNonQuery();
                                    }
                                }
                            }
                            //-------------------------------------------------------------------------------delete the bill from order and bill table
                            SqlCommand cmd = ProjBase.Conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM RestOrder WHERE Guid_RestBill='" + bill_guid + "'";
                            cmd.ExecuteNonQuery();
                            SqlCommand cmmd = new SqlCommand("Prc_RestBill_Del", ProjBase.Conn);
                            cmmd.CommandType = CommandType.StoredProcedure;
                            cmmd.Parameters.AddWithValue("@GUID", bill_guid);
                            cmmd.ExecuteNonQuery();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                        /*
                         BillType frmtype = new BillType();
                         frmtype.AddType = new AddTypeBill(this.addtypefn);
                         frmtype.Show();
                        */
                    }
                    else
                    {
                        string lng = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
                        if (lng == "Ar")
                        {
                            MessageBox.Show(ProjBase.CurrentLanguage.GetValue("Sory.. but you don't have permission "));
                        }
                        else
                        {
                            MessageBox.Show("Sory.. but you don't have permission ");
                        }
                    }
                }
                else
                {
                    BillType frmtype = new BillType();
                    frmtype.AddType = new AddTypeBill(this.addtypefn);
                    frmtype.Show();
                }
            }
        }
        private void btnZeroCounter_Click_1(object sender, EventArgs e)
        {
            if (userIsAdmin == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to return the numbers to zero", "Bill Option", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Options.SetOptionRegistry("Counter", "GetCounter", "0");
                    LNum.Text = Options.GetOptionRegistry("Counter", "GetCounter", "0").ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sorry...but you don't have any permission");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LNum.Text = "";
            SearchBill.guid = Guid.Empty;
            Lprice.Text = "0";
        }

        private void SearchBill_Load(object sender, EventArgs e)
        {
            //  MessageBox.Show("hi");
        }

        private void SearchBill_ONSelected(object sender, EventArgs e)
        {
            if (SearchBill.guid != Guid.Empty)
            {
                dataGridView1.Rows.Clear();
                LNum.Text = "";
                Lprice.Text = "";
                int rN;
                //MessageBox.Show("hi");
                Guid Bill_G = SearchBill.guid;
                SqlDataReader D;
                SqlCommand Com = ProjBase.Conn.CreateCommand();
                Com.CommandText = "select ri.Name,ro.Single_Price,ro.Count,ro.Tax,ro.Total_Price,ri.GUID,ro.Guid,rb.Num,rb.Total_Price Bill_total_price,rb.Date" +
                             " from RestBill rb, RestOrder ro " +
                              "inner join RestItem ri on ri.GUID=ro.Item_Name where ro.Guid_RestBill='" + Bill_G.ToString() + "' and rb.GUID='" + Bill_G.ToString() + "'";
                D = Com.ExecuteReader();
                using (DataTable dt = new DataTable())
                {
                    Guid item_name;
                    dt.Load(D);
                    D.Close();
                    rN = (dt.Rows.Count);
                    for (int i = 0; i < rN; i++)
                    {
                        i = dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                        dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();

                        //-------------------------------------------------------------------------------------------- Get Printer name 
                        /* SqlDataReader Dp;
                         SqlCommand Cp = ProjBase.Conn.CreateCommand();
                         Cp.CommandText = "select rs.Printer " +
                         " from RestItem ri " +
                         " inner join RestSection rs on rs.GUID=ri.Section_Name " +
                         " where ri.GUID='" + dt.Rows[i][5].ToString() + "' ";
                         Dp = Cp.ExecuteReader();
                         Dp.Read();
                         dataGridView1.Rows[i].Cells[12].Value = ValuesFix.GetValueString(Dp["Printer"].ToString());
                         Dp.Close();*/
                    }
                    LNum.Text = "Order Number: " + dt.Rows[0][7].ToString() + "  Date: " + dt.Rows[0][9].ToString();
                    Lprice.Text = dt.Rows[0][8].ToString();
                }
                /* SqlDataReader Drr;
                 SqlCommand Commm = ProjBase.Conn.CreateCommand();
                 Commm.CommandText = " Select * from RestBill where Guid='" + Bill_G.ToString() + "' ";
                 Drr = Commm.ExecuteReader();
                 Drr.Read();
                 LNum.Text = ValuesFix.GetValueInt(Drr["Num"]).ToString();
                 Lprice.Text = ValuesFix.GetValueString(Drr["Total_Price"]).ToString();
                 DateTime time = ValuesFix.GetValueDateTime(Drr["Date"]);
                 LNum.Text += time;
                 Drr.Close();*/
            }
        }

        private void SearchBill_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("hrsgs");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetFocusControl());
        }

        private void btnNUM1_Click(object sender, EventArgs e)
        {
            SearchBill.Text = "12";
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            GBase.CBase.OpenCashDrawer();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchBill.guid = Guid.Empty;
            Lprice.Text = "0";
            LNum.Text = "";
            //TCalIn.Text = "";
            ///LTim.Text = DateTime.Now.ToLongTimeString();
            //LItem.Text = "0";
        }




        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                if (SearchBill.guid != Guid.Empty)
                {
                    if (userIsAdmin == true)
                    {
                        DialogResult dialogResult = MessageBox.Show(ProjBase.CurrentLanguage.GetValue("Are you sure to delete the bill " + SearchBill.Text + "?"), "Delete Bill", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            billGuid = SearchBill.guid;
                            Guid bill_guid = SearchBill.guid;
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                Guid prod = Guid.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                                int cont = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                SqlCommand Com = ProjBase.Conn.CreateCommand();
                                Com.CommandText = " select rs.IsProduct from RestItem ri " +
                                " inner join RestSection rs on rs.GUID=ri.Section_Name " +
                                " where (rs.IsProduct=1) and(ri.GUID='" + prod + "')";
                                var result = Com.ExecuteScalar();
                                bool numR = Convert.ToBoolean(result);
                                if (numR == true)
                                {
                                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                                    {
                                        SqlCommand Comm = ProjBase.Conn.CreateCommand();
                                        Comm.CommandText = "update RestItem  set Quantity= Quantity +" + cont + " " +
                                                            "where GUID='" + prod + "'";
                                        Comm.ExecuteNonQuery();
                                    }
                                }
                            }
                            SqlCommand cmd = ProjBase.Conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM RestOrder WHERE Guid_RestBill='" + bill_guid + "'";
                            cmd.ExecuteNonQuery();
                            SqlCommand cmmd = new SqlCommand("Prc_RestBill_Del", ProjBase.Conn);
                            cmmd.CommandType = CommandType.StoredProcedure;
                            cmmd.Parameters.AddWithValue("@GUID", bill_guid);
                            cmmd.ExecuteNonQuery();
                            dataGridView1.Rows.Clear();
                            SearchBill.guid = Guid.Empty;
                            Lprice.Text = "0.00";
                            LNum.Text = "";
                            //BillType frmtype = new BillType();
                            //frmtype.AddType = new AddTypeBill(this.addtypefn);
                            //frmtype.Show();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sory.. but you don't have permission ");
                    }
                }
            }
            else
            {
                MessageBox.Show("You don't have any item !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*
            if (SearchBill.guid != Guid.Empty)
            {
                string PrinterName = Options.GetOptionRegistry("PrinterName", "GetPrinterName", " ").ToString();
                string q = "select ri.Name Name,ro.Single_Price price,ro.Count Count, rb.Total_Price Total,rb.Date time ,rb.Num Number  from RestOrder as ro inner join RestBill rb on rb.GUID=ro.Guid_RestBill inner join RestItem ri on ri.GUID=ro.Item_Name where ro.Guid_RestBill='" + SearchBill.guid.ToString() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(q, ProjBase.Conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "f");
                Rep.RegData(dataSet);
                Rep.Dictionary.Synchronize();
                Rep.PrinterSettings.PrinterName = PrinterName;
                Rep.Print(showPrintDialog: false);
            }
            */
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LNum_Click(object sender, EventArgs e)
        {

        }

        private void LTitle_Click(object sender, EventArgs e)
        {

        }

        private void TCalIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBill_Enter(object sender, EventArgs e)
        {

        }

        private void SearchBill_ONValueChange(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }






        //[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
        //internal static extern IntPtr GetFocus();

        //private string GetFocusControl()
        //{
        //    Control focusControl = null;
        //    IntPtr focusHandle = GetFocus();
        //    if (focusHandle != IntPtr.Zero)
        //        focusControl = Control.FromHandle(focusHandle);
        //    if (focusControl.Name.ToString().Length == 0)
        //        return focusControl.Parent.Parent.Name.ToString();
        //    else
        //        return focusControl.Name.ToString();
        //}

    }
}
