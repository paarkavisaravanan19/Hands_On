namespace Hands_On
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook obj = new PhotoBook();
            int pageCount = obj.GetNumberPages();
            Console.WriteLine("pages: "+ pageCount);
            PhotoBook obj1 = new PhotoBook(32);
            int pageCount1 = obj1.GetNumberPages();
            Console.WriteLine("pages after adding: " + pageCount1);
            PhotoBook obj2 = new PhotoBook(200);
            int pageCount2 = obj2.GetNumberPages();
            Console.WriteLine("Large photo book pages: " + pageCount2);
            AddPhotoBook obj3 = new AddPhotoBook();
            int pageCount3 = obj3.GetNumberPages();
            Console.WriteLine("Add photo book pages: " + pageCount3);
        }
    }
    public class PhotoBook
    {
        int original_page;
        //default constructor
        public PhotoBook()
        {
            original_page = 16;
        }
        //parameterized constructor
        public PhotoBook(int new_page)
        {
            this.original_page = new_page ;
        }
        public int GetNumberPages()
        {
            return original_page;
        }

        
    }

    public class AddPhotoBook 
    {
        int albumpage = 0;
        //default constructor
        public AddPhotoBook()
        {
            albumpage = 64;
        }
        //parameterized constructor
        public int GetNumberPages()
        {
            return albumpage;
        }
    }

}