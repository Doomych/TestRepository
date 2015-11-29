
using System.Data.Entity;

namespace WebGitAPI.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Сто лет одиночества", Author = "Гарсиа Маркес Габриэль", Year = 1967 });
            db.Books.Add(new Book { Name = "День Шакала", Author = "Фредерик Форсайт", Year = 1971 });
            db.Books.Add(new Book { Name = "Чайка Джонатан Ливингстон", Author = "Бах Ричард", Year = 1970 });
            db.Books.Add(new Book { Name = "Мастер и Маргарита", Author = "Булгаков Михаил", Year = 1940 });
            db.Books.Add(new Book { Name = "Девушка с татуировкой дракона", Author = "Ларссон Стиг", Year = 2004 });
            db.Books.Add(new Book { Name = "Зеленая миля", Author = "Кинг Стивен", Year = 1996 });
            db.Books.Add(new Book { Name = "Игра престолов", Author = "Мартин Джордж", Year = 1996 });
            db.Books.Add(new Book { Name = "451 градус по Фаренгейту", Author = "Брэдбери Рэй", Year = 1953 });
            db.Books.Add(new Book { Name = "Код да Винчи", Author = "Браун Дэн", Year = 2003 });
            db.Books.Add(new Book { Name = "Исчезнувшая", Author = "Флинн Гиллиан", Year = 2012 });
            db.Books.Add(new Book { Name = "Три товарища", Author = "Эрих Мария Ремарк", Year = 1936 });
            db.Books.Add(new Book { Name = "Крёстный отец", Author = "Марио Пьюзо", Year = 1969 });

            base.Seed(db);
        }
    }
}