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
        private MonstersURlAndNameList _monsters;

        public MonstersURlAndNameList Monsters
        {
            get { return _monsters; }
            set
            {
                _monsters = value;
                OnPropertyChanged(nameof(Monsters));
                

            }
        }
        private string _searchVal = "";
        public string SearchVal
        {
            get { return _searchVal; }
            set
            {
                _searchVal = value;
                OnPropertyChanged(nameof(SearchVal));
            }
        }
        public MonsterTabModel() {
            _monsters = new MonstersURlAndNameList(0, []);
            _currentMonster = Monster.MockMonster();
        }


        





    }
}
