namespace ToDo_Uygulamasi
{
    public class CardModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int PeopleId { get; set; }
        public string Size { get; set; }

        public CardModel(string title, string content, int peopleId, string size)
        {
            Title = title;
            Content = content;
            PeopleId = peopleId;
            Size = size;
        }
    }
}
