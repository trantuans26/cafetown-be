﻿using Cafetown.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetown.BL
{
    public interface IEmployeeBL : IBaseBL<Employee>
    {
        /// <summary>
        /// Kiểm tra mã trùng
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="employeeID"></param>
        /// <returns>bool kiểm tra có trùng hay không</returns>
        /// Modified by: TTTuan 5/1/2023
        public new ServiceResponse CheckDuplicateCode(Guid? employeeID, Employee employee);

        /// <summary>
        /// Xuất file excel danh sách nhân viên
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>File excel</returns>
        /// Modified by: TTTuan (5/1/2022)
        public MemoryStream ExportExcel(string? keyword);

        /// <summary>
        /// Validate dữ liệu đầu vào
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Đối tượng ServiceResponse mỗ tả thành công hay thất bại</returns>
        /// Created by: TTTuan (23/12/2022)
        public new ServiceResponse ValidateData(Employee employee);

        /// <summary>
        /// Chức năng đăng nhập
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// TTTuan: 17/4/2023
        public Employee login(string username, string password);

        /// <summary>
        /// Sửa một bản ghi
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="record"></param>
        /// <returns>ServiceResponse</returns>
        /// Modified by: TTTuan 5/1/2023
        public ServiceResponse UpdateRecordByLogin(Guid recordID, Employee record);

        public int UpdateByEmail(string email);
    }
}
