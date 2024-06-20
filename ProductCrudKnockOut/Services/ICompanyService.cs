﻿using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Models.ViewModels;

namespace ProductCrudKnockOut.Services
{
    public interface ICompanyService
    {
        List<CompanyModel> GetAll();

        List<CompanyProductViewModel> GetCompanieesWithProducts();
        CompanyModel GetById(int id);

        bool Add(CompanyModel model);

        void Updates(CompanyModel model);

        int Delete(int id);
    }
}
