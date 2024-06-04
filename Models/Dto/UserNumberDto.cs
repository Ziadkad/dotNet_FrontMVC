﻿using System.ComponentModel.DataAnnotations;
namespace dotNet_FrontMVC.Models.Dto;

public class UserNumberDto
{
    [Required]
    public int UserNo { get; set; }
    [Required]
    public int UserId { get; set; }
    public string? Details { get; set; }
}