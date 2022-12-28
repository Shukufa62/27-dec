using System;

namespace menutaskproject_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ayxan", "akjwhfjrgvf5S");
            string option;
            User[] userArr = new User[0];
            string name;
            string password;
            bool check = false;

            do
            {
                Console.WriteLine("1.User elave et");
                Console.WriteLine("2.Userlaere bax");
                Console.WriteLine("3.userlar uzre axtaris et");
                option = Console.ReadLine();
                if (option == "1")
                {
                    
                    
                       Console.WriteLine("adi daxil edin:");
                        name = Console.ReadLine();

                        Console.WriteLine("password daxil edin:");
                        password = Console.ReadLine();


                        User user2 = new User(name, password);
                        if (user2.Password == password && user2.Username == name)
                        {
                            check = true;
                        }

                        else if (option == "2")
                        {
                            for (int i = 0; i < userArr.Length; i++)
                                Console.WriteLine(userArr[i].ShowInfo());
                        }

                        else if (option == "3")
                        {
                            Console.WriteLine("axtaris deyerini daxil edin:");
                            String search = Console.ReadLine();
                            var filteredArr = SearchByName(userArr, search);
                            ShowUsersInfo(filteredArr);

                        }
                        Array.Resize(ref userArr, userArr.Length + 1);
                    userArr[userArr.Length - 1] = user1;

                }


            } while (option != "1" && option != "2" && option != "3");

            static User[] SearchByName(User[] userArr, string search)
            {
                User[] newArr = new User[0];

                for (int i = 0; i < userArr.Length; i++)
                {
                    if (userArr[i].Username.Contains(search))
                    {
                        Array.Resize(ref newArr, newArr.Length + 1);
                        newArr[newArr.Length - 1] = userArr[i];
                    }
                }

                return newArr;
            }
            static void ShowUsersInfo(User[] userArr)
            {
                for (int i = 0; i < userArr.Length; i++)
                {
                    Console.WriteLine(userArr[i].ShowInfo());
                }
            }

        }
    }
}

