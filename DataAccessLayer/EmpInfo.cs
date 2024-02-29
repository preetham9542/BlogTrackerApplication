﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmpInfo
    {
        [Key]
        public string EmailId { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime DateOfJoining { get; set; }
        public int PassCode { get; set; }
    }

}
