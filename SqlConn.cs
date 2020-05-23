using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace AmbitAAC
{
    class SqlConn
    {
        private static string _DBName;
        private static string _DataSource;
        private static string _PassWord;
        private static string _UserName;

        private static SqlCommand cmd;
        private static SqlConnection conn;
        private static SqlDataAdapter sda;
        private static DataTable dt;            

        public static string GetDbName
        {
            set { _DBName = value; }
            get { return _DBName; }
        }
        public static string GetDataSource
        {
            set { _DataSource = value; }
            get { return _DataSource; }
        }
        public static string GetUserName
        {
            set { _UserName = value; }
            get { return _UserName; }
        }
        public static string GetPassWord
        {
            set { _PassWord = value; }
            get { return _PassWord; }
        }
        public static void Open()
        {
            string strConn = "Data Source = " + _DataSource + "; Initial Catalog = " + _DBName + "; User ID = " + _UserName + "; Password = " + _PassWord;
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static SqlConnection GetConnection()
        {
            Open();
            return conn;
        }
        public static void Close()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Dispose();
                conn.Close();
            }
        }
        public static void ExecuteNonSql(string sql)
        {
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }         
        }
        public static DataTable sqlDataTable(string sql)
        {
            cmd = new SqlCommand();
            sda = new SqlDataAdapter();
            dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            sda.SelectCommand = cmd;
            try
            {
                sda.Fill(dt);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                sda.Dispose();
                Close();
            }
            return dt;
        }
        public DataTable ReadProc(string procName, SqlParameter[] pr)
        {
            cmd = new SqlCommand();
            sda = new SqlDataAdapter();
            dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Connection = GetConnection();
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(pr);
            sda.SelectCommand = cmd;
            try
            {
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                sda.Dispose();
                Close();
            }
            return dt;
        }
        public void InsertProc(string procName, string tblName, DataTable dt)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.AddWithValue(tblName, dt);
            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERTASSEMBLY(string UserID, string Station, string Model, string Label1, string Label2, string Label3, string PartNo, string VendorCode, string POType, string LotNo, string Remark)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERTASSEMBLY";
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Station", Station);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@Label1", Label1);
            cmd.Parameters.AddWithValue("@Label2", Label2);
            cmd.Parameters.AddWithValue("@Label3", Label3);
            cmd.Parameters.AddWithValue("@PartNo", PartNo);
            cmd.Parameters.AddWithValue("@VendorCode", VendorCode);
            cmd.Parameters.AddWithValue("@POType", POType);
            cmd.Parameters.AddWithValue("@LotNo", LotNo);
            cmd.Parameters.AddWithValue("@Remark", Remark);
            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERTASSEMBLY2(string UserID, string Station, string Model, string Label1, string Label2, string Label3, string PartNo, string VendorCode, string POType, string LotNo, string Remark, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERTASSEMBLY2";
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Station", Station);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@Label1", Label1);
            cmd.Parameters.AddWithValue("@Label2", Label2);
            cmd.Parameters.AddWithValue("@Label3", Label3);
            cmd.Parameters.AddWithValue("@PartNo", PartNo);
            cmd.Parameters.AddWithValue("@VendorCode", VendorCode);
            cmd.Parameters.AddWithValue("@POType", POType);
            cmd.Parameters.AddWithValue("@LotNo", LotNo);
            cmd.Parameters.AddWithValue("@Remark", Remark);
            cmd.Parameters.AddWithValue("@Data1", Data1);
            cmd.Parameters.AddWithValue("@Data2", Data2);
            cmd.Parameters.AddWithValue("@Data3", Data3);
            cmd.Parameters.AddWithValue("@Data4", Data4);
            cmd.Parameters.AddWithValue("@Data5", Data5);
            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERTOUTSTOCK(string UserID, string Station, string Model, string Label3, string PartNo, string VendorCode, string POType, string LotNo, string Remark)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERTOUTSTOCK";
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Station", Station);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@Label3", Label3);
            cmd.Parameters.AddWithValue("@PartNo", PartNo);
            cmd.Parameters.AddWithValue("@VendorCode", VendorCode);
            cmd.Parameters.AddWithValue("@POType", POType);
            cmd.Parameters.AddWithValue("@LotNo", LotNo);
            cmd.Parameters.AddWithValue("@Remark", Remark);
            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERTOUTSTOCK2(string UserID, string Station, string Model, string Label3, string PartNo, string VendorCode, string POType, string LotNo, string Remark, string Data1, string Data2, string Data3, string Data4, string Data5)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERTOUTSTOCK2";
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Station", Station);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@Label3", Label3);
            cmd.Parameters.AddWithValue("@PartNo", PartNo);
            cmd.Parameters.AddWithValue("@VendorCode", VendorCode);
            cmd.Parameters.AddWithValue("@POType", POType);
            cmd.Parameters.AddWithValue("@LotNo", LotNo);
            cmd.Parameters.AddWithValue("@Remark", Remark);
            cmd.Parameters.AddWithValue("@Data1", Data1);
            cmd.Parameters.AddWithValue("@Data2", Data2);
            cmd.Parameters.AddWithValue("@Data3", Data3);
            cmd.Parameters.AddWithValue("@Data4", Data4);
            cmd.Parameters.AddWithValue("@Data5", Data5);

            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERT_OQC_VIVO(string PN, string MODEL, string SN_RANGE, string SN3)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERT_OQC_VIVO";
            cmd.Parameters.AddWithValue("@PN", PN);
            cmd.Parameters.AddWithValue("@MODEL", MODEL);
            cmd.Parameters.AddWithValue("@SN_RANGE", SN_RANGE);
            cmd.Parameters.AddWithValue("@SN3", SN3);

            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERT_OQC_LENOVO(string PN, string Model, string SN, string VenderCode, string Place)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERT_OQC_LENOVO";
            cmd.Parameters.AddWithValue("@PN", PN);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@SN", SN);
            cmd.Parameters.AddWithValue("@VenderCode", VenderCode);
            cmd.Parameters.AddWithValue("@Place", Place);

            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERT_OQC_MOTO(string PN, string Model, string SN, string VenderCode, string Place, string Version)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERT_OQC_MOTO";
            cmd.Parameters.AddWithValue("@PN", PN);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@SN", SN);
            cmd.Parameters.AddWithValue("@VenderCode", VenderCode);
            cmd.Parameters.AddWithValue("@Place", Place);
            cmd.Parameters.AddWithValue("@Version", Version);

            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        public void P_INSERT_OQC_HUAWEI(string PN, string MODEL, string SN)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "P_INSERT_OQC_HUAWEI";
            cmd.Parameters.AddWithValue("@PN", PN);
            cmd.Parameters.AddWithValue("@MODEL", MODEL);
            cmd.Parameters.AddWithValue("@SN", SN);

            cmd.Connection = GetConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }
        /*
        ALTER PROCEDURE [dbo].[usp_CheckEmailMobile]
        ( @Name VARCHAR(50), 
        @Email NVARCHAR(50), 
        @Password NVARCHAR(50), 
        @CountryCode INT, 
        @Mobile VARCHAR(50), 
        @Result BIT OUTPUT)
         AS 
        BEGIN 

        IF EXISTS (SELECT COUNT (*) FROM AUser WHERE  [Email] = @Email AND [Mobile] = @Mobile) 
         Begin 
         Set @Result=0; --Email &/or Mobile does not exist in database
        End
        ELSE
        Begin
          --Insert the record & register the user 
        INSERT INTO [AUser] ([Name], [Email], [Password], [CountryCode], [Mobile]) VALUES (@Name, @Email, @Password, @CountryCode, @Mobile)  
        Set @Result=1;
         End

        END


        //Execute Procedure

        bool result=false;
        SqlCommand scCommand = new SqlCommand("usp_CheckEmailMobile", sqlCon);
        scCommand.CommandType = CommandType.StoredProcedure;
        scCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = txtName.Text;
        scCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = txtEmailAddress.Text;
        scCommand.Parameters.Add("@Password ", SqlDbType.NVarChar, 50).Value = txtPassword.Text;
        scCommand.Parameters.Add("@CountryCode", SqlDbType.VarChar.50).Value =ddlCountryCode.SelectedText;
        scCommand.Parameters.Add("@Mobile", SqlDbType.NVarChar, 50).Value = txtMobileNumber.Text;
        scCommand.Parameters.Add("@Result ", SqlDbType.Bit).Direction = ParameterDirection.Output;
        try
        {
            if (scCommand.Connection.State == ConnectionState.Closed)
            {
                scCommand.Connection.Open();
            }
            scCommand.ExecuteNonQuery();
            result = Convert.ToBoolean(scCommand.Parameters["@Result"].Value);


        }
        catch (Exception)
        {

        }
        finally
        {                
            scCommand.Connection.Close();
            Response.Write(result); 
        }
        */
    }
}
