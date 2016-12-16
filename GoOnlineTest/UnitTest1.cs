using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoOnline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace GoOnlineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HomeIndex()
        {
            GoOnline.Controllers.HomeController obj = new GoOnline.Controllers.HomeController();
            ViewResult result= obj.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void HomeAbout()
        {
            GoOnline.Controllers.HomeController obj = new GoOnline.Controllers.HomeController();
            ViewResult result = obj.About() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void HomeContact()
        {
            GoOnline.Controllers.HomeController obj = new GoOnline.Controllers.HomeController();
            ViewResult result = obj.Contact() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void AccountLogin()
        {
            GoOnline.Controllers.AccountController obj = new GoOnline.Controllers.AccountController();
            ViewResult result = obj.Login("http://localhost:61244/Account/Login123") as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void AccountRegister()
        {
            GoOnline.Controllers.AccountController obj = new GoOnline.Controllers.AccountController();
            ViewResult result = obj.Register() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AccountForgotPassword()
        {
            GoOnline.Controllers.AccountController obj = new GoOnline.Controllers.AccountController();
            ViewResult result = obj.ForgotPassword() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void AccountForgotPasswordConfirmation()
        {
            GoOnline.Controllers.AccountController obj = new GoOnline.Controllers.AccountController();
            ViewResult result = obj.ForgotPasswordConfirmation() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void AccountResetPassword()
        {
            GoOnline.Controllers.AccountController obj = new GoOnline.Controllers.AccountController();
            ViewResult result = obj.ResetPassword("Deepak") as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void AccountResetPasswordConfirmation()
        {
            GoOnline.Controllers.AccountController obj = new GoOnline.Controllers.AccountController();
            ViewResult result = obj.ResetPasswordConfirmation() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void HomeDummy()
        {
            GoOnline.Controllers.HomeController obj = new GoOnline.Controllers.HomeController();
            ViewResult result = obj.Dummy() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
