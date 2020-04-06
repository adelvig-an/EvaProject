using System.Collections.Generic;

namespace _01_Eva.Model
{
    class Basket
    {
        public List<Category> Categories { get; set; } = new List<Category>()
        {
            new Category
            {
                Name = "Жилое помещение",
                Items = new List<object>(new List<Dwelling>()
                {
                    new Dwelling {Name = "Квартира"}
                })

            },
            new Category
            {
                Name = "Нежилое помещение",
                Items = new List<object>(new List<nonpremise>()
                {
                    new nonpremise {Name = "Офисно-торговый объект свободного назначения"},
                    new nonpremise {Name = "Офисы класса А, В"},
                    new nonpremise {Name = "Торговая недвижимость"},
                    new nonpremise {Name = "Производственно-складская недвижимость"}
                })

            },
            new Category
            {
                Name = "Здание",
                Items = new List<object>(new List<Building>()
                {
                    new Building {Name = "Жилой дом"},
                    new Building {Name = "Офисно-торговый объект свободного назначения"},
                    new Building {Name = "Офисы класса А, В"},
                    new Building {Name = "Торговая недвижимость"},
                    new Building {Name = "Производственно-складская недвижимость"}
                })

            },
            new Category
            {
                Name = "Здание с земельным участком",
                Items = new List<object>(new List<Building_plot>()
                {
                    new Building_plot {Name = "Жилой дом"},
                    new Building_plot {Name = "Офисно-торговый объект свободного назначения"},
                    new Building_plot {Name = "Офисы класса А, В"},
                    new Building_plot {Name = "Торговая недвижимость"},
                    new Building_plot {Name = "Производственно-складская недвижимость"}
                })

            },
            new Category
            {
                Name = "Земельный участок",
                Items = new List<object>(new List<Land_plot>()
                {
                    new Land_plot {Name = "Под индустриальную застройку"},
                    new Land_plot {Name = "Под офисно-торговую застройку"},
                    new Land_plot {Name = "Под многоквартирную жилую застройку"},
                    new Land_plot {Name = "Под объекты рекреации"},
                    new Land_plot {Name = "Под объекты придорожного сервиса"}
                })

            },
        };
    }
}
