using Project.DAO;
using Project.DTO;
using System.Data;

namespace Project.BUS
{
    public class TaiKhoanBUS
    {
        public static int Insert(TaiKhoanDTO t)
        {
            int n = TaiKhoanDAO.Insert(t);
            return n;
        }
        public static int Login(TaiKhoanDTO t)
        {
            int n = TaiKhoanDAO.Login(t);
            return n;
        }
        public static string TokenValue(TaiKhoanDTO t)
        {
            string tokenValue = TaiKhoanDAO.TokenValue(t);
            return tokenValue;
        }
        public static int getIDAccount(string tenDangNhap)
        {
            return TaiKhoanDAO.getIDAccount(tenDangNhap);
        }

    }
    public class KhachHangBUS
    {
        public static DataTable GetInfor(String MaKH)
        {
            DataTable table = new DataTable();
            table = KhachHangDAO.GetInfor(MaKH);
            return table;
        }
        public static DataTable LayMonAn(String MaThucDon, int selection)
        {
            DataTable table = new DataTable();
            table = KhachHangDAO.xemThucDon(MaThucDon, selection);
            return table;
        }
        public static int ThemChiTietDonHang(String maDonHang, String maMonAn, int soLuong)
        {
            int result = KhachHangDAO.ThemChiTietDonHang(maDonHang, maMonAn, soLuong);
            return result;
        }
    }

    public class DOITACBUS
    {
        public static DataTable GetInfor()
        {
            DataTable table = new DataTable();
            table = DOITACDAO.GetInfor();
            return table;
        }
        public static DataTable LayThucDon(string maDoiTac)
        {
            DataTable table = new DataTable();
            table = DOITACDAO.LayThucDon(maDoiTac);
            return table;
        }
        public static DataTable layThongTinDoiTac(string maDoiTac)
        {
            DataTable table = new DataTable();
            table = DOITACDAO.layThongTinDoiTac(maDoiTac);
            return table;
        }
        public static int capNhatThucDon(string maThucDon, string maMonAn, string tinhTrang
                                          , decimal Gia, int selection)
        {
            int result = DOITACDAO.CapNhatThucDon(maThucDon, maMonAn, tinhTrang, Gia, selection);
            return result;
        }
        public static DataTable layChiTietDonHang(string maDoiTac, string maTinhTrang)
        {
            DataTable table = new DataTable();
            table = DOITACDAO.layChiTietDonHang(maDoiTac, maTinhTrang);
            return table;
        }
        public static int TiepNhanDonHang(string maDonHang, int selection)
        {
            return DOITACDAO.TiepNhanDonHang(maDonHang, selection);
        }
        public static int ThemMonAnVaoThucDon(string maThucDon, string maMonAn, Decimal Gia)
        {
            return DOITACDAO.ThemMonAnVaoThucDon(maThucDon, maMonAn, Gia);
        }
    }

    public class DONHANGBUS
    {
        public static string TaoMa()
        {
            string result = DONHANGDAO.TaoMa();
            return result;
        }
        public static int LuuDonHang(string maKhachHang, string maDonHang, string maTinhTrang, string maDoiTac, int STT, int IDCuaHang)
        {
            //DONHANGDTO dh = new DONHANGDTO();
            int result = DONHANGDAO.LuuDonHang(maKhachHang, maDonHang, maTinhTrang, maDoiTac, STT, IDCuaHang);
            return result;
        }
        public static string layTinhTrang(string maDonHang)
        {
            string result = DONHANGDAO.LayTinhTrang(maDonHang);
            return result;
        }
        public static int getIDCuaHang(string maDoiTac)
        {
            return DONHANGDAO.LayIDCuaHang(maDoiTac);
        }
    }

    public class THUCDONBUS
    {
        public static int laySTT(string maDoiTac)
        {
           int STT = THUCDONDAO.laySTT(maDoiTac);
           return STT;
        }
    }

    public class MONANBUS
    {
        public static DataTable layMaMonAn()
        {
            DataTable table = new DataTable();
            table = MONANDAO.layMaMonAn();
            return table;
        }
        public static decimal layGiaMonAn(string maThucDon, string maMonAn)
        {
            return MONANDAO.layGiaTienMonAn(maThucDon, maMonAn);
        }
    }
}