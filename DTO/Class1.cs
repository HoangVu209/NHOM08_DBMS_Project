using System.Data;
using System.Data.SqlTypes;
using System.Security.AccessControl;

namespace Project.DTO
{
    public class TaiKhoanDTO
    {
        private string _tenDangNhap;
        private string _matKhau;
        private int _loaiTaiKhoan;
        private int _IDAccount;
        public string TenDangNhap { get { return _tenDangNhap; } set { _tenDangNhap = value; } }
        public string MatKhau { get { return this._matKhau; } set { this._matKhau = value; } }
        public int LoaiTaiKhoan { get { return this._loaiTaiKhoan; } set { this._loaiTaiKhoan = value; } }
        public TaiKhoanDTO()
        {
            _tenDangNhap = "";
            _matKhau = "";
            _loaiTaiKhoan = 0;
            _IDAccount = 0;
        }
        public TaiKhoanDTO(string tenDangNhap, string MatKhau, int LoaiTaiKhoan)
        {
            _tenDangNhap = tenDangNhap;
            _matKhau = MatKhau;
            _loaiTaiKhoan = LoaiTaiKhoan;
            _IDAccount = 0;
        }
        public int IDAccount { get { return _IDAccount; } set { _IDAccount = value; } }
    }
    public class KhachHangDTO
    {
        private string _maKhachHang;
        private string _hoTen;
        private string _dienThoai;
        private string _email;
        private int _IDTaiKhoan;
        //private string _tenDangNhap;

        public string MaKhachHang { get { return _maKhachHang; } set { _maKhachHang = value; } }
        public string HoTen { get { return _hoTen; } set { _hoTen = value; } }
        public string DienThoai { get { return _dienThoai; } set { _dienThoai = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        //public string TenDangNhap { get { return _tenDangNhap; } set { _tenDangNhap = value; } }

        public int IDTaiKhoan { get { return _IDTaiKhoan; } set { _IDTaiKhoan = value; } }
        public KhachHangDTO()
        {
            _maKhachHang = string.Empty;
            _hoTen = string.Empty;
            _dienThoai = string.Empty;
            _email = string.Empty;
            //_tenDangNhap = string.Empty;
            _IDTaiKhoan = 0;
        }
        public KhachHangDTO(string tenDangNhap)
        {
            _maKhachHang = string.Empty;
            _hoTen = string.Empty;
            _dienThoai = string.Empty;
            _email = string.Empty;
            _IDTaiKhoan = 0;
           // _tenDangNhap = tenDangNhap;
        }
        public KhachHangDTO(string DienThoai, string HoTen, string Email
                            , string MaKhachHang)
        {
            _IDTaiKhoan = 0;
            _maKhachHang = MaKhachHang;
            _hoTen = HoTen;
            _email = Email;
            _dienThoai = DienThoai;
        }


    }
    public class DoiTacDTO
    {
        private string _maDoiTac;
        private string _email;
        private string _tenCuaHang;
        private string _nguoiDaiDien;
        private int _soLDonDuKien;
        //private string _tGMoCua;
        //private string _tDongCua;
        private string _tinhTrang;
        private int _slChiNhanh;
        private string _NgayCapNhat;
        private string _tenDangNhap;

        public DoiTacDTO()
        {
            _maDoiTac = string.Empty;
            _email = string.Empty;
            _tenCuaHang = string.Empty;
            _nguoiDaiDien = string.Empty;
            _soLDonDuKien = 0;
            //_tGMoCua = string.Empty;
            //_tDongCua = string.Empty;
            _tinhTrang = string.Empty;
            _slChiNhanh = 0;
            _NgayCapNhat = string.Empty;
            _tenDangNhap = string.Empty;
        }
        public DoiTacDTO(string maDoiTac, string email, string tenCuaHang, string nguoiDaiDien, int soLDonDuKien, string tinhTrang, int slChiNhanh, string ngayCapNhat, string tenDangNhap)
        {
            _maDoiTac = maDoiTac;
            _email = email;
            _tenCuaHang = tenCuaHang;
            _nguoiDaiDien = nguoiDaiDien;
            _soLDonDuKien = soLDonDuKien;
            //_tGMoCua = tGMoCua;
            //_tDongCua = tDongCua;
            _tinhTrang = tinhTrang;
            _slChiNhanh = slChiNhanh;
            _NgayCapNhat = ngayCapNhat;
            _tenDangNhap = tenDangNhap;
        }
        public DoiTacDTO(string maDoiTac, string email, string tenCuaHang, string nguoiDaiDien, int soLDonDuKien, string tenDangNhap)
        {
            _maDoiTac = maDoiTac;
            _email = email;
            _tenCuaHang = tenCuaHang;
            _nguoiDaiDien = nguoiDaiDien;
            _soLDonDuKien = soLDonDuKien;
            _tenDangNhap = tenDangNhap;
            //_tGMoCua = string.Empty;
            //_tDongCua = string.Empty;
            _tinhTrang = string.Empty;
            _slChiNhanh = 0;
            _NgayCapNhat = string.Empty;
        }
        public string MaDoiTac { get { return _maDoiTac; } set { _maDoiTac = value; } }
        public string Email { get { return _email;} set { _email = value; } }
        public string TenCuaHang { get { return _tenCuaHang; } set { _tenCuaHang = value; } }

        public string NguoiDaiDien { get { return _nguoiDaiDien; } set { _nguoiDaiDien= value; } }
        public string tenDangNhap { get { return _tenDangNhap; } set { _tenDangNhap = value; } }

       // public string TGDongCua { get { return _tDongCua; } set { _tDongCua = value; } }
        //public string TGMoCua { get { return _tGMoCua; } set { _tGMoCua= value; } }  
        public string TinhTrang { get { return _tinhTrang; } set { _tinhTrang = value; } }
        public int SoLuongChiNhanh { get { return _slChiNhanh; }set { _slChiNhanh= value; } }
        public string NgayCapNhap { get { return _NgayCapNhat; } set { _NgayCapNhat = value; } }

        public int SoLuongDonDuKien { get { return _soLDonDuKien; } set { _soLDonDuKien= value; } }
    }
    public class MonAnDTO
    {
        private string _maMonAn;
        private string _tenMonAn;
        private string _tinhTrang;
        private int _luotLike;
        private decimal _Gia;
        public MonAnDTO(string maMonAn, string tenMonAn, string tinhTrang, int luotLike, decimal money)
        {
            _maMonAn = maMonAn;
            _tenMonAn = tenMonAn;
            _tinhTrang = tinhTrang;
            _luotLike = luotLike;
            _Gia = money;
        }
        public MonAnDTO() 
        {
            _maMonAn = string.Empty;
            _tenMonAn = string.Empty;
            _tinhTrang = string.Empty;
            _luotLike = 0;
            _Gia = 0;
        }
        public string MaMonAn { get { return _maMonAn; }  set { _maMonAn = value; } }
        public string TenMonAn { get { return _tenMonAn; } set { _tenMonAn = value; } }
        public string TinhTrang { get { return _tinhTrang; } set { _tinhTrang = value; } }
        public int LuotLike { get { return _luotLike; } set { _luotLike = value; } }
        public decimal Gia { get { return _Gia; } set { _Gia = value; } }
    }
    public class ThucDonDTO
    {
        private string _maDoiTac;
        private string _maThucDon;
        private string _tenThucDon;
        private List<MonAnDTO> _danhSachMonAn;
        
        public ThucDonDTO() 
        {
            _maDoiTac = string.Empty;
            _maThucDon = string.Empty;
            _tenThucDon = string.Empty;
            _danhSachMonAn = new List<MonAnDTO>();
        }
        public ThucDonDTO(string MaDoiTac, string MaThucDon, string TenThucDon, List<MonAnDTO> danhSach)
        {
            _maDoiTac = MaDoiTac;
            _maThucDon= MaThucDon;
            _tenThucDon= TenThucDon;
            _danhSachMonAn = danhSach;
        }
        public ThucDonDTO(ThucDonDTO p)
        {
            this._maDoiTac = p._maDoiTac;
            this._tenThucDon = p._tenThucDon;
            this._maThucDon = p._maThucDon;
            this._danhSachMonAn = p._danhSachMonAn;
        }
        public string MaDoiTac { get { return _maDoiTac; } set { _maDoiTac = value;} }
        public string MaThucDon { get { return _maThucDon; } set { _maThucDon = value;} }
        public string TenThucDon { get { return _tenThucDon; } set { _tenThucDon = value; } }
        public List<MonAnDTO> DanhSachMonAn { get { return _danhSachMonAn; } set { _danhSachMonAn = value; } }
    }

    public class DONHANGDTO
    {
        private string _maDonHang;
        private List<MonAnDTO> _danhSachMonAn;
        private List<int> _danhSachSL;
        private string _maTinhTrang;
        private string _maDoiTac;
        private int _STT;
        private decimal _tongTien;
        private string _maKhachHang;
        private int _IDCuaHang;
        public DONHANGDTO()
        {
            _maDonHang = string.Empty;
            _danhSachMonAn = new List<MonAnDTO>();
            _danhSachSL = new List<int> { 0 };
            _maTinhTrang= string.Empty;
            _maDoiTac = string.Empty;
            _STT = 0;
            _tongTien = 0;
            _maKhachHang = string.Empty;
            _IDCuaHang = 0;
        }
        public DONHANGDTO(string maDonHang,List<MonAnDTO> danhSachMonAn, List<int>listdanhSachSL, int IDCuaHang)
        {
            _maDonHang = maDonHang;
            _danhSachMonAn = new List<MonAnDTO>();
            _danhSachMonAn = danhSachMonAn;
            _danhSachSL = new List<int>();
            _danhSachSL = listdanhSachSL;
            _maTinhTrang = string.Empty;
            _STT = -1;
            _tongTien = 0;
            _maDoiTac = string.Empty;
            _maKhachHang = string.Empty;
            _IDCuaHang = IDCuaHang;
        }
        public DONHANGDTO(string maDonHang, List<MonAnDTO> danhSachMonAn, List<int> danhSachSL,
                           string maTinhTrang, string maDoiTac, int STT, decimal tongTien, string MaKhachHang, int IDCuaHang)
        {
            _maDonHang = maDonHang;
            _danhSachMonAn = new List<MonAnDTO>();
            _danhSachMonAn = danhSachMonAn;
            _danhSachSL = new List<int>();
            _danhSachSL = danhSachSL;
            _maDoiTac = maDoiTac;
            _maTinhTrang = maTinhTrang;
            _STT = STT;
            _tongTien = tongTien;
            _maKhachHang = MaKhachHang;
            _IDCuaHang = IDCuaHang;

        }
        
        public string MaDonHang { get { return _maDonHang; } set { _maDonHang= value; } }   
        public List<MonAnDTO> DanhSachMonAn { get { return _danhSachMonAn; } set { _danhSachMonAn = value; } }
        public List<int> danhsachSL { get { return _danhSachSL; } set { _danhSachSL= value; } } 
        public string MaDoiTac { get { return _maDoiTac; } set { _maDoiTac = value; } }
        public string MaTinhTrang { get { return _maTinhTrang; } set { _maTinhTrang = value; } }
        public decimal TongTien { get { return _tongTien; } set { _tongTien = value; } }
        public int STT { get { return _STT; } set { _STT = value; } }
        public string maKhachHang { get { return _maKhachHang; } set { _maKhachHang = value;} }
        public int IDCuaHang { get { return _IDCuaHang; } set { _IDCuaHang = value; } }
    }
       
}