using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DmScreen2API.Models
{
    public class CharacterSheet
    {
        public int CharacterSheetId { get; set; }
        public string CharacterName { get; set; }
        public int Str{ get; set; }
        public int Dex{ get; set; }
        public int Con { get; set; }
        public int Int{ get; set; }
        public int Wis{ get; set; }
        public int Cha{ get; set; }
        public int Exp { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int AC { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public string ActionNotes { get; set; }
        public string EquipmentNotes { get; set; }
        public string CharacterNotes { get; set; }
        public string LootNotes { get; set; }
        public string ImageUrl { get; set; }
    }
}
