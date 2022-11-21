

namespace Eve.Data.Infrastructures
{
    public interface IDataBaseFactory:IDisposable
    {
        EveDbSet DataContext { get; }
    }
}
