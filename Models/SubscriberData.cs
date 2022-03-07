namespace WebAPI.Models
{
    public class SubscriberData
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? email { get; set; }

        public SubscriberData(string name, string surname, string email)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
        }
    }

    public class SubscriberDataRoot
    {
        public SubscriberData subscriber_data { get; set; }
    }

    public class SubscriberDataUpdateRoot
    {
        public string email { get; set; }
        public SubscriberData subscriber_data { get; set; }
    }
}
