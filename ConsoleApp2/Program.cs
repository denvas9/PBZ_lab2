using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    namespace pbz_2
    {
        class Program
        {
            public static MySqlConnection conn;
            public static void AddSomeRecords()
            {
                AddWorker("Иванов Иван", "Майор", "проверяющий");
                AddWorker("Петров Иван", "Капитан", "проверяющий");
                AddWorker("Сидоров Василий", "Сержант", "проверяющий");

                AddCar(648, 446, "красн.", "лада", 1246);
                AddCar(645, 444, "зелён.", "уаз", 1328);
                AddCar(644, 443, "син.", "газ", 1327);
                AddCar(646, 445, "оранж.", "маз", 1432);

                AddOwner("Петров Петр", "г. Воронеж", "м", 1998, 8765, 644);
                AddOwner("Сидорова Ольга", "г. Воронеж", "ж", 1999, 8766, 645);
                AddOwner("Иванова Елена", "г. Воронеж", "ж", 1995, 8767, 646);
                AddOwner("Смирнов Сергей", "г. Путинград", "м", 1996, 8768, 648);

                AddInspection("Иванов Иван", "2012-04-20", "ok", 645);
                AddInspection("Петров Иван", "2012-08-22", "ok", 645);
                AddInspection("Петров Иван", "2012-08-22", "ok", 648);
                AddInspection("Петров Иван", "2012-08-22", "ok", 644);
                AddInspection("Петров Иван", "2012-08-22", "ok", 646);
                AddInspection("Петров Иван", "2012-08-22", "ok", 646);
                AddInspection("Петров Иван", "2012-08-22", "ok", 646);
                AddInspection("Петров Иван", "2012-08-22", "ok", 646);
                AddInspection("Петров Иван", "2012-08-22", "ok", 646);
                AddInspection("Петров Иван", "2012-08-22", "ok", 646);
                AddInspection("Петров Иван", "2012-08-22", "ok", 646);
                AddInspection("Сидоров Василий", "2011-07-14", "ok", 648);
                AddInspection("Сидоров Василий", "2011-09-14", "ok", 648);
                AddInspection("Сидоров Василий", "2011-11-14", "ok", 648);
                AddInspection("Сидоров Василий", "2012-01-14", "ok", 648);
            }
            public static void UserInterface()
            {
                while (true)
                {
                    Console.WriteLine("\nВыберите нужную функцию (формат даты при вводе - ГГГГ-ММ-ДД):\n" +
                        "добавить сотрудника - 1,\n" +
                        "изменить данные сотрудника - 2,\n" +
                        "удалить сотрудника - 3,\n" +
                        "добавить автомобиль - 4,\n" +
                        "изменить данные автомобиля - 5,\n" +
                        "удалить автомобиль - 6,\n" +
                        "добавить владельца авто - 7,\n" +
                        "изменить данные владельца авто - 8,\n" +
                        "удалить владельца авто - 9,\n" +
                        "добавить осмотр - 10,\n" +
                        "изменить данные осмотра - 11,\n" +
                        "удалить осмотр - 12,\n" +
                        "Расчет количества автомобилей, прошедших техосмотр за заданный промежуток времени с разбивкой по дням - 13,\n" +
                        "Просмотр списка сотрудников ГАИ, проводивших осмотр на заданную дату - 14,\n" +
                        "Просмотр истории прохождения осмотров заданным автомобилем - 15,\n" +
                        "Просмотр таблиц базы - 16,\n" +
                        "Выход - 17\n");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите ФИО\n");
                                string name = Console.ReadLine();
                                Console.WriteLine("Введите звание\n");
                                string rank = Console.ReadLine();
                                Console.WriteLine("Введите должность\n");
                                string position = Console.ReadLine();
                                AddWorker(name, rank, position);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Введите ФИО (должно совпадать с существующей записью)\n");
                                string name = Console.ReadLine();
                                Console.WriteLine("Введите звание\n");
                                string rank = Console.ReadLine();
                                Console.WriteLine("Введите должность\n");
                                string position = Console.ReadLine();
                                EditWorker(name, rank, position);
                                break;

                            }
                        case 3:
                            {                                
                                Console.WriteLine("Введите ФИО (должно совпадать с существующей записью)\n");
                                string name = Console.ReadLine();
                                DeleteWorker(name);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Введите регистрационный номер\n");
                                int car_reg_number = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите номер двигателя\n");
                                int car_engine_id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите цвет\n");
                                string car_color = Console.ReadLine();
                                Console.WriteLine("Введите марку\n");
                                string car_model = Console.ReadLine();
                                Console.WriteLine("Введите номер тех. паспорта\n");
                                int car_tech_pass_number = Convert.ToInt32(Console.ReadLine());
                                AddCar(car_reg_number, car_engine_id, car_color, car_model, car_tech_pass_number);
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Введите регистрационный номер (должно совпадать с существующей записью)\n");
                                int car_reg_number = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите номер двигателя\n");
                                int car_engine_id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите цвет\n");
                                string car_color = Console.ReadLine();
                                Console.WriteLine("Введите марку\n");
                                string car_model = Console.ReadLine();
                                int car_tech_pass_number = Convert.ToInt32(Console.ReadLine());
                                EditCar(car_reg_number, car_engine_id, car_color, car_model, car_tech_pass_number);
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Введите регистрационный номер (должно совпадать с существующей записью)\n");
                                int car_reg_number = Convert.ToInt32(Console.ReadLine());
                                DeleteCar(car_reg_number);
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Введите ФИО\n");
                                string owner_name = Console.ReadLine();
                                Console.WriteLine("Введите адрес\n");
                                string owner_adress = Console.ReadLine();
                                Console.WriteLine("Введите пол\n");
                                string owner_sex = Console.ReadLine();
                                Console.WriteLine("Введите год рождения\n");
                                int owner_birth_year = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите лицензию\n");
                                int owner_license = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите регистрационный номер автомобиля\n");
                                int car_reg_number = Convert.ToInt32(Console.ReadLine());
                                AddOwner(owner_name, owner_adress, owner_sex, owner_birth_year, owner_license, car_reg_number);
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("Введите ФИО\n");
                                string owner_name = Console.ReadLine();
                                Console.WriteLine("Введите адрес\n");
                                string owner_adress = Console.ReadLine();
                                Console.WriteLine("Введите пол\n");
                                string owner_sex = Console.ReadLine();
                                Console.WriteLine("Введите год рождения\n");
                                int owner_birth_year = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите лицензию (должно совпадать с существующей записью)\n");
                                int owner_license = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите регистрационный номер автомобиля\n");
                                int car_reg_number = Convert.ToInt32(Console.ReadLine());
                                EditOwner(owner_name, owner_adress, owner_sex, owner_birth_year, owner_license, car_reg_number);
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine("Введите лицензию\n");
                                int owner_license = Convert.ToInt32(Console.ReadLine());
                                DeleteOwner(owner_license);
                                break;
                            }
                        case 10:
                            {
                                Console.WriteLine("Введите ФИО проверяющего\n");
                                string inspector = Console.ReadLine();
                                Console.WriteLine("Введите дату\n");
                                string date = Console.ReadLine();
                                //проверка на кол-во осмотров за день
                                int check=InspectionsCheck(date, inspector);
                                if (check >= 10)
                                {
                                    Console.WriteLine("слишком большое кол-во осмотров у сотрудника в выбранный день\n");
                                    break;
                                }
                                Console.WriteLine("Введите результат проверки\n");
                                string inspection_result = Console.ReadLine();
                                Console.WriteLine("Введите регистрационный номер автомобиля\n");
                                int car_reg_number = Convert.ToInt32(Console.ReadLine());
                                AddInspection(inspector, date, inspection_result, car_reg_number);
                                break;
                            }
                        case 11:
                            {
                                Console.WriteLine("Введите ID осмотра (должно совпадать с существующей записью)\n");
                                int inspection_id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите ФИО проверяющего\n");
                                string inspector = Console.ReadLine();
                                Console.WriteLine("Введите дату\n");
                                string date = Console.ReadLine();
                                Console.WriteLine("Введите результат проверки\n");
                                string inspection_result = Console.ReadLine();
                                Console.WriteLine("Введите регистрационный номер автомобиля\n");
                                int car_reg_number = Convert.ToInt32(Console.ReadLine());
                                EditInspection(inspection_id,inspector, date, inspection_result, car_reg_number);
                                break;
                            }
                        case 12:
                            {
                                Console.WriteLine("Введите ID осмотра (должно совпадать с существующей записью)\n");
                                int inspection_id = Convert.ToInt32(Console.ReadLine());
                                DeleteInspection(inspection_id);
                                break;
                            }
                        case 13:
                            {
                                Console.WriteLine("Введите начальную дату\n");
                                string dateStart = Console.ReadLine();
                                Console.WriteLine("Введите конечную дату\n");
                                string dateEnd = Console.ReadLine();

                                CarCount(dateStart, dateEnd);
                                break;
                            }
                        case 14:
                            {
                                Console.WriteLine("Введите дату\n");
                                string date = Console.ReadLine();
                                GetDayInfo(date);
                                break;
                            }
                        case 15:
                            {
                                Console.WriteLine("Введите номер двигателя\n");
                                int engine_id = Convert.ToInt32(Console.ReadLine());
                                GetCarHistory(engine_id);
                                break;
                            }
                        case 16:
                            {
                                viewWorkers();
                                Console.WriteLine(" ");
                                viewCars();
                                Console.WriteLine(" ");
                                viewOwners();
                                Console.WriteLine(" ");
                                viewInspections();
                                Console.WriteLine(" ");
                                break;
                            }
                        case 17:
                            {
                                return;
                            }
                        default:
                            Console.WriteLine("Введите коррекное значение\n");
                                break;
                    }
                }
            }
            static void Main(string[] args)
            {
                conn = GetConnection("localhost", 3306, "bondagegaywebsite", "root", "e0cdd0");
                conn.Open();
               // AddSomeRecords(); // команда для заполнения таблиц (если там ещё нет записей)
                UserInterface();


                conn.Close();


            }

            #region workers
            public static void AddWorker(string name, string rank, string position)
            {
                string query = string.Format("INSERT INTO workers (worker_name,worker_rank,worker_position) VALUES ('{0}', '{1}', '{2}')", name, rank, position);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }

            public static void EditWorker(string name, string rank, string position)
            {
                string query = string.Format("Update workers SET worker_name='{0}',worker_rank='{1}',worker_position='{2}' where worker_name='{0}'", name, rank, position);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            public static void DeleteWorker(string name)
            {
                string query = string.Format("DELETE FROM workers WHERE worker_name='{0}'", name);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            #endregion

            #region Inspections

            public static void AddInspection(string inspector, string date, string inspection_result, int car_reg_number)
            {
                string query = string.Format("INSERT INTO inspections (inspector,date,inspection_result,car_reg_number) VALUES ('{0}', '{1}', '{2}', '{3}')", inspector, date, inspection_result, car_reg_number);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }

            public static void EditInspection(int inspection_id, string inspector, string date, string inspection_result, int car_reg_number)
            {
                string query = string.Format("Update inspections SET inspector='{0}',date='{1}',inspection_result='{2}',car_reg_number={3} WHERE inspection_id={4}", inspector, date, inspection_result, car_reg_number, inspection_id);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            public static void DeleteInspection(int inspection_id)
            {
                string query = string.Format("DELETE FROM inspections WHERE inspection_id={0}", inspection_id);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            #endregion

            #region car owners

            //`owner_name,owner_adress,owner_sex,owner_birth_yearowner_license` int NOT NULL,
            //PRIMARY KEY(`owner_license`),

            public static void AddOwner(string owner_name, string owner_adress, string owner_sex, int owner_birth_year, int owner_license, int car_reg_number)
            {
                string query = string.Format(
                    "INSERT INTO car_owner (owner_name, owner_adress, owner_sex, owner_birth_year,owner_license,car_reg_number) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    owner_name, owner_adress, owner_sex, owner_birth_year, owner_license, car_reg_number);

                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }

            public static void EditOwner(string owner_name, string owner_adress, string owner_sex, int owner_birth_year, int owner_license, int car_reg_number)
            {
                string query = string.Format(
                    "Update car_owner SET owner_name='{0}', owner_adress='{1}', owner_sex='{2}', owner_birth_year={3},owner_license={4},car_reg_number={5} where owner_license={4}",
                    owner_name, owner_adress, owner_sex, owner_birth_year, owner_license, car_reg_number);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            public static void DeleteOwner(int owner_license)
            {
                string query = string.Format("DELETE FROM car_owner WHERE owner_license={0}", owner_license);
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            #endregion

            #region cars
            //car_reg_number,car_engine_id,car_color,car_model,car_tech_pass_number

            public static void AddCar(int car_reg_number, int car_engine_id, string car_color, string car_model, int car_tech_pass_number)
            {
                string query = "INSERT INTO cars (car_reg_number,car_engine_id,car_color,car_model,car_tech_pass_number) " +
                    $"VALUES ('{car_reg_number}', '{car_engine_id}', '{car_color}', '{car_model}', '{car_tech_pass_number}')";

                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }

            public static void EditCar(int car_reg_number, int car_engine_id, string car_color, string car_model, int car_tech_pass_number)
            {
                string query =
                    $"Update cars SET car_reg_number='{car_reg_number}',car_engine_id='{car_engine_id}',car_color='{car_color}',car_model='{car_model}',car_tech_pass_number='{car_tech_pass_number}'" +
                    $" where car_reg_number='{car_reg_number}'";
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            public static void DeleteCar(int car_reg_number)
            {
                string query = $"DELETE FROM cars WHERE car_reg_number={car_reg_number}";
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
            }
            #endregion

            #region view_database
            static void viewOwners()
            {
                string sql =
                    $@"SELECT * FROM car_owner;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                Console.WriteLine("Owners");
                Console.WriteLine("owner_name, owner_adr, owner_sex, owner_birth_year, owner_license, car_reg_number");
                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString());
                }
                reader.Close(); // закрываем reader

            }
            static void viewCars()
            {
                string sql =
                    $@"SELECT * FROM cars;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                Console.WriteLine("Cars");
                Console.WriteLine("car_reg_number, car_engine_id, car_color, car_model, car_tech_pass_number");
                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString());
                }
                reader.Close(); // закрываем reader

            }
            static void viewWorkers()
            {
                string sql =
                    $@"SELECT * FROM workers";

                MySqlCommand command = new MySqlCommand(sql, conn);

                Console.WriteLine("Workers");
                Console.WriteLine("name, rank, worker_position");
                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
                reader.Close(); // закрываем reader

            }
            static void viewInspections()
            {
                string sql =
                    $@"SELECT * FROM inspections;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                Console.WriteLine("Inspections");
                Console.WriteLine("inspection id, inspector, date, inspection_result, car_reg_number");
                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString());
                }
                reader.Close(); // закрываем reader
            }
            static void viewInspectionIDs()
            {
                string sql =
                    $@"SELECT DISTINCT inspection_id FROM inspections;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString());
                }
                reader.Close(); // закрываем reader
            }
            #endregion

            static void CarCount(string dateStart, string dateEnd)
            {

                // 2011-07-14   2012-08-22
                string sql = $"SELECT count(DISTINCT inspections.car_reg_number), inspections.date FROM inspections WHERE inspections.date BETWEEN '{dateStart}' AND '{dateEnd}' GROUP BY date;";
                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("car_count, date");
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close(); // закрываем reader

            }

            static int InspectionsCheck(string date, string inspector)
            {
                string sql = $"SELECT count(*) FROM inspections WHERE inspections.date='{date}' AND inspections.inspector='{inspector}'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                return (int)(Int64)command.ExecuteScalar();
            }

            static void GetCarHistory(int engine_id)
            {
                string sql =
                    $@"SELECT inspections.date,inspections.inspection_result
                FROM inspections
                JOIN cars
                ON cars.car_reg_number = inspections.car_reg_number
                WHERE cars.car_engine_id ={engine_id}";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close(); // закрываем reader
            }
            static void GetDayInfo(string date)
            {
                string sql =
                    $@"SELECT 
                workers.worker_name,
                 workers.worker_rank,
                inspections.car_reg_number
                FROM inspections
                JOIN workers
                ON workers.worker_name=inspections.inspector
                WHERE inspections.date='{date}'";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
                reader.Close(); // закрываем reader
            }

            
            public static MySqlConnection GetConnection(string host, int port, string database, string username, string password)
            {
                string connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;

                MySqlConnection conn = new MySqlConnection(connString);

                return conn;
            }
        }
    }
}
