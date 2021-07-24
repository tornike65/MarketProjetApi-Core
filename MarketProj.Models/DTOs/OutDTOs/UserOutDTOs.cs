﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.DTOs.OutDTOs
{
    public class UserOutDTOs
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
