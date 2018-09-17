﻿using DapperExtensions.Mapper;
using Creekdream.SimpleDemo.Books;

namespace Creekdream.SimpleDemo.Mappers
{
    /// <summary>
    /// Book entity and table mapping
    /// </summary>
    public class BookMapper : ClassMapper<Book>
    {
        public BookMapper()
        {
            Table("Books");
            Map(x => x.Id).Key(KeyType.Guid);
            Map(x => x.User).Ignore();
            AutoMap();
        }
    }
}

