using Project.DTO;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace Project.DAO
{
    public class TaiKhoanDAO
    {
        static public SqlConnection? _connection = null;
        static public SqlCommand? _command = null;
        static String _connectionString = @"Data Source=WUDV;Initial Catalog=OfficialAdvanced;Integrated Security=True";

        //Thêm một tài khoản
        public static int Insert(TaiKhoanDTO t)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spThemTaiKhoan";
                _command= new SqlCommand( procName );
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection= _connection;

                //truyền tham số
                _command.Parameters.Add("@tenDangNhap", SqlDbType.VarChar);
                _command.Parameters.Add("@matKhau", SqlDbType.VarChar);
                _command.Parameters.Add("@loaiTaiKhoan", SqlDbType.Int);

                //truyền giá trị cho tham số
                _command.Parameters["@tenDangNhap"].Value = t.TenDangNhap;
                _command.Parameters["@matKhau"].Value = t.MatKhau;
                _command.Parameters["@loaiTaiKhoan"].Value = t.LoaiTaiKhoan;

                //thực thi SQL
                int n = _command.ExecuteNonQuery();
               
                
                _connection.Close();
                return n;
           
            }
            catch { return -1; }
        }
        public static int Login(TaiKhoanDTO t)
        {

            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spDangNhap";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@tenDangNhap", SqlDbType.VarChar);
                _command.Parameters.Add("@matKhau", SqlDbType.VarChar);
                _command.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                //truyền giá trị cho tham số
                _command.Parameters["@tenDangNhap"].Value = t.TenDangNhap;
                _command.Parameters["@matKhau"].Value = t.MatKhau;
                _command.Parameters["@ReturnValue"].Value = 0;
                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                int result = (int)_command.Parameters["@ReturnValue"].Value;
                _connection.Close();

                return (int)result;

            }
            catch { return -1; }
        }
        public static string TokenValue(TaiKhoanDTO t)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spLayMa";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@IDTaiKhoan", SqlDbType.Int);
                _command.Parameters.Add("@loaiTaiKhoan", SqlDbType.Int);
               
                //truyền giá trị cho tham số
                _command.Parameters["@IDTaiKhoan"].Value = t.IDAccount;
                _command.Parameters["@loaiTaiKhoan"].Value = t.LoaiTaiKhoan;
                
                //paraReturn.Direction = ParameterDirection.ReturnValue;
                
                string result = "";
               
                //thực thi SQL
               // int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);
                
                _connection.Close();
                
           
                result = (String)table.Rows[0]["MaTK"];

                return result;

            }
            catch(ArgumentException e) { return e.ToString(); }
        }
        public static int getIDAccount(string tenDangNhap)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spLayIDTaiKhoan";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@tenDangNhap", SqlDbType.VarChar, 115);
                var returnParameter = _command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                //truyền giá trị cho tham số
                _command.Parameters["@tenDangNhap"].Value = tenDangNhap;
               
                int n = _command.ExecuteNonQuery();

                int result = Convert.ToInt32(returnParameter.Value);
                _connection.Close();


                
                return result;

            }
            catch (ArgumentException e) { 
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
    }
    public class KhachHangDAO
    {
        static public SqlConnection? _connection = null;
        static public SqlCommand? _command = null;
        static String _connectionString = @"Data Source=WUDV;Initial Catalog=OfficialAdvanced;Integrated Security=True";
        public static DataTable GetInfor(string MaKH)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spThongTinKhachHang";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maKhachHang", SqlDbType.Char, 8);
                

                //truyền giá trị cho tham số
                _command.Parameters["@maKhachHang"].Value = MaKH;
                

                //thực thi SQL
                //int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);
              
                _connection.Close();

                return table;

            }
            catch (ArgumentException e) {
                DataTable table1= new DataTable();
                Console.Write(e.ToString());
                return table1;
            }
        }
        public static DataTable xemThucDon(string maThucDon, int selection)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName;

                if (selection == 1)
                    procName = "usp_phantom_sualoi_KH01";
                else if (selection == 0)
                    procName = "usp_phantom_KH01";
                else if (selection == 2)
                    procName = "spLayMonAn";
                else if (selection == 3)
                    procName = "usp_unrepeatable_docThucDon";
                else
                    procName = "usp_unrepeatable_sualoi_docThucDon";
                //Console.WriteLine(procName);
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maThucDon", SqlDbType.Char, 8);


                //truyền giá trị cho tham số
                _command.Parameters["@maThucDon"].Value = maThucDon;


                //thực thi SQL
                //int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(procName, _connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@maThucDon", SqlDbType.Char, 8).Value = maThucDon;
                adapter.Fill(table);
                
                _connection.Close();
                return table;

            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return table1;
            }
        }
        public static int ThemChiTietDonHang(string maDonHang, string maMonAn, int soLuong)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spThemChiTietDonHang";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maDonHang", SqlDbType.Char, 8);
                _command.Parameters.Add("@maMonAn", SqlDbType.Char, 8);
                _command.Parameters.Add("@soLuong", SqlDbType.Int);


                //truyền giá trị cho tham số
                _command.Parameters["@maDonHang"].Value = maDonHang;
                _command.Parameters["@maMonAn"].Value = maMonAn;
                _command.Parameters["@soLuong"].Value = soLuong;


                //thực thi SQL
                int n = _command.ExecuteNonQuery();
           
                _connection.Close();
                if (n > 0)
                    return 1;
                return 0;
               

            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return 0;
            }
        }
    }
    public class DOITACDAO
    {
        static public SqlConnection? _connection = null;
        static public SqlCommand? _command = null;
        static String _connectionString = @"Data Source=WUDV;Initial Catalog=OfficialAdvanced;Integrated Security=True";
        public static DataTable GetInfor()
        {
           
            try
            {   
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spLayDoiTac";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);

                _connection.Close();

                return table;

            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return table1;
            }
        }
        public static DataTable LayThucDon(string maDoiTac) 
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spLayThucDon";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;
                //truyền tham số
                _command.Parameters.Add("@maDoiTac", SqlDbType.Char, 8);


                //truyền giá trị cho tham số
                _command.Parameters["@maDoiTac"].Value = maDoiTac;
                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);

                _connection.Close();

                return table;

            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return table1;
            }
        }
        public static DataTable layThongTinDoiTac (string maDoiTac)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "layThongTinDoiTac";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;
                //truyền tham số
                _command.Parameters.Add("@maDoiTac", SqlDbType.Char, 8);


                //truyền giá trị cho tham số
                _command.Parameters["@maDoiTac"].Value = maDoiTac;
                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);

                _connection.Close();

                return table;

            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return table1;
            }
        }
        public static int CapNhatThucDon(string maThucDon, string maMonAn, string tinhTrang, 
                                            Decimal giaTien, int selection)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                
                String procName = "capNhatThucDon";
                if (selection == 0)
                    procName = "usp_UrepeatableRead_ThucDon";
                else if (selection == 1) procName = "capNhatThucDon";
                else if (selection == 2) procName = "usp_dirtyread_DT01";
                _command = new SqlCommand(procName);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
                //truyền tham số
                _command.Parameters.Add("@maThucDon", SqlDbType.Char, 8);
                _command.Parameters.Add("@maMonAn", SqlDbType.Char, 8);
                _command.Parameters.Add("@tinhTrang", SqlDbType.NVarChar);
          
                _command.Parameters.Add("@Gia", SqlDbType.Money);
                var returnPara = _command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                returnPara.Direction = ParameterDirection.ReturnValue;



                //truyền giá trị cho tham số
                _command.Parameters["@maThucDon"].Value = maThucDon;
                _command.Parameters["@maMonAn"].Value = maMonAn;
           
                _command.Parameters["@tinhTrang"].Value = tinhTrang;
                _command.Parameters["@Gia"].Value = giaTien;
                
                //thực thi SQL
                int n = _command.ExecuteNonQuery();

                int result = Convert.ToInt32(returnPara.Value);
                _connection.Close();
                
                if (result > 0)
                    return 1;
                return 0;
                //return table;

            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return 0;
            }
        }
        public static DataTable layChiTietDonHang(string maDoiTac, string maTinhTrang)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "layDonHang";
                _command = new SqlCommand(procName);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
                //truyền tham số
                _command.Parameters.Add("@maDoiTac", SqlDbType.Char, 8);
                _command.Parameters.Add("@maTinhTrang", SqlDbType.Char, 3);
  


                //truyền giá trị cho tham số
                _command.Parameters["@maDoiTac"].Value = maDoiTac;
                _command.Parameters["@maTinhTrang"].Value = maTinhTrang;

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);


                //thực thi SQL
                //int n = _command.ExecuteNonQuery();


                _connection.Close();
                return table;
                
            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return table1;
            }
        }
        public static int TiepNhanDonHang(String maDonHang, int selection)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
               
                //String procName = "spTiepNhanDonHang";
                String procName = "usp_LU_DONHANG_DT";
                if(selection == 1)
                {
                    procName = "usp_LU_sualoi_DONHANG_DT";
                }
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maDonHang", SqlDbType.Char, 8);
                _command.Parameters.Add("@maTinhTrang", SqlDbType.Char, 3);
                var ReturnValue = _command.Parameters.Add("@result", SqlDbType.Int);
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                //truyền giá trị cho tham số
                _command.Parameters["@maDonHang"].Value = maDonHang;
                _command.Parameters["@maTinhTrang"].Value = "ST1";
                //_command.Parameters["@result"].Value = 0;
                
                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                int result = Convert.ToInt32(ReturnValue.Value);
                _connection.Close();
                

                return result;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
                return 0;

            }
        }
        public static int ThemMonAnVaoThucDon(string maThucDon, string maMonAn, decimal Gia)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spThemMonAnThucDon";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maThucDon", SqlDbType.Char, 8);
                _command.Parameters.Add("@maMonAn", SqlDbType.Char, 8);
                _command.Parameters.Add("@Gia", SqlDbType.Money, 8);


                //truyền giá trị cho tham số
                _command.Parameters["@maThucDon"].Value = maThucDon;
                _command.Parameters["@maMonAn"].Value = maMonAn;
                _command.Parameters["@Gia"].Value = Gia;

                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                _connection.Close();
               

                return n;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
    }
    public class DONHANGDAO
    {
        static public SqlConnection? _connection = null;
        static public SqlCommand? _command = null;
        static String _connectionString = @"Data Source=WUDV;Initial Catalog=OfficialAdvanced;Integrated Security=True";
        public static string TaoMa()
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "Generate_RCID";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maDH", SqlDbType.Char, 8).Direction = ParameterDirection.Output;


                //truyền giá trị cho tham số
                _command.Parameters["@maDH"].Value = "";


                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                _connection.Close();
                string result = (String)_command.Parameters["@maDH"].Value;

                return result;

            }
            catch (ArgumentException e)
            {
                return e.ToString();
            }
        }
        public static int LuuDonHang(string maKhachHang, string maDonHang, string maTinhTrang, string maDoiTac, int STT, int IDCuaHang)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                //Lưu đơn hàng
                String procName = "Regis_RC";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                //_command.Parameters.Add("@maDonHang", SqlDbType.Char, 8);
                _command.Parameters.Add("@maKhachHang", SqlDbType.Char, 8);
                _command.Parameters.Add("@tenTinhTrang", SqlDbType.VarChar, 30);
                _command.Parameters.Add("@IDCuaHang", SqlDbType.Int);
                _command.Parameters.Add("@thoiGianLap", SqlDbType.DateTime);

                //truyền giá trị cho tham số
                //_command.Parameters["@maDonHang"].Value = maDonHang;
                _command.Parameters["@maKhachHang"].Value = maKhachHang;
                _command.Parameters["@tenTinhTrang"].Value = maTinhTrang;
                _command.Parameters["@IDCuaHang"].Value = IDCuaHang;
                _command.Parameters["@thoiGianLap"].Value = DateTime.Now;


                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                _connection.Close();
                //string result = (String)_command.Parameters["@maDH"].Value;
                if (n > 0)
                    return 1;
                return 0;
                    
                
                //return result;
            }
            catch(ArgumentException e)
            {
                //(e.ToString());
                Console.WriteLine(e.Message);
                return 0;
            }

        }
        public static string LayTinhTrang(string maDonHang)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                //Lưu đơn hàng
                String procName = "theoDoiDonHang_DonHang";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maDonHang", SqlDbType.Char, 8);
                
           

                //truyền giá trị cho tham số
                _command.Parameters["@maDonHang"].Value = maDonHang;
               

                //thực thi SQL
               // int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table) ;
                _connection.Close();
                string result;
                if (table.Rows[0]["tenTinhTrang"] != DBNull.Value)
                    result = (String)table.Rows[0]["tenTinhTrang"];
                else
                    result = "Recieved";
                return result;


                //return result;
            }
            catch (ArgumentException e)
            {
                //(e.ToString());
                return e.ToString();
            }
        }
        public static int HuyDonHang(string maDonHang)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                //Lưu đơn hàng
                //String procName = "HuyDonHang";
                String procName = "usp_LU_DONHANG_KH";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maDonHang", SqlDbType.Char, 8);
                _command.Parameters.Add("@tenTinhTrang", SqlDbType.VarChar, 30);
                var returnParameter = _command.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                //_command.Parameters.Add("giaTriTraVe", SqlDbType)


                //truyền giá trị cho tham số
                _command.Parameters["@maDonHang"].Value = maDonHang;
                _command.Parameters["@tenTinhTrang"].Value = "Canceled"; 
                    



                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                int result = Convert.ToInt32(returnParameter.Value);

                _connection.Close();
                //string result;
                return result;


                //return result;
            }
            catch (ArgumentException e)
            {
                //(e.ToString());
                Console.WriteLine(e.ToString());
                return 0;
            }
        }

        public static int LayIDCuaHang(string maDoiTac)
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                //Lưu đơn hàng
                //String procName = "HuyDonHang";
                String procName = "spTimIDCuaHang";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maDoiTac", SqlDbType.Char, 8);
               
                var returnParameter = _command.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                //_command.Parameters.Add("giaTriTraVe", SqlDbType)


                //truyền giá trị cho tham số
                _command.Parameters["@maDoiTac"].Value = maDoiTac ;
            



                //thực thi SQL
                int n = _command.ExecuteNonQuery();
                int result = Convert.ToInt32(returnParameter.Value);

                _connection.Close();
                //string result;
                return result;


                //return result;
            }
            catch (ArgumentException e)
            {
                //(e.ToString());
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
    }    
    public class THUCDONDAO
    {
        static public SqlConnection? _connection = null;
        static public SqlCommand? _command = null;
        static String _connectionString = @"Data Source=WUDV;Initial Catalog=OfficialAdvanced;Integrated Security=True";
        public static int laySTT(string maDoiTac)
        {

            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spLaySTT";
                _command = new SqlCommand(procName);
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Connection = _connection;

                //truyền tham số
                _command.Parameters.Add("@maDoiTac", SqlDbType.Char, 8);

                //truyền giá trị cho tham số
                _command.Parameters["@maDoiTac"].Value = maDoiTac;


                //thực thi SQL
                //
                //int n = _command.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);
                _connection.Close();
                int result =  Convert.ToInt32(table.Rows[0]["STT"]);

                return result;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }

    }
    public class MONANDAO
    {
        static public SqlConnection? _connection = null;
        static public SqlCommand? _command = null;
        static String _connectionString = @"Data Source=WUDV;Initial Catalog=OfficialAdvanced;Integrated Security=True";
        public static DataTable layMaMonAn()
        {
           
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spLayDanhSachMonAn";
                _command = new SqlCommand(procName);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
     

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(table);


                //thực thi SQL
                //int n = _command.ExecuteNonQuery();


                _connection.Close();
                return table;

            }
            catch (ArgumentException e)
            {
                DataTable table1 = new DataTable();
                Console.Write(e.ToString());
                return table1;
            }
            
        }
        public static decimal layGiaTienMonAn(string maThucDon, string maMonAn)
        {

            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procName = "spLayGiaTienMonAn";
                _command = new SqlCommand(procName);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
                
                _command.Parameters.Add("@maThucDon", SqlDbType.Char, 8).Value = maThucDon;
                _command.Parameters.Add("@maMonAn", SqlDbType.Char, 8).Value = maMonAn;
                var returnParameter = _command.Parameters.Add("@returnValue", SqlDbType.Money);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                
                
               int n  = _command.ExecuteNonQuery();
                    
                _connection.Close();
                decimal value = Convert.ToDecimal(returnParameter.Value);
                //decimal giaTien = Convert.ToDecimal(table.Rows[0]["Gia"]);
                return value;

            }
            catch (ArgumentException e)
            {
                decimal errrorValue = 0;
                Console.Write(e.ToString());
                return errrorValue;
            }

        }
    }

}