using System.Web.Mvc;
using System.Web.Routing;
namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
        }
    }
    public interface IHandler {
        void HandleRequest();
    }
    public class FrontController {
        private Dictionary<string, IController> _controllers = new Dictionary<string, IController>();
        public FrontController() {
            _controllers.Add("home", new HomeController());
            _controllers.Add("about", new AboutController());
        }
        public void DispatchRequest(string request) {
            // Get the appropriate controller based on the request
            IController controller = GetController(request);
            // Call the appropriate method on the controller
            controller.HandleRequest(request);
        }
        private IController GetController(string request) {
            if (!_controllers.ContainsKey(request)) {
                throw new Exception("Controller not found.");
            }
            return _controllers[request];
        }
    }
    public class HomeHandler : IHandler {
        public void HandleRequest() {
            Console.WriteLine("Displaying home page.");
        }
    }
    public class AboutHandler : IHandler {
        public void HandleRequest() {
            Console.WriteLine("Displaying about page.");
        }
    }
}
