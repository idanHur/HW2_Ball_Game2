namespace HW2
{
    public interface IPagedDataProvider
    {
        void LoadPage(int pageNumber);
        int GetTotalPages();
    }
}