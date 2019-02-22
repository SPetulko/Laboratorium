using System.Web;
using System.Web.Mvc;
using Calculator.Models;
    public interface IStateManager<T>
    {
        void save(string name, T state);
        T load(string name);
    }
    public class SessionStateManager<T> : IStateManager<T>
    {
        public void save(string name, T state)
        {
            HttpContext.Current.Session[name] = state;
        }
        public T load(string name)
        {
            return (T)HttpContext.Current.Session[name];
        }
    }
    namespace Calculator.Controllers
    {
        public class CalculatorController : Controller
        {
            protected IStateManager<CalculatorModel> stateManager = new SessionStateManager<CalculatorModel>();
            public void setStateManager(IStateManager<CalculatorModel> manager)
            {
                stateManager = manager;
            }

            public ActionResult Index()
            {
                CalculatorModel calculator = new CalculatorModel();
                stateManager.save("model", calculator);
                return View(calculator);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Index(string param, string operation)
            {
                CalculatorModel calculator = stateManager.load("model");

                if (param != null)
                    calculator.Process(param);
                else if (operation != null)
                    calculator.ProcessOperation(operation);
                stateManager.save("model", calculator);
                return View("Index", calculator);
            }
        }
    }