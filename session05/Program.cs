using session05.Question_1.classes;

namespace session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1


            Rectangle rect = new Rectangle(10,10);
            rect.DisplayShapeInfo();

            Circle c = new Circle(10);
            c.DisplayShapeInfo();
            #endregion
        }
    }
}
