namespace Ottobus.Repositories
{
    public interface IOrtakRepository<T>
    {
        void kaydetGuncelle(T nesne);
        
        void sil(T nesne);

        T idIleBul(long id);
    }
}