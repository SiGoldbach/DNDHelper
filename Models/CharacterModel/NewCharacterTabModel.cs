using DNDHelper.Models.Monsters;
using DNDHelper.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.CharacterModel
{
    public class NewCharacterTabModel: ModelBase
    {
        private Classes _classes;

        public Classes Clas
        {
            get { return _classes; }
            set
            {
                _classes = value;
                OnPropertyChanged(nameof(Clas));


            }
        }
        public NewCharacterTabModel() {
            _classes = new Classes(0, []);

        }
    }
}
