﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDatabase.Models
{
    class UserProgram
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProgramId { get; set; }
        public Program Program { get; set; }
    }
}
