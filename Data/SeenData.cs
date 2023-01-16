using Microsoft.EntityFrameworkCore;
using WebCandleShopNet7.Models;

namespace WebCandleShopNet7.Data
{
    public class SeenData
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            context.Database.Migrate();

            if (!context.Candles.Any())
            {


                context.Candles.AddRange(
                        new Candle
                        {
                            Name = "Nuts",
                            Description = "Ореховый батончик относится к классу унисекс и станет любтмым запахом в каждом доме ",
                            Price = 67,

                        },
                        new Candle
                        {
                            Name = "Raspberry & mint",
                            Description = "Мята и малина - это удачное сочетание привычных и знакомых нам ароматов",
                            Price = 48,

                        },
                        new Candle
                        {
                            Name = "Monaco sun",
                            Description = "Аромат окунет вас в атмосферу сладких тропиков",
                            Price = 66,
                        },
                        new Candle
                        {
                            Name = "Andromeda",
                            Description = "По мотивам парфюма унисекс Andromeda Tiziana Terenzi",
                            Price = 65,
                        },
                        new Candle
                        {
                            Name = "Currant & Chili pepper",

                            Description = "В аромате обьеденены два совершенно разноплановыъ аромата которые создали удивительную композицию",
                            Price = 55,

                        },
                        new Candle
                        {
                            Name = "Mulled wine",
                            Description = "Настоящий аромат горячего напитка из винограда",
                            Price = 35,
                        },
                        new Candle
                        {
                            Name = "Green tea",
                            Description = "Аромат зеленого чая ",
                            Price = 40,
                        },
                        new Candle
                        {
                            Name = "Lost cherry",
                            Description = "По мотивам Tom Ford",
                            Price = 50,
                        }
                );

                context.SaveChanges();
            }
        }
    }
}
