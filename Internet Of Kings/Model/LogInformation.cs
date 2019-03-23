using System;
using System.ComponentModel.DataAnnotations.Schema;
using InternetOfKings.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InternetOfKings.Model
{
    public class LogInformation
    {
        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LogInformationEnum Type { get; set; }

        public DateTime Time { get; set; }
        public float Value { get; set; }
    }
}
