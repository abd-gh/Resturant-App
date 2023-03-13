using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GControls.Class;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Reflection;
using KagattiResturant;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.IO;
using KagattiResturant.Class;
using GProjects.Class;

namespace GBase
{
    public static class CBase
    {
        public static string Company = "Kagatti";
        public static string AppName { get{return Assembly.GetEntryAssembly().GetName().Name; } }


     //  public static List<GSecurity> ListSecurity ;

        private static SqlConnection _Conn;
        public static Form MdiParent { get; set; }
        
        public static CLanguage CurrentLanguage  { get; set; }
       // public static CSeller CurrSeller { get; set; }
        public static Stimulsoft.Controls.Win.DotNetBar.StyleManager styleManager { get; set; }
        public static string Versions { get {return Assembly.GetEntryAssembly().GetName().Version.ToString(); }  }
        public static SqlConnection Conn
        {
            set
            {
                if (_Conn == null)
                {
                    _Conn = new SqlConnection();
                    _Conn = value;
                };
            }
            get
            {
                if (_Conn==null)
                    _Conn = new SqlConnection();
                if ((_Conn.State == System.Data.ConnectionState.Closed ) && (_Conn.ConnectionString!=""))
                    try
                    {
                        _Conn.Open();
                    }
                    catch (Exception ex)
                    {
                        CBase.ChangeConnString("");
                        GControls.Message.MSBox.Show("Connection Error", ex);
                    }
                   
                return _Conn;
                ;
            }
        }

        public static string ConnectionString { get; set; }

        public static ePosConnect epos = new ePosConnect();
        public static void ChangeConnString(string ConnString)
        {
            ConnectionString = ConnString;
            _Conn = new SqlConnection();
            _Conn.ConnectionString = ConnString;
        }

        public static void ChangeStatus(int Type)
        {
            ((FrmMain)(CBase.MdiParent)).ChangeStatus(Type);
        }

        public static void ChangeLanguge()
        {
            if (CBase.MdiParent == null)
                return;
            string lang = Options.GetOptionRegistry("Language", "CurentLanguage", "En").ToString();
            CBase.CurrentLanguage = CLanguage.LoadXmlSerializer(GControls.Class.CBaseClass.AppPath + "\\ResLng\\" + lang + ".RLXml");
            ((FrmMain)(CBase.MdiParent)).ChangeLanguge();
        }

        public static void ChangeMethodName(string Name)
        {
            if (CBase.MdiParent == null)
                return;
           // ((FrmMain)(CBase.MdiParent)).ChanegMethodName(Name);
        }

        public static string GetLanguageText(string Name)
        {
            if (CBase.CurrentLanguage != null)
                Name = CBase.CurrentLanguage.GetValue(Name);

            return Name;
        }
        public static string GetProgramVersion()
        {
            string Result = "";
            Result= DBSqlServer.GetExtendedProperties("POS Version");
            if (Result == "")
                Result = "0.0.0.0";
            return Result;
        }
        public static void SetProgramVersion(string value)
        {
            DBSqlServer.SetExtendedProperties("POS Version", value);
        }
        public static void SetProgramName(string value)
        {
            DBSqlServer.SetExtendedProperties("Program Name", value);
        }
        public static string GetFileName()
        {
            return DBSqlServer.GetExtendedProperties("File Name");
        }
        public static void SetFileName(string value)
        {
            DBSqlServer.SetExtendedProperties("File Name", value);
        }

        public static void OpenCashDrawer()
        {
            RawPrinterHelper.SendStringToPrinter(POSOPtions.PrinterCashDrower, System.Text.ASCIIEncoding.ASCII.GetString(new byte[] { 27, 112, 48, 55, 121 }));
        }

        public static void IntPOSSecurity()
        {
            //ListPOSSecurity = new List<POSSecurity>();
           // if (CBase.CurrSeller!=null)
           //     ListPOSSecurity = POSSecurity.GetPOSSecurity(CBase.CurrSeller.SellerID);
        }

     //   public static bool GetSecurityCommand(string CommandName,bool ShowUserPassword)
      //  {
            /* Result = false;
          Result = POSSecurity.GetPOSSecurity(SecurityType.Command, CommandName, "Allow");
           if (Result)
               return Result;
            else if(ShowUserPassword)
            {
                FrmPasswordAdmin frm = new FrmPasswordAdmin();
                frm.CommanName = CommandName;
                Result = frm.ShowDialog() == DialogResult.OK;
            }

            return Result;*/
     //   }
      //  public static bool GetSecurityCommand(string CommandName)
        //{
      //      return GetSecurityCommand(CommandName, true);
       // }

        public static void AddRegFiles(string Operation, string Notes,int BillID = 0)
        {
          //  if (POSOPtions.EnableRegFiles)
            //   RegFiles.AddReg(BillID, Operation, Notes);
        }

        
    }

    public static class POSOPtions
    {
        public static string PrinterCashDrower { get; set; }
        public static bool AllowSearshMatName { get; set; }
        public static bool EnableRegFiles { get; set; }
        public static bool PessimisticSecuritySystem { get; set; }
        public static int PrintedType { get; set; }
        public static int NumberDesimal { get; set; }
        public static  int ShowBill { get; set; }



        public static int DisBillop { get; set; }
        public static int TaxBillop { get; set; }
        public static int TaxBillItesOP { get; set; }
        public static int TypeTaxBillItemOP { get; set; }
        public static float Round { get; set; }


        public static void IntPorp()
        {
            AllowSearshMatName= Options.GetOptionsForAll("AllowSearshMatName", false);
            PrinterCashDrower=Options.GetOptionsForUser("PrinterCashDrower", new PrinterSettings().PrinterName);
            EnableRegFiles = Options.GetOptionsForAll("EnableRegFiles", false);
            PrintedType = Options.GetOptionsForUser("PrintedType", 0);
            PessimisticSecuritySystem= Options.GetOptionsForAll("PessimisticSecuritySystem", false);
            NumberDesimal= Options.GetOptionsForAll("NumberDesimal", 3);
            ShowBill = Options.GetOptionsForUser("ShowBill", 1);
            DisBillop = Options.GetOptionsForAll("DiscountBill", 0);
            TaxBillop = Options.GetOptionsForAll("TaxBill", 0);
            TaxBillItesOP = Options.GetOptionsForAll("TaxBillItem", 0);
            TypeTaxBillItemOP = Options.GetOptionsForAll("TypeTaxBillItem", 0);
            Round = Options.GetOptionsForAll("Round", 0);

        }
    }

    public static class ValuesFix
    {
        public static decimal GetValueDecimal(object o)
        {
            decimal Result = 0;
            if (o == null)
                return 0;
            try
            {
                Result = decimal.Parse(o.ToString());
            }
            catch (Exception)
            {
                Result = 0;
            }
            return Result;
        }

        public static decimal GetValueDecimal(string o)
        {
            return GetValueDecimal(((object)o));
        }

        public static double GetValueDouble(object o)
        {
            double Result = 0;
            if (o == null)
                return 0;
            try
            {
                Result = double.Parse(o.ToString());
            }
            catch (Exception)
            {
                Result = 0;
            }
            return Result;
        }

        public static float GetValueFloat(object o)
        {
            float Result = 0;
            if (o == null)
                return 0;
            try
            {
                Result = float.Parse(o.ToString());
            }
            catch (Exception)
            {
                Result = 0;
            }
            return Result;
        }

        public static int GetValueInt(object o)
        {
            int Result = 0;
            if (o == null)
                return 0;
            try
            {
                Result = int.Parse(o.ToString());
            }
            catch (Exception)
            {
                Result = 0;
            }
            return Result;
        }

        public static string GetValueString(object o)
        {
            string Result = "";
            if (o == null)
                return "";
            try
            {
                Result = o.ToString();
            }
            catch (Exception)
            {
                Result = "";
            }
            return Result;
        }

        public static DateTime GetValueDateTime(object o)
        {
            DateTime Result = new DateTime(1970, 1, 1);
            try
            {
                Result = DateTime.Parse(o.ToString());
            }
            catch (Exception)
            {

            }
            return Result;

        }

        public static bool GetValuebool(object o)
        {
            bool Result = false;
            if (o == null)
                return Result;
            try
            {
                Result = o.ToString()=="1" || o.ToString().ToLower()== "true";
            }
            catch (Exception)
            {
                Result = false;
            }
            return Result;
        }
    }

    public class CRegistry
    {
        public static bool WriteRegistryFiles(FileRegistry FR)
        {
            bool Result = true;
            try
            {
                List<FileRegistry> LF = new List<FileRegistry>();
                LF = CRegistry.LoadRegistryFiles();
                LF.Add(FR);
                Result = WriteRegistryFiles(LF);
            }
            catch (Exception ex)
            {
                Result = false;
                GControls.Message.MSBox.Show("Error", ex);
            }
            return Result;
        }
        public static List<FileRegistry> LoadRegistryFiles()
        {
            List<FileRegistry> Result = new List<FileRegistry>();
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("Support Fund").CreateSubKey("Files");
                foreach (string item in key.GetSubKeyNames())
                {
                    FileRegistry t = new FileRegistry();
                    Microsoft.Win32.RegistryKey subkey = key.CreateSubKey(item);
                    t.FileName = RegistryGetValue(subkey, "FileName");
                    t.FilePath = RegistryGetValue(subkey, "FilePath");
                    t.UserName = RegistryGetValue(subkey, "UserName");
                    t.Path = subkey.ToString();
                    Result.Add(t);
                }
            }
            catch (Exception ex)
            {
                GControls.Message.MSBox.Show("Error", ex);
            }
            return Result;
        }
        public static bool WriteRegistryFiles(List<FileRegistry> LFR)
        {
            bool Result = true;
            try
            {
                Microsoft.Win32.RegistryKey key;
                Microsoft.Win32.RegistryKey Subkey;
                int i = 1;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("Support Fund").CreateSubKey("Files");
                RegistryDeleteContent(key);

                foreach (FileRegistry item in LFR)
                {
                    Subkey = key.CreateSubKey(i.ToString());
                    Subkey.SetValue("FileName", item.FileName);
                    Subkey.SetValue("FilePath", item.FilePath);
                    Subkey.SetValue("UserName", item.UserName);
                    Subkey.Close();
                    i++;
                }
            }
            catch (Exception ex)
            {
                Result = false;
                GControls.Message.MSBox.Show("Error", ex);
            }

            return Result;
        }
        public static string RegistryGetValue(RegistryKey key,string Name)
        {
            string Result = "";
            try
            {
                Result = key.GetValue(Name).ToString();
            }
            catch (Exception)
            {
                Result = "";
            }
            return Result;
        }
        public static void RegistrySetValue(string Path, string Name,string Value)
        {
            Registry.SetValue(Path, Name, Value);
        }
        public static void RegistryDeleteContent(RegistryKey key)
        {
            foreach (string item in key.GetSubKeyNames())
                key.DeleteSubKey(item);
        }

        public static void RegistryDelete(string Path)
        {
            Registry.CurrentUser.DeleteSubKeyTree(Path);
        }

    }

   public class FileRegistry
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string  UserName { get; set; }

        public string Path { get; set; }
    }

    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }

}


