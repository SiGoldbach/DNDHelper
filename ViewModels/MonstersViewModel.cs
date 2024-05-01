using DNDHelper.Commands;
using DNDHelper.Commands.NavigationCommands;
using DNDHelper.Models.Monsters;
using DNDHelper.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DNDHelper.ViewModels
{
    public class MonstersViewModel : ViewModelBase
    {
        private readonly string monsterBaseURl = "/api/monsters";

        public ICommand GetMonsterCommand { get; }

        public ICommand SearchForMonster {  get; }

        public ICommand RollProficiencyForMonsterCommand {  get; }

        private ObservableCollection<IndexNameUrlJosnType> _monsterURLAndNames;

        public ObservableCollection<IndexNameUrlJosnType> MonsterUrlAndNames
        {
            get { return _monsterURLAndNames; }
            set
            {
                _monsterURLAndNames = value;
                OnPropertyChanged(nameof(MonsterUrlAndNames));

            }
        }
        private MonsterTabModel _monsterTabModel;

        public MonsterTabModel MonsterTabModel
        {
            get { return _monsterTabModel; }
            set
            {
                _monsterTabModel = value;
                OnPropertyChanged(nameof(MonsterTabModel));

            }
        }
        private ProficiencyRoll _proficiencyRoll;

        public ProficiencyRoll ProficiencyRoll
        {
            get { return _proficiencyRoll; }
            set
            {
                _proficiencyRoll = value;
                OnPropertyChanged(nameof(ProficiencyRoll));

            }

        }

        public MonstersViewModel()
        {
            GetMonsterCommand = new GetMonsterCommand(this); 
            SearchForMonster = new SearchForMonsterCommand(this);
            RollProficiencyForMonsterCommand = new RollProficiencyCommand(this);
            _monsterTabModel = new MonsterTabModel();
            MonsterTabModel = _monsterTabModel;
            InitMonsterList();
            _monsterURLAndNames = InitVisibleMonsterList();
            _proficiencyRoll = ProficiencyRoll.MockProficiencyRoll();
        }
        //Constructor Helper function to get the list of monsters from the api 
        private async void InitMonsterList()
        {
            try
            {
                MonstersURlAndNameList TempMonsters = await Networking.ApiCall.GetAndDeserilize<MonstersURlAndNameList>(monsterBaseURl);
                _monsterTabModel.Monsters = TempMonsters;
                MonsterTabModel = _monsterTabModel;
                this.MonsterUrlAndNames= InitVisibleMonsterList();
                DisplaySpecificMonster(_monsterTabModel.Monsters.Results[0].Url);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        
        //Function for putting the full list of monster into the observable collection. SHOULD ONLY BE USED IN CONSTRUCTOR/CONSTRUCTOR HELPERS
        private ObservableCollection<IndexNameUrlJosnType> InitVisibleMonsterList()
        {
            return new ObservableCollection<IndexNameUrlJosnType>(MonsterTabModel.Monsters.Results
                .Select(monster => new IndexNameUrlJosnType(monster.Index, monster.Name, monster.Url)));
        }

        public ObservableCollection<IndexNameUrlJosnType> SearchInMonsterList(string searchInput)
        {
        return new ObservableCollection<IndexNameUrlJosnType>(MonsterTabModel.Monsters.Results
                .Where(monster => monster.Name.Contains(searchInput, StringComparison.CurrentCultureIgnoreCase))
                .Select(monster=>new IndexNameUrlJosnType(monster.Index,monster.Name,monster.Url)));   
        }
        public async void DisplaySpecificMonster(string monsterURL)
        {
            try
            {
                _proficiencyRoll = ProficiencyRoll.MockProficiencyRoll();
                Monster TempMonster = await Networking.ApiCall.GetAndDeserilize<Monster>(monsterURL);
                _monsterTabModel.CurrentMonster = TempMonster;
                MonsterTabModel = _monsterTabModel;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }


    }

}
