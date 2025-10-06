﻿using System.ComponentModel.DataAnnotations;

namespace VanPhongPhamBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required] public string? FullName { get; set; }
        [Required][EmailAddress] public string? Email { get; set; }
        [Required] public string? Password { get; set; }
        public string? Phone { get; set; }
    }
}