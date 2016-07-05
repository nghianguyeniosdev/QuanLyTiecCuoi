﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_LapHoaDonThanhToan
    {
        private static List<string> mListTenChuRe = new List<string>();
        private static List<string> mListTenCoDau = new List<string>();
        private static List<string> mListMaKH = new List<string>();
        private static int mSoLuongBan;
        private static Int64 mDonGiaBan;
        private static DataTable mTableCacDichVu;
        private static Int64 mTongTienBan;
        private static Int64 mTongTienDichVu;
        private static Int64 mTongTienHoaDon;
        private static Int64 mTienDatCoc;
        private static Int64 mTienConLai;


        public static DataTable GetAllTiecCuoi()
        {
            return DAO.DAO_LapHoaDonThanhToan.GetAllTiecCuoi();
        }

        public static DTO.DTO_TiecCuoi GetTiecCuoi(String tenChuRe, String tenCoDau)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetTiecCuoi(tenChuRe, tenCoDau);
        }

        public static DataTable GetAllHoaDon()
        {
            return DAO.DAO_LapHoaDonThanhToan.GetAllHoaDon();
        }

        public static bool InsertHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            return DAO.DAO_LapHoaDonThanhToan.InsertHoaDon(hoaDon);
        }

        public static bool UpdateHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            return DAO.DAO_LapHoaDonThanhToan.UpdateHoaDon(hoaDon);
        }

        public static bool UpdateSoTienConLai(DTO.DTO_HoaDon hoaDon)
        {
            return DAO.DAO_LapHoaDonThanhToan.UpdateSoTienConLai(hoaDon);
        }

        public static DTO.DTO_PhieuDatBan GetPhieuDatBan(int maTiecCuoi)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetPhieuDatBan(maTiecCuoi);
        }

        public static DataTable GetChiTietDichVu(int maTiecCuoi)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetChiTietDichVu(maTiecCuoi);
        }

        public static DataTable GetChiTietDatBan(int maPhieuDatBan)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetChiTietDatBan(maPhieuDatBan);
        }

        static BUS_LapHoaDonThanhToan()
        {
            DataTable dt = DAO_LapHoaDonThanhToan.GetTableTenChuReAndTenCoDau();
            foreach (DataRow dr in dt.Rows)
            {
                mListMaKH.Add(dr["MaKH"].ToString());
                mListTenChuRe.Add(dr["TenChuRe"].ToString());
                mListTenCoDau.Add(dr["TenCoDau"].ToString());
            }
        }
        public static List<string> GetListTenChuRe()
        {
            return mListTenChuRe;
        }
        public static List<string> GetListTenCoDau()
        {
            return mListTenCoDau;
        }
        public static List<string> GetListNgayDatTiec(string tenChuRe)
        {
            List<string> listNgayDatTiec = new List<string>();
            DataTable dt = DAO_LapHoaDonThanhToan.GetNgayDatTiec(tenChuRe);
            foreach (DataRow dr in dt.Rows)
                listNgayDatTiec.Add(dr["Ngay"].ToString() + "/" + dr["Thang"].ToString() + "/" + dr["Nam"].ToString());
            return listNgayDatTiec;
        }
        public static string GetSoLuongBan()
        {
            return mSoLuongBan.ToString();
        }
        public static Int64 GetDonGiaBan()
        {
            return mDonGiaBan;
        }
        public static Int64 GetTongTienBan()
        {
            return mTongTienBan;
        }
        public static DataTable GetCacDichVu()
        {
            return mTableCacDichVu;
        }
        public static Int64 GetTongTienDichVu()
        {
            return mTongTienDichVu;
        }
        public static Int64 GetTongTienHoaDon()
        {
            return mTongTienHoaDon;
        }
        public static Int64 GetTienDatCoc()
        {
            return mTienDatCoc;
        }
        public static Int64 GetTienConLai()
        {
            return mTienConLai;
        }
        public static void GetHoaDon(string tenChuRe, string ngayDatTiec)
        {
            ngayDatTiec = ConvertNgayDatTiec(ngayDatTiec);
            // MaSanh,SoLuongBan,MaiHD,TienCoc
            DataTable dt = DAO_LapHoaDonThanhToan.GetTableHDTCCustom(mListMaKH[mListTenChuRe.IndexOf(tenChuRe)], ngayDatTiec);

            mSoLuongBan = int.Parse(dt.Rows[0]["SoLuongBan"].ToString());

            string maSanh = dt.Rows[0]["MaSanh"].ToString();
            mDonGiaBan = Int64.Parse(DAO_LapHoaDonThanhToan.GetDonGiaBanTT(maSanh));

            mTongTienBan = mSoLuongBan * mDonGiaBan;

            string maHD = dt.Rows[0]["MaHD"].ToString();
            mTableCacDichVu = DAO_LapHoaDonThanhToan.GetCacDichVu(maHD);

            mTongTienDichVu = 0;
            foreach (DataRow dr in mTableCacDichVu.Rows)
            {
                mTongTienDichVu += Int64.Parse(dr["ThanhTien"].ToString());
            }

            mTongTienHoaDon = mTongTienBan + mTongTienDichVu;

            mTienDatCoc = Int64.Parse(dt.Rows[0]["TienCoc"].ToString());

            mTienConLai = mTongTienHoaDon - mTienDatCoc;
        }

        private static string ConvertNgayDatTiec(string ngayDatTiec)
        {
            List<string> list = ngayDatTiec.Split('/').ToList();
            return list[2] + '/' + list[1] + '/' + list[0];
        }
    }
}
