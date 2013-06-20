using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MunchProject.Models
{
    public class MunchModel : ModelBase
    {
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
        [JsonProperty("lifeCount")]
        public int LifeCount { get; set; }
        public WeaponModel RightHand { get; set; }
        public WeaponModel LeftHand { get; set; }
        public SuitModel Body { get; set; }
        public PantsModel Legs { get; set; }
    }
}