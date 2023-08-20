﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql

{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("login")]
        public string Login { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("age")]
        public int Age { get; set; }
    }
}
