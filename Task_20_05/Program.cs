namespace Task_20_05
{
    enum AccessLevel
    {
        Guest,
        User,
        Moderator,
        Admin
    }

    class Program
    {
        static void Main()
        {

            AccessLevel userAccess = AccessLevel.Moderator;


            CheckPermission(userAccess, "delete post");
        }

        static void CheckPermission(AccessLevel accessLevel, string action)
        {
            if (action == "delete post")
            {
                if (accessLevel == AccessLevel.Moderator || accessLevel == AccessLevel.Admin)
                {
                    Console.WriteLine("Действие выполнено: Пост успешно удален.");
                }
                else
                {
                    Console.WriteLine("Ошибка: Недостаточно прав для удаления поста!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Неизвестное действие!");
            }
        }
    }
}
                
            
        

 
