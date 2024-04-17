using DNDHelper.Commands;
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


        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };



        private ObservableCollection<MonsterURLAndName> _monsterURLAndNames;

        public ObservableCollection<MonsterURLAndName> MonsterUrlAndNames
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
        public MonstersViewModel()
        {
            GetMonsterCommand = new GetMonsterCommand(this); 
            _monsterTabModel = new MonsterTabModel();
            MonsterTabModel = _monsterTabModel;
            InitMonsterList();
            ObservableCollection<MonsterURLAndName> TEMPMonsterUrlAndNames = new ObservableCollection<MonsterURLAndName>();
            for (int i = 0; i < MonsterTabModel.Monsters.Results.Count; i++)
            {
                TEMPMonsterUrlAndNames.Add(new MonsterURLAndName(MonsterTabModel.Monsters.Results[i].Name, MonsterTabModel.Monsters.Results[i].Index, MonsterTabModel.Monsters.Results[i].Url));
            }
            _monsterURLAndNames = TEMPMonsterUrlAndNames;


        }
        private async void InitMonsterList()
        {
            try
            {
                MonstersURlAndNameList TempMonsters = await Networking.ApiCall.GetAndDeserilize<MonstersURlAndNameList>(monsterBaseURl);
                _monsterTabModel.Monsters = TempMonsters;
                MonsterTabModel = _monsterTabModel;
                this.MonsterUrlAndNames= UpdateVisibleMonsterList();
                DisplaySpecificMonster(_monsterTabModel.Monsters.Results[0].Url);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public async void DisplaySpecificMonster(string monsterURL)
        {
            try
            {
                Monster TempMonster = await Networking.ApiCall.GetAndDeserilize<Monster>(monsterURL);
                _monsterTabModel.CurrentMonster = TempMonster;
                MonsterTabModel = _monsterTabModel;
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }         
        }
        //Function for updating the displayed list in the view should be called when the initial network call has been made 
        private ObservableCollection<MonsterURLAndName> UpdateVisibleMonsterList()
        {
            ObservableCollection<MonsterURLAndName> TEMPMonsterUrlAndNames = new ObservableCollection<MonsterURLAndName>();
            for (int i = 0; i < MonsterTabModel.Monsters.Results.Count; i++)
            {
                TEMPMonsterUrlAndNames.Add(new MonsterURLAndName(MonsterTabModel.Monsters.Results[i].Name, MonsterTabModel.Monsters.Results[i].Index, MonsterTabModel.Monsters.Results[i].Url));
            }
            return TEMPMonsterUrlAndNames;
        }



    }
}
