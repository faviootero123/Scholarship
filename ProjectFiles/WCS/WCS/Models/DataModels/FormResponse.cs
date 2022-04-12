using Newtonsoft.Json;

namespace WCS.Models
{
    public class FormResponse
    {
        public int Id { get; set; }

        public string Response { get; set; }

        //Nav Prop
        public int StudentFormId { get; set; }
        [JsonIgnore]
        public StudentForm StudentForm { get; set; }

        public int FormFieldId { get; set; }
        [JsonIgnore]
        public FormField FormField { get; set; }
    }
}
