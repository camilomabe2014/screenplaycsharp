﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ScreenPlay.Test
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string Url = "https://camilomabe2014.github.io/camilomabe/";
        protected string PathChrome = @"D:\ProyectosAuto\Apk\ScreenPlay\screenplay-pattern-master\ScreenPlay\Driver";
        //D:\ProyectosAuto\Apk\ScreenPlay\screenplay-pattern-master\ScreenPlay\Driver

        [SetUp]
        public void SetUpBase()
        {
            driver = new ChromeDriver(PathChrome);
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [TearDown]
        public void TearDownBase()
        {
            if (driver != null) { }
            driver.Quit();
        }
    }
}




