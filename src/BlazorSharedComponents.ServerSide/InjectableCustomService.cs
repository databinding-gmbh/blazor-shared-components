using BlazorSharedComponents.Lib;

namespace BlazorSharedComponents.ServerSide
{
    public class InjectableCustomService : IInjectableCustomService
    {
        public string GetInformation()
        {
            return "Hi! I'm Blazor Server-Side!";
        }
    }
}
