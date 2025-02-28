﻿using System.ComponentModel.DataAnnotations;

namespace dotNet_FrontMVC.Models.Dto;

public class UserCreateDto
{
    [Required] //validation 
    [MaxLength(30)] //validation 
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public bool Disability { get; set; }
    public string Email { get; set; }
    public string Password  { get; set; }
    public string ImageUrl { get; set; } 
}