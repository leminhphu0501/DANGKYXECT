using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_DangKyXeCT;

namespace DAL_DangKyXeCT
{
    public class DAL_DangKyXe : DBConnect
    {
        public DataTable getDangKyXe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DANGKYXECT", _conn);
            DataTable dtDangKyXe = new DataTable();
            da.Fill(dtDangKyXe);
            return dtDangKyXe;
        }

        public bool themDangKyXe(DTO_DangKyXe dk)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO DANGKYXE(DKX_Nguoichuanbi, DKX_Ngaybatdau, DKX_Ngaybatdau, DKX_Ngayketthuc, DKX_Noidi, DKX_Noiden," +
                    "DKX_Thanhphan, DKX_Sokm, DKX_Soghedukien, DKX_Noidung, DKX_Donvichutri, DKX_Ghichu) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                    dk.DKXCONGTAC_Nguoichuanbi, dk.DKXCONGTAC_Ngaybatdau, dk.DKXCONGTAC_Ngayketthuc, dk.DKXCONGTAC_Noidi, dk.DKXCONGTAC_Noiden,
                    dk.DKXCONGTAC_Thanhphan, dk.DKXCONGTAC_Sokm, dk.DKXCONGTAC_Soghedukien, dk.DKXCONGTAC_Noidung, dk.DKXCONGTAC_Donvichutri, dk.DKXCONGTAC_Ghichu);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool suaDangKyXe(DTO_DangKyXe dk)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE DANGKYXE SET DKX_Nguoichuanbi = '{0}', DKX_Ngaybatdau = '{1}', DKX_Ngayketthuc = '{2}', DKX_Noidi = {3}, DKX_Noiden = {4}, " +
                    "DKX_Thanhphan = {5}, DKX_Sokm = {6}, DKX_Soghedukien = {7}, DKX_Noidung = {8}, DKX_Donvichutri = {9}, DKX_Ghichu = {10} WHERE DKX_ID = {11} ",
                    dk.DKXCONGTAC_Nguoichuanbi, dk.DKXCONGTAC_Ngaybatdau, dk.DKXCONGTAC_Ngayketthuc, dk.DKXCONGTAC_Noidi, dk.DKXCONGTAC_Noiden,
                    dk.DKXCONGTAC_Thanhphan, dk.DKXCONGTAC_Sokm, dk.DKXCONGTAC_Soghedukien, dk.DKXCONGTAC_Noidung, dk.DKXCONGTAC_Donvichutri, dk.DKXCONGTAC_Ghichu);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool xoaThanhVien(int DKX_ID)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM DKXCONGTAC WHERE DKX_ID = {0})", DKX_ID);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }


    }

}
