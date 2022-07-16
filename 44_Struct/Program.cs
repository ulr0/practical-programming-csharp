using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            CartItem cartItem = new CartItem
            {
                Name = "Hello World! Programming Book",
                Price = 10.99m,
                Quantity = 5
            };

            // CartItem은 구조체. 즉, 값형.
            // 함수 인자로 원본이 아닌 복사본 전달.
            ModifyCartItem(cartItem);

            // 원본 변화 없음.
            Console.WriteLine($"Name: {cartItem.Name}");
            Console.WriteLine($"Price: {cartItem.Price}");
            Console.WriteLine($"Quantity: {cartItem.Quantity}");
        }

        public static void ModifyCartItem(CartItem cartItem)
        {
            cartItem.Name = "Houw to suck at programming";
            cartItem.Price = 0.99m;
            cartItem.Quantity = 1;
        }
    }
}