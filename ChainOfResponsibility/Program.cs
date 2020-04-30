using System;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var authHandler = new AuthHandler();
            var blockHandler = new BlockHandler();
            var roleAdminHandler = new RoleAdminHandler();

            authHandler.SetNext(blockHandler).SetNext(roleAdminHandler);

            var userRequest = new UserRequest
            {
                IsAuth = true,
                IsBlocked = false,
                IsAdmin = false
            };
            var result = authHandler.Check(userRequest);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
