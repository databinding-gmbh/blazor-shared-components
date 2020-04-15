using BlazorSharedComponents.Lib;

namespace BlazorSharedComponents.ClientSide
{
    public class InjectableCustomService : IInjectableCustomService
    {
        public string GetInformation()
        {
            return "Hi! I'm Blazor Client-Side!";
        }
    }
}
