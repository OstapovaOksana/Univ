using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_ShowsCore.Models;

namespace Moto_ShowsCore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(mtContext context)
        {
            context.Database.EnsureCreated();

            if (context.Clients.Any())
            {
                return;   
            }

            var directors = new Directors[]
                {
                    new Directors{Name = "Коломієць Анатолій Петрович"},
                    new Directors{Name = "Павловська Юлія Олегівна"},
                    new Directors{Name = "Мацута Ілья Борисович"},
                    new Directors{Name = "Вишняков Сергій Дмитрович"},
                    new Directors{Name = "Каролінська Наталія Федорівна"},
                    new Directors{Name = "Семендяк Віктор Андрійович"},
                    new Directors{Name = "Метельська Оксана Вікторівна"},
                    new Directors{Name = "Коротун Ярослав Васильович"},
                    new Directors{Name = "Хомяк Віталій Олегович"},
                    new Directors{Name = "Татаренко Тетяна Олександрівна"}
                };
            foreach (Directors dir in directors)
            {
                context.Directors.Add(dir);
            }
            context.SaveChanges();

            var motoshows = new MotoShows[]
            {
                    new MotoShows{Name = "АвтоАльянс", Address = "Київ, вулиця Шевченка 122", DirectorsID = 1},
                    new MotoShows{Name = "Автосоюз", Address = "Київ, вулиця Ломоносова 76", DirectorsID = 2},
                    new MotoShows{Name = "MotoDrive", Address = "Львів, вулиця Леся Курбаса 12", DirectorsID = 3},
                    new MotoShows{Name = "Авто-Київ", Address = "Київ, проспект Перемоги 67", DirectorsID = 4},
                    new MotoShows{Name = "Автосвіт", Address = "Львів, вулиця Свободи 18", DirectorsID = 5},
                    new MotoShows{Name = "WordOfCars", Address = "Київ, вулиця Велика Васильківська 48", DirectorsID = 6},
                    new MotoShows{Name = "Auto Viking", Address = "Львів, вулиця Степана Бандери 56", DirectorsID = 7},
                    new MotoShows{Name = "Conix Auto", Address = "Київ, вулиця Леніна 82", DirectorsID = 8},
                    new MotoShows{Name = "Auto Hager", Address = "Київ, вулиця Сеченова 6", DirectorsID = 9},
                    new MotoShows{Name = "Bonsai Auto", Address = "Львів, вулиця Івана Франка 10", DirectorsID = 10}
             };
            foreach (MotoShows mt in motoshows )
            {
                context.MotoShows.Add(mt);
            }
            context.SaveChanges();
           
            var subdivisions = new Subdivisions[]
                {
                    new Subdivisions{MotoShowsID = 6, NumberOfEmployee = 6},
                    new Subdivisions{MotoShowsID = 7, NumberOfEmployee = 9},
                    new Subdivisions{MotoShowsID = 8, NumberOfEmployee = 12},
                    new Subdivisions{MotoShowsID = 9, NumberOfEmployee = 15},
                    new Subdivisions{MotoShowsID = 10, NumberOfEmployee = 4},
                    new Subdivisions{MotoShowsID = 11, NumberOfEmployee = 10},
                    new Subdivisions{MotoShowsID = 12, NumberOfEmployee = 8},
                    new Subdivisions{MotoShowsID = 13, NumberOfEmployee = 6},
                    new Subdivisions{MotoShowsID = 14, NumberOfEmployee = 15},
                    new Subdivisions{MotoShowsID = 15, NumberOfEmployee = 5}
                };
            foreach (Subdivisions div in subdivisions)
            {
                context.Subdivisions.Add(div);
            }
            context.SaveChanges();

            var cars = new Cars[]
                {
                    new Cars{Brand = "Mercedes-Benz E 250",Year = 2015,Cost = "887 151 грн.",MotoShowsID = 6},
                    new Cars{Brand = "Citroen C4",Year = 2018,Cost = "569 300 грн.",MotoShowsID = 7},
                    new Cars{Brand = "Audi Q7",Year = 2012,Cost = "694 528 грн.",MotoShowsID = 8},
                    new Cars{Brand = "Fiat Doblo",Year = 2015,Cost = "282 152 грн.",MotoShowsID = 9},
                    new Cars{Brand = "Renault Magnum 430",Year = 1998,Cost = "130 224 грн.",MotoShowsID = 10},
                    new Cars{Brand = "Subaru XV",Year = 2018,Cost = "880 900 грн.",MotoShowsID = 11},
                    new Cars{Brand = "Toyota Camry",Year = 2011,Cost = "487 059 грн.",MotoShowsID = 12},
                    new Cars{Brand = "Nissan Qashqai",Year = 2013,Cost = "351 009 грн.",MotoShowsID = 13},
                    new Cars{Brand = "Ford F-150",Year = 2005,Cost = "293 868 грн.",MotoShowsID = 14},
                    new Cars{Brand = "BMW X5",Year = 2011,Cost = "775 485 грн.",MotoShowsID = 15}
                };
            foreach (Cars c in cars)
            {
                context.Cars.Add(c);
            }
            context.SaveChanges();

            var clients = new Clients[]
                {
                    new Clients{Name = "Коляда Тетяна В'ячеславівна", Telephone = 0675432784,CarsID = 1},
                    new Clients{Name = "Мацюк Денис Степанович", Telephone = 0972643727,CarsID = 2},
                    new Clients{Name = "Феоктістов Руслан Олександрович", Telephone = 0962546173,CarsID = 3},
                    new Clients{Name = "Прокопчук Сергій Олегович", Telephone = 0962435837,CarsID = 4},
                    new Clients{Name = "Тройніцкий Олесандр Сергійович", Telephone = 0975342647,CarsID = 5},
                    new Clients{Name = "Бутенко Ігор Володимирович", Telephone = 0982653726,CarsID = 6},
                    new Clients{Name = "Остапов Микола Борисович", Telephone = 0671026910,CarsID = 7},
                    new Clients{Name = "Андросюк Роман Сергійович", Telephone = 0984562718,CarsID = 8},
                    new Clients{Name = "Соняк Софія Олександрівна", Telephone = 0961253672,CarsID = 9},
                    new Clients{Name = "Aбрамов Тимофійі Олексійович", Telephone = 0961463681,CarsID = 10}
                };
            foreach (Clients cl in clients)
            {
                context.Clients.Add(cl);
            }
            context.SaveChanges();
        }
    }
}
