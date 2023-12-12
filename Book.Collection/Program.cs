namespace Book.Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new Book[]
            {
             new Book
             {
                 Name = "Foo",
                 Author = "Bar",
             },

             new Book
             {
                Name = "Exel",
                Author = "Bar",
             },

            };
            BookColoection coloection = new BookColoection(array);

            Book book = coloection[1];

            book = coloection["Exel"];
        }
        // Класс обЪекта  Книга
        class Book
        {
            public string Name;
            public string Author;

        }

        //Класс обЪекта коллекция книг
        class BookColoection
        {
            //Закрытое поле , хранит книги в  виде массива 
            private Book[] collection;

            //Конструктор с добавлением массива книг
            public BookColoection(Book[] collection)
            {
                this.collection = collection;
            }

            //Индексатор по массиву 
            public Book this[int index]
            {
                get
                {
                    //Проверка индекса в диапазоне массива 
                    if (index >= 0 && index < collection.Length)
                    {
                        return collection[index];
                    }
                    else
                    {
                        return null;
                    }
                }
                private set
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < collection.Length)
                    {
                        collection[index] = value;
                    }
                }
            }
            public Book this[string name]
            {
                get
                {
                    for (int i = 0; i < collection.Length; i++)
                    {
                        if (collection[i].Name == name)
                        {
                            return collection[i];
                        }

                    }
                    return null;
                }
            }
        }
        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }

            public int this[int index]
            {
                get
                {
                    return array[index];
                }
                set
                {
                    array[index] = value;
                }
            }
        }
    }
}