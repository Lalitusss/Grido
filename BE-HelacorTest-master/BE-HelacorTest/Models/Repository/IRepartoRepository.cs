namespace BE_HelacorTest.Models.Repository
{
    public interface IRepartoRepository
    {
        Task<List<Repartos>>GetListRepartos();
        Task<Repartos> GetReparto(int id);
    }
}
