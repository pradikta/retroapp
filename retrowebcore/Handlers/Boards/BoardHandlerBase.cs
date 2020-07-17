﻿using retrowebcore.Persistences;

namespace retrowebcore.Handlers.Boards
{
    public abstract class BoardHandlerBase
    {
        protected readonly AppDbContext _context;
        public BoardHandlerBase(AppDbContext c)
        {
            _context = c;
        }
    }
}
