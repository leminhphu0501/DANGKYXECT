using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_DangKyXeCT;
using DTO_DangKyXeCT;

namespace BUS_DangKyXeCT
{
    public class BUS_DangKyXe
    {
        DAL_DangKyXe dalDangKyXe = new DAL_DangKyXe();

        public DataTable getDangKyXe()
        {
            return dalDangKyXe.getDangKyXe();
        }

        public bool themDangKyXe(DTO_DangKyXe dk)
        {
            return dalDangKyXe.themDangKyXe(dk);
        }

        public bool suaDangKyXe(DTO_DangKyXe dk)
        {
            return dalDangKyXe.suaDangKyXe(dk);
        }

        public bool xoaDangKyXe(int DKX_ID)
        {
            return dalDangKyXe.xoaThanhVien(DKX_ID);
        }
    }
}
