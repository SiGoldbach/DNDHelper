using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    public class MonsterTabModel
    {
        private readonly string monsterBaseURl = "/api/monsters";
        public MonstersURlAndNameList Monsters;


        public MonsterTabModel() {
            initMonsterList();
        }


        private async void initMonsterList()
        {
            try
            {

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                string MonstersAsJson = await Networking.ApiCall.GetAsync(monsterBaseURl);
                Console.WriteLine(MonstersAsJson);
                MonstersURlAndNameList? TempMonsters = JsonSerializer.Deserialize<MonstersURlAndNameList>(MonstersAsJson, options);
                if (TempMonsters != null)
                {
                    Monsters = TempMonsters;
                }
            }
            catch (Exception e){ 
                Console.WriteLine(e.StackTrace);
            }





        }





    }
}
