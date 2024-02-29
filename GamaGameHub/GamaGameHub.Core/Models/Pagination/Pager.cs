using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Models.Pagination
{
    public class Pager
    {
        public Pager() { }

        public Pager(int totalItems, int page, int pageSize = 10) 
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            int currentPage = page;

            int startPage = currentPage - 2 <= 0 ? 1 : currentPage - 2;
            int endPage = currentPage + 2 > totalPages ? totalPages : currentPage + 2;

            if (endPage > 5) { startPage = endPage - 4; }

            this.TotalItems = totalItems;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.StartPage = startPage;
            this.EndPage = endPage;
        }

        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int StartPage { get; private set; }
        public int EndPage { get; private set; }

        public string? Controller { get; set; }
    }
}
