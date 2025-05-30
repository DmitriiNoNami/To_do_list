﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class CompletedTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public string? Tags { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime CompletedAt { get; set; } = DateTime.UtcNow;
    }
}