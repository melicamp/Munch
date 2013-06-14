using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MunchProject.Models
{
    public abstract class ModelBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
