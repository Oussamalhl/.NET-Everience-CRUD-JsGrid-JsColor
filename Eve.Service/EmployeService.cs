using Eve.Data.Infrastructures;
using Eve.Domain;


namespace Eve.Service
{
    public class EmployeService: Service<Employe>,IEmployeService
    {
        IUnitOfWork utk;
        public EmployeService(IUnitOfWork utk):base(utk)
        {
            this.utk = utk;
        }

    }
}
