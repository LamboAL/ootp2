using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ootp2.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Genre = "fiction" });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Genre = "fiction" });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Genre = "fiction" });

            base.Seed(db);
        }
    }
}