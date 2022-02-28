using System;

namespace ToDo_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takım ataması
            TeamUserList.TeamList.Add(new TeamUserModel(1, "Yasemin"));
            TeamUserList.TeamList.Add(new TeamUserModel(2, "Arife"));
            TeamUserList.TeamList.Add(new TeamUserModel(3, "Ahmet"));
            TeamUserList.TeamList.Add(new TeamUserModel(4, "Mehmet"));
            TeamUserList.TeamList.Add(new TeamUserModel(5, "Ebru"));

            //Default Göre Ataması
            TodoLine.TodoLineList.Add(new CardModel("c#", "c# dersi", 1, CardSizeEnumModel.S.ToString()));
            TodoLine.TodoLineList.Add(new CardModel("php", "php dersi", 2, CardSizeEnumModel.M.ToString()));

            //Linelar Boarda Atanıyor, yani kart oluşturuluyor
            BoardModel.BoardModelDictionary.Add("TODO Line", TodoLine.TodoLineList);
            BoardModel.BoardModelDictionary.Add("IN PROGRESS Line", InProgress.InProgressList);
            BoardModel.BoardModelDictionary.Add("DONE Line", DoneLine.DoneLineList);

            Operations.Start();
            int select = int.Parse(Console.ReadLine());
            int control = Operations.ControlFunction(select);
            while (control == 0)
            {
                Operations.CallFunction(select);
                Operations.PrintBoard();
                Operations.Start();
                select = int.Parse(Console.ReadLine());
                control = Operations.ControlFunction(select);
            }
            Console.WriteLine("1-4 Aralığı Dışında bir Sayı Girildi, Çıkılıyor...");
            Console.WriteLine("Programı Sonlandırmak için Bir Tuşa Basınız...");
            //OperationController.PrintBoard();
            Console.ReadKey();
        }
    }
}
