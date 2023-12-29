using Microsoft.EntityFrameworkCore;




// Код с практической за субботу, дз чуть ниже
//using (Context db = new Context())
//{
//    db.Database.EnsureDeleted();
//    db.Database.EnsureCreated();

//    Customers c1 = new Customers
//    {
//        Full_name = "John Doe",
//        Date_of_birth = "1990-05-15",
//        Gender = "Male",
//        Email = "john.doe@example.com",
//        Country = "USA",
//        City = "New York"
//    };

//    Customers c2 = new Customers
//    {
//        Full_name = "Alice Smith",
//        Date_of_birth = "1985-08-22",
//        Gender = "Female",
//        Email = "alice.smith@example.com",B
//        Country = "Canada",
//        City = "Toronto"
//    };

//    Customers c3 = new Customers
//    {
//        Full_name = "Bob Johnson",
//        Date_of_birth = "1978-03-10",
//        Gender = "Male",
//        Email = "bob.johnson@example.com",
//        Country = "USA",
//        City = "New York"
//    };

//    Customers c4 = new Customers
//    {
//        Full_name = "Eva Martinez",
//        Date_of_birth = "1995-11-28",
//        Gender = "Female",
//        Email = "eva.martinez@example.com",
//        Country = "USA",
//        City = "New York"
//    };

//    Customers c5 = new Customers
//    {
//        Full_name = "Daniel Kim",
//        Date_of_birth = "1982-07-03",
//        Gender = "Male",
//        Email = "daniel.kim@example.com",
//        Country = "South Korea",
//        City = "Seoul"
//    };

//    Interests i1 = new Interests
//    {
//        Customer_Id = 1,
//        Section = "Smartphones and Gadgets"
//    };

//    Interests i2 = new Interests
//    {
//        Customer_Id = 2,
//        Section = "Audio and Headphones"
//    };

//    Interests i3 = new Interests
//    {
//        Customer_Id = 3,
//        Section = "Computers and Laptops"
//    };

//    Interests i4 = new Interests
//    {
//        Customer_Id = 4,
//        Section = "Smartphones and Gadgets"
//    };

//    Interests i5 = new Interests
//    {
//        Customer_Id = 4,
//        Section = "Smartphones and Gadgets"
//    };

//    Promotions p1 = new Promotions
//    {
//        Country = "USA",
//        City = "New York",
//        Section = "Smartphones and Gadgets",
//        Product = "Samsung Galaxy S21",
//        Start_time = "2023-01-01 10:00 AM",
//        End_time = "2023-01-01 06:00 PM"
//    };

//    Promotions p2 = new Promotions
//    {
//        Country = "UK",
//        City = "London",
//        Section = "Audio and Headphones",
//        Product = "Sony WH-1000XM4 Headphones",
//        Start_time = "2023-02-15 12:00 PM",
//        End_time = "2023-02-15 08:00 PM"
//    };

//    Promotions p3 = new Promotions
//    {
//        Country = "Germany",
//        City = "Berlin",
//        Section = "Computers and Laptops",
//        Product = "Dell XPS 13 Laptop",
//        Start_time = "2023-03-20 09:00 AM",
//        End_time = "2023-03-20 05:00 PM"
//    };

//    Promotions p4 = new Promotions
//    {
//        Country = "USA",
//        City = "New York",
//        Section = "Smartphones and Gadgets",
//        Product = "Apple iPad Pro",
//        Start_time = "2023-04-10 11:00 AM",
//        End_time = "2023-04-10 07:00 PM"
//    };

//    Promotions p5 = new Promotions
//    {
//        Country = "Japan",
//        City = "Tokyo",
//        Section = "Audio and Headphones",
//        Product = "Bose SoundLink Revolve+ Speaker",
//        Start_time = "2023-05-05 01:00 PM",
//        End_time = "2023-05-05 09:00 PM"
//    };

//    db.Customers.AddRange(c1, c2, c3, c4, c5);
//    db.Interests.AddRange(i1, i2, i3, i4, i5);
//    db.Promotions.AddRange(p1, p2, p3, p4, p5);
//    db.SaveChanges();
//}

//using (Context db = new Context())
//{
//    Console.WriteLine("Все покупатели:");
//    var all_customers = db.Customers.FromSqlRaw("SELECT * FROM Customers").ToList();
//    foreach (var ac in all_customers)
//        Console.WriteLine(ac.Full_name);

//    Console.WriteLine("-----------------------------------------------------------------");
//    Console.WriteLine("Все почты:");
//    var all_emails = db.Customers.FromSqlRaw("SELECT * FROM Customers").ToList();
//    foreach (var ae in all_emails)
//        Console.WriteLine(ae.Email);

//    Console.WriteLine("-----------------------------------------------------------------");
//}

//using (Context db = new Context())
//{
//    Console.WriteLine("Все категории:");
//    var section_list = db.Interests.FromSqlRaw("SELECT DISTINCT Section FROM Interests").Select(x => new { Section = x.Section }).ToList();
//    foreach (var sl in section_list)
//        Console.WriteLine(sl.Section);

//    Console.WriteLine("-----------------------------------------------------------------");
//    Console.WriteLine("Все акционные товары:");

//    var promotion_goods = db.Promotions.FromSqlRaw("SELECT * FROM Promotions").ToList();
//    foreach (var pg in promotion_goods)
//        Console.WriteLine(pg.Product);

//    Console.WriteLine("-----------------------------------------------------------------");
//    Console.WriteLine("Список всех городов:");

//    var all_city = db.Customers.FromSqlRaw("SELECT DISTINCT City FROM Customers").Select(x => new { City = x.City }).ToList();
//    foreach (var ac in all_city)
//        Console.WriteLine(ac.City);

//    Console.WriteLine("-----------------------------------------------------------------");
//    Console.WriteLine("Список всех стран:");

//    var all_country = db.Customers.FromSqlRaw("SELECT DISTINCT Country FROM Customers").Select(x => new { Country = x.Country }).ToList();
//    foreach (var ac in all_country)
//        Console.WriteLine(ac.Country);

//    Console.WriteLine("-----------------------------------------------------------------");
//}

//using (Context db = new Context())
//{
//    Console.WriteLine("Все покупатели из Нью-Йорка:");
//    SqliteParameter parameter = new SqliteParameter("@City", "%New York%");
//    var all_customers_from_ny = db.Customers.FromSqlRaw("SELECT * FROM Customers WHERE City LIKE @City", parameter).ToList();
//    foreach (var acfny in all_customers_from_ny)
//        Console.WriteLine(acfny.Full_name);

//    Console.WriteLine("-----------------------------------------------------------------");
//    Console.WriteLine("Все покупатели из США:");

//    SqliteParameter parameter1 = new SqliteParameter("@Country", "%USA%");
//    var all_customers_from_usa = db.Customers.FromSqlRaw("SELECT * FROM Customers WHERE Country LIKE @Country", parameter1).ToList();
//    foreach (var acfusa in all_customers_from_usa)
//        Console.WriteLine(acfusa.Full_name);

//    Console.WriteLine("-----------------------------------------------------------------");
//    Console.WriteLine("Все акции в США:");

//    var promotions_from_usa = db.Promotions.FromSqlRaw("SELECT * FROM Promotions WHERE Country = 'USA'").ToList();
//    foreach (var pfusa in promotions_from_usa)
//        Console.WriteLine($"{pfusa.Id}|{pfusa.Country}|{pfusa.City}|{pfusa.Section}|{pfusa.Product}|{pfusa.Start_time} - {pfusa.End_time}");

//}



while (true)
{
    try
    {
        Console.WriteLine();
        Console.WriteLine("1 - Отобразить");
        Console.WriteLine("2 - Найти");
        Console.WriteLine("3 - Добавить");
        Console.WriteLine("4 - Изменить");
        Console.WriteLine("5 - Удалить");
        Console.WriteLine("6 - Выход");
        Console.WriteLine();
        Console.Write("Введите номер опции и нажмите Enter: ");
        int key_one = Convert.ToInt32(Console.ReadLine());

        if (key_one == 1)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1 - Отобразить таблицу 'Покупатели'");
                    Console.WriteLine("2 - Отобразить таблицу 'Интересы'");
                    Console.WriteLine("3 - Отобразить таблицу 'Акционные товары'");
                    Console.WriteLine("4 - Отобразить количество покупателей в каждом городе");
                    Console.WriteLine("5 - Отобразить количество покупателей в каждой стране");
                    Console.WriteLine("6 - Отобразить количество городов в каждой стране");
                    Console.WriteLine("7 - Отобразить среднее количество городов в каждой стране");
                    Console.WriteLine("8 - Отобразить все разделы, в которых заинтересован конкретный покупатель");
                    Console.WriteLine("9 - Отобразить все акционноые товары конкретного раздела за конкретный промежуток времени");
                    Console.WriteLine("10 - Отобразить акционные товары конкретного покупателя");
                    Console.WriteLine("11 - Отобразить топ 3 страны за количеством покупателей");
                    Console.WriteLine("12 - Отобразить страну с наибольшим количеством покупателей");
                    Console.WriteLine("13 - Отобразить топ 3 города за количеством покупателей");
                    Console.WriteLine("14 - Отобразить город с наибольшим количеством покупателей");
                    Console.WriteLine("15 - Вернуться в основное меню");
                    Console.WriteLine();
                    Console.Write("Введите номер опции и нажмите Enter: ");
                    int key_two = Convert.ToInt32(Console.ReadLine());

                    if (key_two == 1)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var all_customers = db.Customers.FromSqlRaw("SELECT * FROM Customers");
                                Console.WriteLine("|ID| Имя фамилия | Дата рождения | Пол |Электронная почта| Страна | Город |");
                                foreach (var ac in all_customers)
                                    Console.WriteLine($"| {ac.Id} | {ac.Full_name} | {ac.Date_of_birth} | {ac.Gender} | {ac.Email} | {ac.Country} | {ac.City} |");
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 2)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var all_interests = db.Interests.FromSqlRaw("SELECT * FROM Interests");
                                Console.WriteLine("|ID| ID покупателя | Категория |");
                                foreach (var ai in all_interests)
                                    Console.WriteLine($"| {ai.Id} | {ai.Customer_Id} | {ai.Section} |");
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 3)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var all_promotions = db.Promotions.FromSqlRaw("SELECT * FROM Promotions");
                                Console.WriteLine("|ID| Страна | Город | Категория | Товар | Дата начала акции | Дата окончания акции |");
                                foreach (var ap in all_promotions)
                                    Console.WriteLine($"| {ap.Id} | {ap.Country} | {ap.City} | {ap.Section} | {ap.Product} | {ap.Start_time} | {ap.End_time} |");
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 4)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var list = db.Customers.GroupBy(c => c.City).ToList();
                                var count = list.Select(g => new { City = g.Key, Count = g.Count() });

                                Console.WriteLine("| Город | Количество покупателей ");
                                foreach (var item in count)
                                {
                                    Console.WriteLine($"| {item.City} | {item.Count} |");
                                }
                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 5)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var list = db.Customers.GroupBy(c => c.Country).ToList();
                                var count = list.Select(g => new { Country = g.Key, Count = g.Count() });

                                Console.WriteLine("| Страна | Количество покупателей ");
                                foreach (var item in count)
                                {
                                    Console.WriteLine($"| {item.Country} | {item.Count} |");
                                }
                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 6)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var list = db.Customers.GroupBy(c => c.Country).ToList();
                                var count = list.Select(g => new { Country = g.Key, Count = g.Select(c => c.City).Distinct().Count() }).ToList();

                                Console.WriteLine("| Страна | Количество городов ");
                                foreach (var item in count)
                                {
                                    Console.WriteLine($"| {item.Country} | {item.Count} |");
                                }
                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 7)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var list = db.Customers.GroupBy(c => c.Country).ToList();
                                var count = list.Select(g => g.Select(c => c.City).Distinct().Count()).Sum();

                                Console.WriteLine($"Среднее количество городов: {count / list.Count()}");


                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 8)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите Id покупателя: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Выполняется загрузка списка...");
                            Console.WriteLine();
                            using (Context db = new Context())
                            {
                                var sections = db.Interests.Where(i => i.Customer_Id == id)
                                    .Select(i => i.Section)
                                    .Distinct()
                                    .ToList();

                                Console.WriteLine($"Список разделов в которых заинтересован покупатель {id}:");
                                foreach (var section in sections)
                                {
                                    Console.WriteLine(section);
                                }

                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 9)
                    {
                        try
                        {
                            Console.Write("Введите название категории: ");
                            string section = Console.ReadLine();
                            Console.Write("Введите дату начала акции в формате 2023-12-31 10:00 АМ/РМ: ");
                            string start_time = Console.ReadLine();
                            Console.Write("Введите дату окончания акции в формате 2023-12-31 10:00 АМ/РМ: ");
                            string end_time = Console.ReadLine();
                            Console.WriteLine("Выполняется загрузка списка...");
                            Console.WriteLine();
                            using (Context db = new Context())
                            {
                                var products = db.Promotions.Where(p => p.Section == section && p.Start_time == start_time && p.End_time == end_time)
                                    .Select(p => p.Product)
                                    .ToList();

                                Console.WriteLine($"Список акционных товаров категории {section} за {start_time} - {end_time}:");
                                Console.WriteLine();
                                foreach (var product in products)
                                {
                                    Console.WriteLine(product);
                                }
                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 10)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите Id покупателя: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Выполняется загрузка списка...");
                            Console.WriteLine();
                            using (Context db = new Context())
                            {
                                string section = db.Interests.Where(i => i.Customer_Id == id).Select(i => i.Section).FirstOrDefault();
                                var products = db.Promotions.Where(p => p.Section == section).Select(p => p.Product);

                                Console.WriteLine($"Список акционных товаров покупателя {id}:");
                                Console.WriteLine();
                                foreach (var product in products)
                                {
                                    Console.WriteLine(product);
                                }

                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 11)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var grouped = db.Customers.GroupBy(c => c.Country).ToList();
                                var top = grouped.OrderByDescending(g => g.Count()).Take(3).ToList();

                                Console.WriteLine("| Место | Страна | Количество покупателей |");
                                for (int i = 0; i < top.Count; i++)
                                {
                                    int place = i + 1;
                                    string country = top[i].Key; 
                                    int count = top[i].Count(); 

                                    Console.WriteLine($"| {place} | {country} | {count} |");
                                }

                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 12)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var list = db.Customers.GroupBy(c => c.Country).ToList();
                                var count = list.Select(g => g.Count()).ToList();
                                var max_count = count.OrderByDescending(c => c).FirstOrDefault();
                                var country = list.FirstOrDefault(g => g.Count() == max_count)?.Key;

                                Console.WriteLine("| Название страны | Количество покупателей |");
                                Console.WriteLine($"| {country} | {max_count} |");
                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 13)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var grouped = db.Customers.GroupBy(c => c.City).ToList();
                                var top = grouped.OrderByDescending(g => g.Count()).Take(3).ToList();

                                Console.WriteLine("| Место | Город | Количество покупателей |");
                                for (int i = 0; i < top.Count; i++)
                                {
                                    int place = i + 1;
                                    string city = top[i].Key;
                                    int count = top[i].Count();

                                    Console.WriteLine($"| {place} | {city} | {count} |");
                                }

                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 14)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выполняется загрузка таблицы...");
                            using (Context db = new Context())
                            {
                                var list = db.Customers.GroupBy(c => c.City).ToList();
                                var count = list.Select(g => g.Count()).ToList();
                                var max_count = count.OrderByDescending(c => c).FirstOrDefault();
                                var city = list.FirstOrDefault(g => g.Count() == max_count)?.Key;

                                Console.WriteLine("| Название города | Количество покупателей |");
                                Console.WriteLine($"| {city} | {max_count} |");
                                Console.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 15)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        if (key_one == 2)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1 - Искать в таблице 'Покупатели'");
                    Console.WriteLine("2 - Искать в таблице 'Интересы'");
                    Console.WriteLine("3 - Искать в таблице 'Акционные товары'");
                    Console.WriteLine("4 - Вернуться в основное меню");
                    Console.WriteLine();
                    Console.Write("Введите номер опции и нажмите Enter: ");
                    int key_two = Convert.ToInt32(Console.ReadLine());

                    if (key_two == 1)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите ключевое слово: ");
                            string word = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                var search = db.Customers.Where(
                                    c => c.Full_name.Contains(word) ||
                                    c.Date_of_birth.Contains(word) ||
                                    c.Gender.Contains(word) ||
                                    c.Email.Contains(word) ||
                                    c.Country.Contains(word) ||
                                    c.City.Contains(word));

                                if (search.Any())
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("| ID | Имя фамилия | Дата рождения | Пол | Электронная почта | Страна | Город |");

                                    foreach (var customer in search)
                                    {
                                        Console.WriteLine($"| {customer.Id} | {customer.Full_name} | {customer.Date_of_birth} | {customer.Gender} | {customer.Email} | {customer.Country} | {customer.City} |");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Записей не найдено.");
                                }
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 2)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите ключевое слово: ");
                            string word = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                var search = db.Interests.Where(
                                    c => c.Customer_Id == Convert.ToInt32(word) ||
                                    c.Section.Contains(word));

                                if (search.Any())
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("| ID | Id покупателя | Категория |");

                                    foreach (var interests in search)
                                    {
                                        Console.WriteLine($"| {interests.Id} | {interests.Customer_Id} | {interests.Section} |");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Записей не найдено.");
                                }
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 3)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите ключевое слово: ");
                            string word = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                var search = db.Promotions.Where(
                                    c => c.Country.Contains(word) ||
                                    c.City.Contains(word) ||
                                    c.Section.Contains(word) ||
                                    c.Product.Contains(word) ||
                                    c.Start_time.Contains(word) ||
                                    c.End_time.Contains(word));

                                if (search.Any())
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("| ID | Страна | Город | Категория | Товар | Дата начала акции | Дата окончания акции |");

                                    foreach (var promotion in search)
                                    {
                                        Console.WriteLine($"| {promotion.Id} | {promotion.Country} | {promotion.City} | {promotion.Section} | {promotion.Product} | {promotion.Start_time} | {promotion.End_time} |");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Записей не найдено.");
                                }
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 4)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        if (key_one == 3)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1 - Добавить в таблицу 'Покупатели'");
                    Console.WriteLine("2 - Добавить в таблицу 'Интересы'");
                    Console.WriteLine("3 - Добавить в таблицу 'Акционные товары'");
                    Console.WriteLine("4 - Вернуться в основное меню");
                    Console.WriteLine();
                    Console.Write("Введите номер опции и нажмите Enter: ");
                    int key_two = Convert.ToInt32(Console.ReadLine());

                    if (key_two == 1)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите имя и фамилию: ");
                            string full_name = Console.ReadLine();
                            Console.Write("Введите дату рождения:");
                            string date_of_birth = Console.ReadLine();
                            Console.Write("Введите пол: ");
                            string gender = Console.ReadLine();
                            Console.Write("Введите электронную почту: ");
                            string email = Console.ReadLine();
                            Console.Write("Введите страну: ");
                            string country = Console.ReadLine();
                            Console.Write("Введите город: ");
                            string city = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                Customers c = new Customers
                                {
                                    Full_name = full_name,
                                    Date_of_birth = date_of_birth,
                                    Gender = gender,
                                    Email = email,
                                    Country = country,
                                    City = city
                                };

                                db.Customers.Add(c);
                                db.SaveChanges();
                            }
                            Console.WriteLine("Данные успешно добавлены в таблицу!");
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 2)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите Id покупателя: ");
                            int customer_id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите категорию: ");
                            string section = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                Interests i = new Interests
                                {
                                    Customer_Id = customer_id,
                                    Section = section
                                };

                                db.Interests.Add(i);
                                db.SaveChanges();
                            }
                            Console.WriteLine("Данные успешно добавлены в таблицу!");
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 3)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите страну: ");
                            string country = Console.ReadLine();
                            Console.Write("Введите город: ");
                            string city = Console.ReadLine();
                            Console.Write("Введите категирию: ");
                            string section = Console.ReadLine();
                            Console.Write("Введите название товара: ");
                            string product = Console.ReadLine();
                            Console.Write("Введите дату и время начала акции: ");
                            string start_time = Console.ReadLine();
                            Console.Write("Введите дату и время конца акции: ");
                            string end_time = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                Promotions p = new Promotions
                                {
                                    Country = country,
                                    City = city,
                                    Section = section,
                                    Product = product,
                                    Start_time = start_time,
                                    End_time = end_time
                                };

                                db.Promotions.Add(p);
                                db.SaveChanges();
                            }
                            Console.WriteLine("Данные успешно добавлены в таблицу!");
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 4)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        if (key_one == 4)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1 - Изменить в таблице 'Покупатели'");
                    Console.WriteLine("2 - Изменить в таблице 'Интересы'");
                    Console.WriteLine("3 - Изменить в таблице 'Акционные товары'");
                    Console.WriteLine("4 - Вернуться в основное меню");
                    Console.WriteLine();
                    Console.Write("Введите номер опции и нажмите Enter: ");
                    int key_two = Convert.ToInt32(Console.ReadLine());

                    if (key_two == 1)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите значение для замены: ");
                            string old_value = Console.ReadLine();
                            Console.Write("Введите новое значение: ");
                            string new_value = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                var update = db.Customers.Where(
                                    c => c.Full_name == old_value ||
                                    c.Date_of_birth == old_value ||
                                    c.Gender == old_value ||
                                    c.Email == old_value ||
                                    c.Country == old_value ||
                                    c.City == old_value);

                                if (update.Any())
                                {
                                    foreach (var customer in update)
                                    {
                                        if (customer.Full_name == old_value)
                                            customer.Full_name = new_value;

                                        if (customer.Date_of_birth == old_value)
                                            customer.Date_of_birth = new_value;

                                        if (customer.Gender == old_value)
                                            customer.Gender = new_value;

                                        if (customer.Email == old_value)
                                            customer.Email = new_value;

                                        if (customer.Country == old_value)
                                            customer.Country = new_value;

                                        if (customer.City == old_value)
                                            customer.City = new_value;
                                    }

                                    db.SaveChanges();
                                    Console.WriteLine("Значение было успешно обновлено!");
                                }
                                else
                                {
                                    Console.WriteLine("Значение для замены не найдено.");
                                }
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 2)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите значение для замены: ");
                            string old_value = Console.ReadLine();
                            Console.Write("Введите новое значение: ");
                            string new_value = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                var update = db.Interests.Where(
                                    c => c.Customer_Id.ToString() == old_value ||
                                    c.Section == old_value);

                                if (update.Any())
                                {
                                    foreach (var interest in update)
                                    {
                                        if (interest.Customer_Id.ToString() == old_value)
                                            interest.Customer_Id = Convert.ToInt32(new_value);

                                        if (interest.Section == old_value)
                                            interest.Section = new_value;
                                    }
                                    db.SaveChanges();
                                    Console.WriteLine("Значение было успешно обновлено!");
                                }
                                else
                                {
                                    Console.WriteLine("Значение для замены не найдено.");
                                }

                                db.SaveChanges();
                            }
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 3)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите значение для замены: ");
                            string old_value = Console.ReadLine();
                            Console.Write("Введите новое значение: ");
                            string new_value = Console.ReadLine();
                            using (Context db = new Context())
                            {
                                var update = db.Promotions.Where(
                                    c => c.Country == old_value ||
                                    c.City == old_value ||
                                    c.Section == old_value ||
                                    c.Product == old_value ||
                                    c.Start_time == old_value ||
                                    c.End_time == old_value);

                                if (update.Any())
                                {
                                    foreach (var promotion in update)
                                    {
                                        if (promotion.Country == old_value)
                                            promotion.Country = new_value;

                                        if (promotion.City == old_value)
                                            promotion.City = new_value;

                                        if (promotion.Section == old_value)
                                            promotion.Section = new_value;

                                        if (promotion.Product == old_value)
                                            promotion.Product = new_value;

                                        if (promotion.Start_time == old_value)
                                            promotion.Start_time = new_value;

                                        if (promotion.End_time == old_value)
                                            promotion.End_time = new_value;
                                    }

                                    db.SaveChanges();
                                    Console.WriteLine("Значение было успешно обновлено!");
                                }
                                else
                                {
                                    Console.WriteLine("Значение для замены не найдено.");
                                }
                            }
                            Console.WriteLine("Значение было успешно обновлено!");
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 4)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        if (key_one == 5)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1 - Удалить в таблице 'Покупатели'");
                    Console.WriteLine("2 - Удалить в таблице 'Интересы'");
                    Console.WriteLine("3 - Удалить в таблице 'Акционные товары'");
                    Console.WriteLine("4 - Вернуться в основное меню");
                    Console.WriteLine();
                    Console.Write("Введите номер опции и нажмите Enter: ");
                    int key_two = Convert.ToInt32(Console.ReadLine());

                    if (key_two == 1)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите Id записи для удаления: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            using (Context db = new Context())
                            {
                                var delete = db.Customers.Find(id);
                                if (delete != null)
                                {
                                    db.Customers.Remove(delete);
                                    db.SaveChanges();
                                }
                            }
                            Console.WriteLine("Запись была успешно удалена!");
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 2)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите Id записи для удаления: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            using (Context db = new Context())
                            {
                                var delete = db.Interests.Find(id);
                                if (delete != null)
                                {
                                    db.Interests.Remove(delete);
                                    db.SaveChanges();
                                }
                            }
                            Console.WriteLine("Запись была успешно удалена!");
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 3)
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.Write("Введите Id записи для удаления: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            using (Context db = new Context())
                            {
                                var delete = db.Promotions.Find(id);
                                if (delete != null)
                                {
                                    db.Promotions.Remove(delete);
                                    db.SaveChanges();
                                }
                            }
                            Console.WriteLine("Запись была успешно удалена!");
                            Console.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ошибка: {ex.Message}");
                            Console.WriteLine();
                        }
                    }

                    if (key_two == 4)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
        }

        if (key_one == 6)
        {
            return 0;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine();
        Console.WriteLine($"Ошибка: {ex.Message}");
        Console.WriteLine();
    }
}


class Customers
{
    public int Id { get; set; }
    public string Full_name { get; set; }
    public string Date_of_birth { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
}
class Interests
{
    public int Id { get; set; }
    public int Customer_Id { get; set; }
    public string Section { get; set; }
}

class Promotions
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Section { get; set; }
    public string Product { get; set; }
    public string Start_time { get; set; }
    public string End_time { get; set; }
}

class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Promotion_goods.db");
    }

    public DbSet<Customers> Customers { get; set; }
    public DbSet<Interests> Interests { get; set; }
    public DbSet<Promotions> Promotions { get; set; }
}

