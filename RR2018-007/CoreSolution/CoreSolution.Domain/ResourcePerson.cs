﻿using CoreSolution.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using static CoreSolution.Domain.Enum.EnumCode;

namespace CoreSolution.Domain
{
    /// <summary>
    /// 人力资源信息
    /// </summary>
    public class ResourcePerson : EntityBaseFull
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string Card { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Sex Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 居住街道
        /// </summary>
        public Guid Street { get; set; }
        /// <summary>
        /// 所属驿站
        /// </summary>
        public Guid Station { get; set; }
        /// <summary>
        /// 居住居委
        /// </summary>
        public Guid JuWei { get; set; }
        /// <summary>
        /// 居住地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 人员类型
        /// </summary>
        public Guid PerType { get; set; }
        /// <summary>
        /// 学历 文化程度
        /// </summary>
        public Guid Degree { get; set; }
        /// <summary>
        /// 特长
        /// </summary>
        public string Strength { get; set; }
    }
}
