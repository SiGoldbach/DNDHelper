using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    public class MonsterTabModel:ModelBase
    {
        private MonstersURlAndNameList _monsters;
        private string _monsterName = "";

        private Monster _currentMonster;

        public Monster CurrentMonster
        {
            get { return _currentMonster; }
            set
            {
                _currentMonster = value;
                OnPropertyChanged(nameof(CurrentMonster));
            }
        }

        public MonstersURlAndNameList Monsters
        {
            get { return _monsters; }
            set
            {
                _monsters = value;
                OnPropertyChanged(nameof(Monsters));
                

            }
        }
        public MonsterTabModel() {
            _monsters = new MonstersURlAndNameList(0, []);
            _currentMonster = Monster.MockMonster();
        }


        





    }
}
