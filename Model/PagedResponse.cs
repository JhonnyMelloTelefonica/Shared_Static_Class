﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Static_Class.Models
{
    public class PagedResponse
    {
        public static GenericPagedResponse<IEnumerable<T>> CreateGenericPagedReponse<T>(IEnumerable<T> pagedData, GenericPagedResponse<IEnumerable<T>> validFilter, int totalRecords)
        {
            var respose = new GenericPagedResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;
            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }

            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            return respose;
        }
        public static PagedModelResponse<IEnumerable<T>> CreatePagedReponse<T,C>(IEnumerable<T> pagedData, GenericPaginationModel<C> validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;
            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }

            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            return respose;
        }
        
        public static PagedModelResponse<IEnumerable<T>> CreateListaDemandasPagedReponse<T>(IEnumerable<T> pagedData, PaginationListaDemandasModel validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;

            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }
            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            return respose;
        }
        public static PagedModelResponse<IEnumerable<T>> CreatePagedReponse<T>(IEnumerable<T> pagedData, PaginationControleAcessoModel validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;

            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }
            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            return respose;
        }

    }
}