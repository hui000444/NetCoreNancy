
using Nancy;

namespace BankAPI.Modules
{
    public class HelloWorldModule : NancyModule
    {
        public HelloWorldModule()
        {
            Get("/", args => "Hello World, it's Nancy on .NET Core");
            Get("/test/{name}", args => MyTestMethod(args.name));
        }
        private object MyTestMethod(string name)
        {
            return new Person() { Name = name };
        }
    }
    public class Person
    {
        public string Name { get; set; }
    }
}