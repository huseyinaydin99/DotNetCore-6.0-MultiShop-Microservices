﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Dto.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Models;
using MultiShop.WebUI.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Text.Json;

namespace MultiShop.WebUI.Controllers;

public class LoginController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    
    public LoginController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(SignInDto signInDto)
    {
        
        return RedirectToAction("Index", "User");
    }
}