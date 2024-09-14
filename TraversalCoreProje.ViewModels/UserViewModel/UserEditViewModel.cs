﻿using Microsoft.AspNetCore.Http;

namespace TraversalCoreProje.ViewModels
{
    public class UserEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
