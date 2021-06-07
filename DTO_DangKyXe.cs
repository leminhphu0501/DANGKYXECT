using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DangKyXeCT
{
    public class DTO_DangKyXe
    {
        private int _DKXCONGTAC_ID;
        private string _DKXCONGTAC_Nguoichuanbi;
        private string _DKXCONGTAC_Ngaybatdau;
        private string _DKXCONGTAC_Ngayketthuc;
        private string _DKXCONGTAC_Noidi;
        private string _DKXCONGTAC_Noiden;
        private string _DKXCONGTAC_Thanhphan;
        private string _DKXCONGTAC_Sokm;
        private string _DKXCONGTAC_Soghedukien;
        private string _DKXCONGTAC_Noidung;
        private string _DKXCONGTAC_Donvichutri;
        private string _DKXCONGTAC_Ghichu;

        public int DKXCONGTAC_ID
        {
            get
            {
                return _DKXCONGTAC_ID;
            }

            set
            {
                _DKXCONGTAC_ID = value;
            }
        }

        public string DKXCONGTAC_Nguoichuanbi
        {
            get
            {
                return _DKXCONGTAC_Nguoichuanbi;
            }

            set
            {
                _DKXCONGTAC_Nguoichuanbi = value;
            }
        }

        public string DKXCONGTAC_Ngaybatdau
        {
            get
            {
                return _DKXCONGTAC_Ngaybatdau;
            }

            set
            {
                _DKXCONGTAC_Ngaybatdau = value;
            }
        }

        public string DKXCONGTAC_Ngayketthuc
        {
            get
            {
                return _DKXCONGTAC_Ngayketthuc;
            }

            set
            {
                _DKXCONGTAC_Ngayketthuc = value;
            }
        }

        public string DKXCONGTAC_Noidi
        {
            get
            {
                return _DKXCONGTAC_Noidi;
            }

            set
            {
                _DKXCONGTAC_Noidi = value;
            }
        }

        public string DKXCONGTAC_Noiden
        {
            get
            {
                return _DKXCONGTAC_Noiden;
            }

            set
            {
                _DKXCONGTAC_Noiden = value;
            }
        }

        public string DKXCONGTAC_Thanhphan
        {
            get
            {
                return _DKXCONGTAC_Thanhphan;
            }

            set
            {
                _DKXCONGTAC_Thanhphan = value;
            }
        }

        public string DKXCONGTAC_Sokm
        {
            get
            {
                return _DKXCONGTAC_Sokm;
            }

            set
            {
                _DKXCONGTAC_Sokm = value;
            }
        }

        public string DKXCONGTAC_Soghedukien
        {
            get
            {
                return _DKXCONGTAC_Soghedukien;
            }

            set
            {
                _DKXCONGTAC_Soghedukien = value;
            }
        }

        public string DKXCONGTAC_Noidung
        {
            get
            {
                return _DKXCONGTAC_Noidung;
            }

            set
            {
                _DKXCONGTAC_Noidung = value;
            }
        }

        public string DKXCONGTAC_Donvichutri
        {
            get
            {
                return _DKXCONGTAC_Donvichutri;
            }

            set
            {
                _DKXCONGTAC_Donvichutri = value;
            }
        }

        public string DKXCONGTAC_Ghichu
        {
            get
            {
                return _DKXCONGTAC_Ghichu;
            }

            set
            {
                _DKXCONGTAC_Ghichu = value;
            }
        }

        public DTO_DangKyXe()
        {

        }

        public DTO_DangKyXe(int id, string Nguoichuanbi, string Ngaybatdau, string Ngayketthuc, string Noidi, string Noiden,
            string Thanhphan, string Sokm, string Soghedukien, string Noidung, string Donvichutri, string Ghichu)
        {
            this.DKXCONGTAC_ID = id;
            this.DKXCONGTAC_Nguoichuanbi = Nguoichuanbi;
            this.DKXCONGTAC_Ngaybatdau = Ngaybatdau;
            this.DKXCONGTAC_Ngayketthuc = Ngayketthuc;
            this.DKXCONGTAC_Noidi = Noidi;
            this.DKXCONGTAC_Noiden = Noiden;
            this.DKXCONGTAC_Thanhphan = Thanhphan;
            this.DKXCONGTAC_Sokm = Sokm;
            this.DKXCONGTAC_Soghedukien = Soghedukien;
            this.DKXCONGTAC_Noidung = Noidung;
            this.DKXCONGTAC_Donvichutri = Donvichutri;
            this.DKXCONGTAC_Ghichu = Ghichu;
        }
    }
}
