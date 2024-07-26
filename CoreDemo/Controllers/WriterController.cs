﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	[Authorize]//erişim kısıtlayıcı
	public class WriterController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
		public IActionResult WriterMail()
		{
			return View();
		}
	}
}