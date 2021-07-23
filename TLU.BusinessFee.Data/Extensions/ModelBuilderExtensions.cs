﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;
using System.Linq;

namespace TLU.BusinessFee.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "home titleee", Value = "this is home page" }
            );
            modelBuilder.Entity<PhongBan>().HasData(
                new PhongBan() { MaPhongBan = "KT", TenPhongBan = "Phong kinh te" },
                new PhongBan() { MaPhongBan = "IT", TenPhongBan = "Phong CNTT" },
                new PhongBan() { MaPhongBan = "DT", TenPhongBan = "Phong dao tao" },
                new PhongBan() { MaPhongBan = "TT", TenPhongBan = "Phong truyen thong" },
                new PhongBan() { MaPhongBan = "NN", TenPhongBan = "Phong ngon ngu" },
                new PhongBan() { MaPhongBan = "CT", TenPhongBan = "Phong ctsv" },
                new PhongBan() { MaPhongBan = "TV", TenPhongBan = "Phong tai vu" },
                new PhongBan() { MaPhongBan = "LD", TenPhongBan = "Lanh dao" }
                );
            modelBuilder.Entity<CapBac>().HasData(
                new CapBac() { MaCapBac = "C1", TenCapBac = "CAP1" },
                new CapBac() { MaCapBac = "C2", TenCapBac = "CAP2" },
                new CapBac() { MaCapBac = "C3", TenCapBac = "CAP3" },
                new CapBac() { MaCapBac = "C4", TenCapBac = "CAP4" },
                new CapBac() { MaCapBac = "C5", TenCapBac = "CAP5" },
                new CapBac() { MaCapBac = "C6", TenCapBac = "CAP6" }
                );
            modelBuilder.Entity<NhanVienPhongBan>().HasData(
                new NhanVienPhongBan() { MaNhanVien="admin",TenNhanVien="admin",MaCapBac="C1"},
                 //Phòng tai vu
                 new NhanVienPhongBan() { MaNhanVien = "TV001", TenNhanVien = "Ha Linh Giang", MaCapBac = "C1", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV002", TenNhanVien = "Bui Mai Ngoc", MaCapBac = "C2", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV003", TenNhanVien = "Pham Thi Thao", MaCapBac = "C3", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV004", TenNhanVien = "Pham Thuy Tien", MaCapBac = "C4", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV005", TenNhanVien = "Do Thi Huong", MaCapBac = "C5", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV006", TenNhanVien = "Do Thi Ha", MaCapBac = "C6", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV007", TenNhanVien = "Mai Thuy Nga", MaCapBac = "C3", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV008", TenNhanVien = "Vu Duc Thi", MaCapBac = "C1", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV009", TenNhanVien = "Cao Kim Anh", MaCapBac = "C2", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV010", TenNhanVien = "Pham Phuong Thanh", MaCapBac = "C4", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV011", TenNhanVien = "Nguyen Duc Dan", MaCapBac = "C5", MaPhongBan = "TV" },
                 new NhanVienPhongBan() { MaNhanVien = "TV012", TenNhanVien = "Tran Thi Hue", MaCapBac = "C6", MaPhongBan = "TV" },
                 //Lãnh Đạo
                 new NhanVienPhongBan() { MaNhanVien = "LD001", TenNhanVien = "Mai Hong Ngoc", MaCapBac = "C1", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD002", TenNhanVien = "Nguyen Trong Son", MaCapBac = "C2", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD003", TenNhanVien = "Pham Minh Hang", MaCapBac = "C3", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD004", TenNhanVien = "Nguyen Dinh Huynh", MaCapBac = "C4", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD005", TenNhanVien = "Phung Viet Hoang", MaCapBac = "C5", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD006", TenNhanVien = "Mai Quoc Dat", MaCapBac = "C6", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD007", TenNhanVien = "Nham Ngoc Tan", MaCapBac = "C3", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD008", TenNhanVien = "Ha Huy Khoai", MaCapBac = "C1", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD009", TenNhanVien = "Nguyen Hong Nhung", MaCapBac = "C4", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD010", TenNhanVien = "Hoang Ngoc Tung", MaCapBac = "C2", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD011", TenNhanVien = "Nguyen Lam Tung", MaCapBac = "C5", MaPhongBan = "LD" },
                 new NhanVienPhongBan() { MaNhanVien = "LD012", TenNhanVien = "Nguyen Quoc Tuan", MaCapBac = "C6", MaPhongBan = "LD" },
                 //Phòng Công Tác Sinh Viên
                 new NhanVienPhongBan() { MaNhanVien = "CT001", TenNhanVien = "Vu Hong Hoa", MaCapBac = "C1", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT002", TenNhanVien = "Tran Huy Hung", MaCapBac = "C2", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT003", TenNhanVien = "Nguyen Van Toan", MaCapBac = "C3", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT004", TenNhanVien = "Luong Xuan Truong", MaCapBac = "C4", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT005", TenNhanVien = "Nguyen Dang Khoa", MaCapBac = "C5", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT006", TenNhanVien = "Do Huyen Trang", MaCapBac = "C6", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT007", TenNhanVien = "Nguyen Thi Hoa", MaCapBac = "C1", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT008", TenNhanVien = "Tran Quoc Hung", MaCapBac = "C2", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT009", TenNhanVien = "Nguyen Canh Toan", MaCapBac = "C3", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT010", TenNhanVien = "Mai Tien Dung", MaCapBac = "C4", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT011", TenNhanVien = "Nguyen Duc Khoa", MaCapBac = "C5", MaPhongBan = "CT" },
                 new NhanVienPhongBan() { MaNhanVien = "CT012", TenNhanVien = "Le Huyen Trang", MaCapBac = "C6", MaPhongBan = "CT" },
                 //Phòng Ngôn Ngữ
                 new NhanVienPhongBan() { MaNhanVien = "NN001", TenNhanVien = "Nguyen Duc Quang", MaCapBac = "C1", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN002", TenNhanVien = "Tran Huyen Trang", MaCapBac = "C2", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN003", TenNhanVien = "Nguyen Kieu Trang", MaCapBac = "C5", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN004", TenNhanVien = "Nguyen Thuy Nga", MaCapBac = "C3", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN005", TenNhanVien = "Tran Hoang Duong", MaCapBac = "C4", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN006", TenNhanVien = "Nguyen Van Manh", MaCapBac = "C6", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN007", TenNhanVien = "Nguyen Ngoc Quang", MaCapBac = "C1", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN008", TenNhanVien = "Tran Huy Hoang", MaCapBac = "C2", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN009", TenNhanVien = "Vu Tuan Tu", MaCapBac = "C5", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN010", TenNhanVien = "Nguyen Thi Nga", MaCapBac = "C3", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN011", TenNhanVien = "Tran Thuy Duong", MaCapBac = "C4", MaPhongBan = "NN" },
                 new NhanVienPhongBan() { MaNhanVien = "NN012", TenNhanVien = "Nguyen Van Thieu", MaCapBac = "C6", MaPhongBan = "NN" },
                 //Phòng Truyền Thông
                 new NhanVienPhongBan() { MaNhanVien = "TT001", TenNhanVien = "Do Hai Yen", MaCapBac = "C2", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT002", TenNhanVien = "Nguyen Trong Thang", MaCapBac = "C3", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT003", TenNhanVien = "Nguyen Hoang Duong", MaCapBac = "C6", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT004", TenNhanVien = "Nguyen Van Tan", MaCapBac = "C1", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT005", TenNhanVien = "Mai Ha", MaCapBac = "C4", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT006", TenNhanVien = "Nguyen Bich Thao", MaCapBac = "C5", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT007", TenNhanVien = "Pham Hai Yen", MaCapBac = "C2", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT008", TenNhanVien = "Bui Sy Thang", MaCapBac = "C3", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT009", TenNhanVien = "Tran Hoang Duong", MaCapBac = "C6", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT010", TenNhanVien = "Mai Xuan The", MaCapBac = "C1", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT011", TenNhanVien = "Mai Lan", MaCapBac = "C4", MaPhongBan = "TT" },
                 new NhanVienPhongBan() { MaNhanVien = "TT012", TenNhanVien = "Nguyen Bich Tram", MaCapBac = "C5", MaPhongBan = "TT" },
                 //Phòng Đào Tạo
                 new NhanVienPhongBan() { MaNhanVien = "DT001", TenNhanVien = "Le Thu Trang", MaCapBac = "C1", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT002", TenNhanVien = "Hoang Kim Khanh", MaCapBac = "C5", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT003", TenNhanVien = "Nguyen Thu Bich", MaCapBac = "C6", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT004", TenNhanVien = "Nguyen Kim Lien", MaCapBac = "C3", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT005", TenNhanVien = "Dang Thanh Tung", MaCapBac = "C4", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT006", TenNhanVien = "Le Thi Quy", MaCapBac = "C2", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT007", TenNhanVien = "Ho Xuan Ngoc", MaCapBac = "C1", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT008", TenNhanVien = "Hoang Ngoc Ha", MaCapBac = "C5", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT009", TenNhanVien = "Nguyen Van Lich", MaCapBac = "C6", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT010", TenNhanVien = "Nguyen Thi Hai", MaCapBac = "C3", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT011", TenNhanVien = "Dang canh Khanh", MaCapBac = "C4", MaPhongBan = "DT" },
                 new NhanVienPhongBan() { MaNhanVien = "DT012", TenNhanVien = "Nguyen Bao Ngoc", MaCapBac = "C2", MaPhongBan = "DT" },
                 //Phòng CNTT
                 new NhanVienPhongBan() { MaNhanVien = "IT001", TenNhanVien = "Le Thu Trang", MaCapBac = "C2", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT002", TenNhanVien = "Ho Thao Ngoc", MaCapBac = "C1", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT003", TenNhanVien = "Hoang Thuy Hang", MaCapBac = "C5", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT004", TenNhanVien = "Nguyen Quang Thang", MaCapBac = "C6", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT005", TenNhanVien = "Nguyen Trong Quang", MaCapBac = "C3", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT006", TenNhanVien = "Dang Van Khanh", MaCapBac = "C4", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT007", TenNhanVien = "Le Thu Minh", MaCapBac = "C2", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT008", TenNhanVien = "Ho Minh Ngoc", MaCapBac = "C1", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT009", TenNhanVien = "Hoang Thanh Tra", MaCapBac = "C5", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT010", TenNhanVien = "Nguyen Quang Huy", MaCapBac = "C6", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT011", TenNhanVien = "Nguyen Trong Hoang", MaCapBac = "C3", MaPhongBan = "IT" },
                 new NhanVienPhongBan() { MaNhanVien = "IT012", TenNhanVien = "Dang Van Trung", MaCapBac = "C4", MaPhongBan = "IT" },
                 //Phòng Kinh Tế
                 new NhanVienPhongBan() { MaNhanVien = "KT001", TenNhanVien = "Nguyen Van Truong", MaCapBac = "C2", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT002", TenNhanVien = "Pham Thu Hien", MaCapBac = "C1", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT003", TenNhanVien = "Hoang Thi Huong", MaCapBac = "C5", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT004", TenNhanVien = "Nguyen Hoang Anh", MaCapBac = "C6", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT005", TenNhanVien = "Nguyen Ngoc Anh", MaCapBac = "C3", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT006", TenNhanVien = "Dang Quynh Anh", MaCapBac = "C4", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT007", TenNhanVien = "Do Van Truong", MaCapBac = "C2", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT008", TenNhanVien = "Pham Thu Thuong", MaCapBac = "C1", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT009", TenNhanVien = "Hoang Lan Huong", MaCapBac = "C5", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT010", TenNhanVien = "Nguyen Anh Duong ", MaCapBac = "C6", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT011", TenNhanVien = "Tran Thuy Dung", MaCapBac = "C3", MaPhongBan = "KT" },
                 new NhanVienPhongBan() { MaNhanVien = "KT012", TenNhanVien = "Ngo Kien Huy", MaCapBac = "C4", MaPhongBan = "KT" }
                 );
            modelBuilder.Entity<ChiPhi>().HasData(
                new ChiPhi() { MaChiPhi = "CP1", TenChiPhi = "Khach San", MoTa = "Tien ở khách sạn" },
                new ChiPhi() { MaChiPhi = "CP2", TenChiPhi = "Ve may bay", MoTa = "Tien ở khách sạn" },
                new ChiPhi() { MaChiPhi = "CP3", TenChiPhi = "Luu tru", MoTa = "Tien ở khách sạn" },
                new ChiPhi() { MaChiPhi = "CP4", TenChiPhi = "Ve tau,xe", MoTa = "Tien ở khách sạn" }
                );
            modelBuilder.Entity<ChiPhiChucVu>().HasData(
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "C1", SoTienDinhMuc = "200000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "C2", SoTienDinhMuc = "250000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "C3", SoTienDinhMuc = "300000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "C4", SoTienDinhMuc = "350000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "C5", SoTienDinhMuc = "400000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP1", MaCapBac = "C6", SoTienDinhMuc = "500000", DonVi = "dem" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "C1", SoTienDinhMuc = "1500000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "C2", SoTienDinhMuc = "1700000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "C3", SoTienDinhMuc = "2000000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "C4", SoTienDinhMuc = "2300000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "C5", SoTienDinhMuc = "2600000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP2", MaCapBac = "C6", SoTienDinhMuc = "3000000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "C1", SoTienDinhMuc = "150000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "C2", SoTienDinhMuc = "200000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "C3", SoTienDinhMuc = "250000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "C4", SoTienDinhMuc = "300000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "C5", SoTienDinhMuc = "350000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP3", MaCapBac = "C6", SoTienDinhMuc = "400000", DonVi = "ngay" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "C1", SoTienDinhMuc = "100000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "C2", SoTienDinhMuc = "120000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "C3", SoTienDinhMuc = "150000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "C4", SoTienDinhMuc = "200000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "C5", SoTienDinhMuc = "250000", DonVi = "luot" },
                new ChiPhiChucVu() { MaChiPhi = "CP4", MaCapBac = "C6", SoTienDinhMuc = "300000", DonVi = "luot" }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = "RL01", Name = "admin", Description = "Quản trị hệ thống" },
                new Role { Id = "RL02", Name = "Nhân viên", Description = "nhân viên trong một phòng ban" },
                new Role { Id = "RL03", Name = "Trưởng bộ phận", Description = "trưởng bộ phận của một phòng ban" },
                new Role { Id = "RL04", Name = "Kế toán", Description = "nhân viên phòng tài vụ" },
                new Role { Id = "RL05", Name = "Lãnh đạo nhà trường", Description = "lãnh đạo nhà trường" }

            );

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User { MaNhanVien="admin", PasswordHash = hasher.HashPassword(null, "123") },
                ////Phòng CNTT
                new User { MaNhanVien = "IT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "IT012", PasswordHash = hasher.HashPassword(null, "123") },
                //PhongKinhte
                new User { MaNhanVien = "KT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "KT012", PasswordHash = hasher.HashPassword(null, "123") },
                //phong dao tao
                new User { MaNhanVien = "DT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "DT012", PasswordHash = hasher.HashPassword(null, "123") },
                 //phong truyen thong
                new User { MaNhanVien = "TT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TT012", PasswordHash = hasher.HashPassword(null, "123") },
                 //phongngon ngu
                new User { MaNhanVien = "NN001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "NN012", PasswordHash = hasher.HashPassword(null, "123") },
                //phong cong tac sinh vien

                new User { MaNhanVien = "CT001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "CT012", PasswordHash = hasher.HashPassword(null, "123") },
                //lanh dao
                new User { MaNhanVien = "LD001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "LD012", PasswordHash = hasher.HashPassword(null, "123") },
                // phong tai vu
                new User { MaNhanVien = "TV001", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV002", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV003", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV004", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV005", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV006", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV007", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV008", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV009", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV010", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV011", PasswordHash = hasher.HashPassword(null, "123") },
                new User { MaNhanVien = "TV012", PasswordHash = hasher.HashPassword(null, "123") }
               );


            modelBuilder.Entity<UserRole>().HasData(
                new UserRole() { RoleId="RL01",MaNhanVien="admin"},
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT001" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT002" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT003" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT004" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT005" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT006" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT007" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT008" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT009" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT011" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "IT012" },
                
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT001" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT002" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT003" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT004" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT005" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT006" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT007" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT008" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT009" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT011" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "CT012" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT001" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT002" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT003" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT004" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT005" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT006" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT007" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT008" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT009" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT011" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TT012" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN001" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN002" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN003" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN004" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN005" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN006" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN007" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN008" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN009" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN011" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "NN012" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT001" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT002" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT003" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT004" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT005" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT006" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT007" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT008" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT009" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT011" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "DT012" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT001" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT002" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT003" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT004" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT005" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT006" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT007" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT008" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT009" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT011" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "KT012" },

                new UserRole() { RoleId = "RL03", MaNhanVien = "TT010" },
                new UserRole() { RoleId = "RL03", MaNhanVien = "IT010" },
                new UserRole() { RoleId = "RL03", MaNhanVien = "NN010" },
                new UserRole() { RoleId = "RL03", MaNhanVien = "CT010" },
                new UserRole() { RoleId = "RL03", MaNhanVien = "DT010" },
                new UserRole() { RoleId="RL03",MaNhanVien="KT010"},

                new UserRole() { RoleId = "RL04", MaNhanVien = "TV001" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV002" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV003" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV004" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV005" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV006" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV007" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV008" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV009" },
                new UserRole() { RoleId = "RL02", MaNhanVien = "TV011" },
                new UserRole() { RoleId = "RL04", MaNhanVien = "TV012" },
                //
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD001" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD002" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD003" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD004" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD005" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD006" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD007" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD008" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD009" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD011" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD012" },
                new UserRole() { RoleId = "RL05", MaNhanVien = "LD010" }
                );
        
        }
    }
}