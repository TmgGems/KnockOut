using ProductCrudKnockOut.Models;

namespace ProductCrudKnockOut.Services
{
    public interface ICompanyService
    {
        List<CompanyModel> GetAll();

        CompanyModel GetById(int id);

        bool Add(CompanyModel model);

        void Updates(CompanyModel model);

        int Delete(int id);
    }
}
