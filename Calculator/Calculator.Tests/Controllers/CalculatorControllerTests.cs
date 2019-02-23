using System.Web.Mvc;
using Calculator.Controllers;
using System.Web;
using System.IO;
using System.Web.SessionState;
using System.Reflection;
using NUnit.Framework;


namespace Calculator.Tests.Controllers
{
    [TestFixture]
    public class CalculatorControllerTests
    {
        [SetUp]
        public void Setup()
        {
            var httpRequest = new HttpRequest("", "http://localhost/", "");
            var httpResponce = new HttpResponse(new StringWriter());
            var httpContext = new HttpContext(httpRequest, httpResponce);
            var sessionContainer =
                new HttpSessionStateContainer("id", new SessionStateItemCollection(),
                new HttpStaticObjectsCollection(),10,true, HttpCookieMode.AutoDetect,SessionStateMode.InProc,false);
            httpContext.Items["AspSession"] =
                 typeof(HttpSessionState).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance,null,CallingConventions.Standard,
                 new[] { typeof(HttpSessionStateContainer) },null).Invoke(new object[] { sessionContainer });
            HttpContext.Current = httpContext;
        }
        [Test]
        public void IndexGet()
        {
            CalculatorController controller = new CalculatorController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [Test]
        public void IndexPostParam()
        {
            CalculatorController controller = new CalculatorController();
            IndexGet();
            ViewResult result = controller.Index("param", "1") as ViewResult;
            Assert.IsNotNull(result);
        }

        [Test]
        public void IndexPostOperation()
        {
            CalculatorController controller = new CalculatorController();
            IndexGet();
            ViewResult result = controller.Index("operation", "=") as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
