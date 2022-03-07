using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Subscriber
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string vokativ { get; set; }
        public int? bounce_soft { get; set; }
        public int? bounce_soft_count { get; set; }
        public int? bounced_hard { get; set; }
        public object bounce_message { get; set; }
        public string inserted_at { get; set; }
        public object last_position { get; set; }
        public double rating { get; set; }
        public object pipl { get; set; }
        public string nameday { get; set; }
        public string source { get; set; }
        public object company { get; set; }
        public object street { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public object zip { get; set; }
        public object phone { get; set; }
        public object pretitle { get; set; }
        public object surtitle { get; set; }
        public object birthday { get; set; }
        public string notes { get; set; }
        public string vokativ_s { get; set; }
        public object optimized_delivery { get; set; }
        public object tags { get; set; }
        public object automations { get; set; }
        public object pageviews { get; set; }
        public object webevents { get; set; }
        public object last_delivery { get; set; }
        public object last_open { get; set; }
        public object last_click { get; set; }
        public object last_pageview { get; set; }
        public object last_transaction_id { get; set; }
        public object last_transaction { get; set; }
        public object raynet_id { get; set; }
        public int? active { get; set; }
    }

    public class Datum
    {
        public int? id { get; set; }
        public int? list_id { get; set; }
        public string email { get; set; }
        public int? status { get; set; }
        public object subscribed_at { get; set; }
        public object unsubscribed_at { get; set; }
        public object unsub_reason { get; set; }
        public List<object> custom_fields { get; set; }
        public string c_fields { get; set; }
        public object groups { get; set; }
        public string source { get; set; }
        public List<object> status_history { get; set; }
        public int? sms_status { get; set; }
        public Subscriber subscriber { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string label { get; set; }
        public bool active { get; set; }
    }

    public class Root
    {
        public int? current_page { get; set; }
        public List<Datum> data { get; set; }
        public string first_page_url { get; set; }
        public int? from { get; set; }
        public int? last_page { get; set; }
        public string last_page_url { get; set; }
        public List<Link> links { get; set; }
        public object next_page_url { get; set; }
        public string path { get; set; }
        public int? per_page { get; set; }
        public object prev_page_url { get; set; }
        public int? to { get; set; }
        public int? total { get; set; }
    }


}
