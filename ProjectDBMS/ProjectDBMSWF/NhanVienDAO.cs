﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectDBMSWF
{
    public class NhanVienDAO
    {
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            string connectionString = DataConnector.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { connection.Close(); }
            return dataTable;
        }
        //load danh sách linh kiện
        public static DataTable listProduct()
        {
            string query = "Select * From LinhKienView";
            return ExecuteQuery(query);
        }

        //tìm linh kiện theo tên
        public static DataTable getProductByName(string tenLK)
        {
            string query = string.Format("Select * From fn_timTenLK('{0}'", tenLK);
            return ExecuteQuery(query);
        }

        //tìm linh kiện theo bộ lọc
        public static DataTable getProductByFilter(string tenNhom, string gia, string trangThai)
        {
            DataTable dataTable = new DataTable();
            //tạo câu truy vấn lọc dữ liệu
            string query = "Select * From LinhKienView Where 1=1";
            if (!string.IsNullOrEmpty(tenNhom))
            {
                query += "AND TenNhom = @TenNhom";
            }

            if (!string.IsNullOrEmpty(trangThai))
            {
                query += " AND TrangThai = @TrangThai";
            }

            if (!string.IsNullOrEmpty(gia))
            {
                query += " AND GiaTien <= @Gia";
            }
            string connectionString = DataConnector.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Thêm các tham số nếu có
                if (!string.IsNullOrEmpty(tenNhom))
                {
                    command.Parameters.AddWithValue("@TenNhom", tenNhom);
                }

                if (!string.IsNullOrEmpty(trangThai))
                {
                    command.Parameters.AddWithValue("@TrangThai", trangThai);
                }
                if (!string.IsNullOrEmpty(gia))
                {
                    command.Parameters.AddWithValue("@Gia", Convert.ToDouble(gia));
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataTable;
        }

        //Lưu thông tin khách hàng
        public static void saveInfoKH(string hoTen, string SDT, string email, string diaChi)
        {
            string query = String.Format("EXEC sp_InsertKhachHang '{0}', '{1}', '{2}', '{3}'", hoTen, SDT, email, diaChi);
            string connectionString = DataConnector.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        public static void xuatHoaDon(DateTime dateXuat, float tongGiaTri, string maKH, string maNV)
        {
            string query = String.Format("EXEC sp_insertHoaDon '{0}', '{1}', '{2}', '{3}'", DateTime.Now, tongGiaTri, maKH, maNV);
            string connectionString = DataConnector.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        //load danh sách hóa đơn 
        public static DataTable getDanhSachHD(string maNV)
        {
            string query = String.Format("Select * From fn_GetHoaDonByMaNV('{0}')", maNV);
            return ExecuteQuery(query);
        }

        //load danh sách khách hàng theo ten
        public static DataTable getDanhSachHDByName(string maNV, string tenKH)
        {
            string query = String.Format("Select * From fn_GetHoaDonByMaNV('{0}') Where HoTen = '{1}'", maNV, tenKH);
            return ExecuteQuery(query);
        }
        // load danh sách hd theo giá trị 
        public static DataTable getDanhSachHDByValue(float giaTriMin, float giaTriMax, string maNV)
        {
            string query = String.Format("Select * From fn_timTheoGiaTri('{0}', '{1}', '{2}')", giaTriMin, giaTriMax, maNV);
            return ExecuteQuery(query);
        }

        public static DataTable getDanhSachHDByDate(DateTime date, string maNV)
        {
            string query = String.Format("Select * From fn_timTheoNgayXuat('{0}', '{1}')", date, maNV);
            return ExecuteQuery(query);
        }
        public static DataTable loadDanhSachCaLam(string maNV)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DataConnector.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetCaLamViecByNhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", maNV);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               
                    adapter.Fill(data);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
        public static DataTable getDoanhThuTheoCa(string maCa, string maNV)
        {
            DataTable data = new DataTable();
            string query = @"
        SELECT 
            MaCa, Ngay, SoLuongLinhKien, SoLuongDonHang, TongDoanhThu
        FROM dbo.fn_GetDoanhThuByMaCaVaNhanVien(@MaCa, @MaNhanVien)";

            using (SqlConnection conn = new SqlConnection(DataConnector.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNV);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            
                adapter.Fill(data);
               
            }
            return data;
        }
        public static DataTable getDoanhThuTheoCa(string maNV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DataConnector.connectionString))
            {
                string query = "SELECT * FROM fn_GetDoanhThuTheoNgay(@MaNhanVien, @NgayBatDau, @NgayKetThuc)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@MaNhanVien", maNV);
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public static DataTable getChiTietHD(string maHD)
        {
            string query = String.Format("Select * From ChiTietHD Where MaHD = '{0}'", maHD);
            return ExecuteQuery(query);
        }
        public static DataTable GetCaLamViec(string maNV)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DataConnector.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetCaLamViec", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
        public static void chamCong(string maNV, string MaCa)
        {
            using (SqlConnection conn=new SqlConnection(DataConnector.connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ChamCong", conn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@MaCa", MaCa);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); // Thực thi stored procedure
                    MessageBox.Show("Chấm công thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }
    }
}
